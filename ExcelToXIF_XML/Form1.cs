using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExcelToXIF_XML
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> _defaultValueDictionary;
        private readonly KeyValuePair<string, string> _defaultTrafficFr = new KeyValuePair<string, string>("GOODS_TRAFFIC_FR", "840");
        private readonly KeyValuePair<string, string> _defaultTrafficTo = new KeyValuePair<string, string>("GOODS_TRAFFIC_TO", "031");
        private readonly KeyValuePair<string, string> _defaultCurrencyType = new KeyValuePair<string, string>("QUANTITY_OF_GOODS", "1");
        private readonly KeyValuePair<string, string> _defaultDirection = new KeyValuePair<string, string>("DIRECTION", "1");
        private readonly KeyValuePair<string, string> _defaultQuantityOfGoods = new KeyValuePair<string, string>("CURRENCY_TYPE", "840");
        private int DefaultTrNumber = 1;
        private bool _isFileSelected = false;

        public Form1()
        {
            this._defaultValueDictionary = new Dictionary<string, string>();
            this._defaultValueDictionary.Add(_defaultTrafficFr.Key, _defaultTrafficFr.Key);
            this._defaultValueDictionary.Add(_defaultTrafficTo.Key, _defaultTrafficTo.Key);
            this._defaultValueDictionary.Add(_defaultCurrencyType.Key, _defaultCurrencyType.Key);
            this._defaultValueDictionary.Add(_defaultDirection.Key, _defaultDirection.Key);
            this._defaultValueDictionary.Add(_defaultQuantityOfGoods.Key, _defaultQuantityOfGoods.Key);


            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void fileChooseBtn_Click(object sender, EventArgs e)
        {
            using (this.fileDialog)
            {
                this.fileDialog.Filter = @"Excel Files|*.xls;*.xlsx;*.xlsm";
                if (this.fileDialog.ShowDialog() != DialogResult.OK)
                    return;
                string fileName = this.fileDialog.FileName;
                this.fileChooseLbl.Text = Path.GetFileNameWithoutExtension(fileName) + Path.GetExtension(fileName);
                this._isFileSelected = true;
            }
        }


        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (this._isFileSelected)
            {
                try
                {
                    string fileName = this.fileDialog.FileName;

                    string withoutExtension = Path.GetFileNameWithoutExtension(fileName);
                    string directoryName = Path.GetDirectoryName(fileName);

                    var excelAsList = this.ExcelToList(fileName);

                    DateTime now = DateTime.Now;
                    string uniqueString = string.Format("{0}_{1}_{2}_{3}_{4}", (object)now.Day, (object)now.Month,
                        (object)now.Year, (object)now.Hour, (object)now.Minute);
                    XDocument xml = this.ListToXml(excelAsList);
                    string uniqueFileName = withoutExtension + "_" + uniqueString + ".xml";
                    var path = Path.Combine(directoryName ?? string.Empty, uniqueFileName);
                    xml.Save(path);
                    int num = (int)MessageBox.Show("File Saved As " + uniqueFileName, "Success");
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException || ex is PathTooLongException)
                    {
                        MessageBox.Show("Choose File");
                    }
                    else
                    {
                        MessageBox.Show("Error", ex.InnerException?.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose File");
            }
        }


        private List<List<string>> ExcelToList(string path)
        {
            var package = new ExcelPackage(new FileInfo(path));
            var workBook = package.Workbook;
            var worksheet = workBook.Worksheets[0];
            List<List<string>> stringListList = new List<List<string>>();

            var rowIndex = FindTableRowIndex(worksheet);
            for (int row = rowIndex; row <= worksheet.Dimension.End.Row; ++row)
            {
                var isEmptyRow = IsEmptyRow(worksheet, row, 5);
                if (!isEmptyRow)
                {
                    List<string> stringList = new List<string>();
                    for (int col = 1; col < worksheet.Dimension.End.Column; ++col)
                    {
                        string str = "";
                        if (worksheet.Cells[row, col].Value != null)
                            str = worksheet.Cells[row, col].Value.ToString();
                        stringList.Add(str);
                    }

                    stringListList.Add(stringList);
                }

            }

            return stringListList;
        }

        private int FindTableRowIndex(ExcelWorksheet worksheet)
        {
            int nullColumnTolerance = 3;
            for (int row = 1; row <= worksheet.Dimension.End.Row; row++)
            {
                var isEmptyRow = IsEmptyRow(worksheet, row, nullColumnTolerance);
                if (!isEmptyRow)
                {
                    return row;
                }
            }

            return 1;
        }

        private bool IsEmptyRow(ExcelWorksheet worksheet, int row = 1, int nullColumnTolerance = 3)
        {
            int nullValueCounter = 0;

            //from 0 to 6
            int nullColumnArrange = nullColumnTolerance + 3;

            for (int col = 1; col < worksheet.Dimension.End.Column; ++col)
            {
                var cell = worksheet.Cells[row, col];
                if (cell.Value == null)
                    nullValueCounter++;

                if (col >= nullColumnArrange)
                {
                    if (nullValueCounter >= nullColumnTolerance)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


            }
            return false;
        }


        private XDocument ListToXml(List<List<string>> values)
        {
            XDeclaration declaration = new XDeclaration("1.0", "utf-8", "yes");
            XElement mainElement = new XElement((XName)"GoodsInfo");

            string trafficFr, trafficTo, currencyType, quantityOfGoods, direction;
            int trNumber;
            trafficFr = !string.IsNullOrWhiteSpace(this.trafficFrInput.Text)
               ? this.trafficFrInput.Text
               : this._defaultTrafficFr.Value;

            trafficTo = !string.IsNullOrWhiteSpace(this.trafficToInput.Text)
               ? this.trafficToInput.Text
               : this._defaultTrafficTo.Value;

            currencyType = !string.IsNullOrWhiteSpace(this.currencyTypeInput.Text)
               ? this.currencyTypeInput.Text
               : this._defaultCurrencyType.Value;

            quantityOfGoods = !string.IsNullOrWhiteSpace(this.quantityOfGoodsInput.Text)
               ? this.quantityOfGoodsInput.Text
               : this._defaultQuantityOfGoods.Value;

            direction = !string.IsNullOrWhiteSpace(this.directionInput.Text)
               ? this.directionInput.Text
               : this._defaultDirection.Value;

            trNumber = !string.IsNullOrWhiteSpace(this.trNumberInput.Text)
               ? Convert.ToInt32(this.trNumberInput.Text)
               : this.DefaultTrNumber;




            List<string> headers = values[0];
            foreach (string key in _defaultValueDictionary.Select(c => c.Key))
            {
                var isdefaultHeaderExistInExcel = headers.Contains(key, StringComparer.OrdinalIgnoreCase);
                //if header is exist in list , then change value for all rows
                if (isdefaultHeaderExistInExcel)
                {
                    var indexOfHeader = headers.IndexOf(key);
                    foreach (var val in values)
                    {
                        val[indexOfHeader] = key;
                    }

                }
                //if not exist in list , then add 
                else
                {
                    headers.Add(key);
                    foreach (var clmn in values)
                    {
                        clmn.Add(key);
                    }

                }
            }



            //index 0 is headers
            for (int i = 1; i < values.Count; ++i)
            {
                XElement xelement2 = new XElement((XName)"GOODS");
                xelement2.Add((object)new XElement((XName)"TR_NUMBER", (object)trNumber++.ToString()));

                //value
                for (int j = 0; j < values[i].Count; ++j)
                {
                    string header = headers[j];
                    string value = values[i][j];
                    if (!string.IsNullOrEmpty(header))
                        xelement2.Add((object)new XElement((XName)header, (object)value));
                }


                mainElement.Add((object)xelement2);
            }

            return new XDocument(declaration, new object[1]
            {
                (object) mainElement
            });
        }
    }
}
