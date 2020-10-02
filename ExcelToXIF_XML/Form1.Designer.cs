namespace ExcelToXIF_XML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.convertBtn = new System.Windows.Forms.Button();
            this.trafficFrInput = new System.Windows.Forms.TextBox();
            this.fileChooseBtn = new System.Windows.Forms.Button();
            this.fileChooseLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityOfGoodsInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.directionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trNumberInput = new System.Windows.Forms.TextBox();
            this.currencyTypeLbl = new System.Windows.Forms.Label();
            this.currencyTypeInput = new System.Windows.Forms.TextBox();
            this.trafficToLbl = new System.Windows.Forms.Label();
            this.trafficToInput = new System.Windows.Forms.TextBox();
            this.trafficFrLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.convertBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.convertBtn.FlatAppearance.BorderSize = 2;
            this.convertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.convertBtn.Location = new System.Drawing.Point(8, 438);
            this.convertBtn.Margin = new System.Windows.Forms.Padding(4);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(457, 54);
            this.convertBtn.TabIndex = 0;
            this.convertBtn.Text = "Convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // trafficFrInput
            // 
            this.trafficFrInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trafficFrInput.Location = new System.Drawing.Point(185, 47);
            this.trafficFrInput.Margin = new System.Windows.Forms.Padding(4);
            this.trafficFrInput.Name = "trafficFrInput";
            this.trafficFrInput.Size = new System.Drawing.Size(237, 22);
            this.trafficFrInput.TabIndex = 1;
            this.trafficFrInput.Text = "840";
            // 
            // fileChooseBtn
            // 
            this.fileChooseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileChooseBtn.Location = new System.Drawing.Point(16, 365);
            this.fileChooseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fileChooseBtn.Name = "fileChooseBtn";
            this.fileChooseBtn.Size = new System.Drawing.Size(229, 48);
            this.fileChooseBtn.TabIndex = 2;
            this.fileChooseBtn.Text = "Choose File";
            this.fileChooseBtn.UseVisualStyleBackColor = true;
            this.fileChooseBtn.Click += new System.EventHandler(this.fileChooseBtn_Click);
            // 
            // fileChooseLbl
            // 
            this.fileChooseLbl.AutoSize = true;
            this.fileChooseLbl.Location = new System.Drawing.Point(253, 381);
            this.fileChooseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileChooseLbl.Name = "fileChooseLbl";
            this.fileChooseLbl.Size = new System.Drawing.Size(15, 20);
            this.fileChooseLbl.TabIndex = 3;
            this.fileChooseLbl.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.quantityOfGoodsInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.directionInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trNumberInput);
            this.groupBox1.Controls.Add(this.currencyTypeLbl);
            this.groupBox1.Controls.Add(this.currencyTypeInput);
            this.groupBox1.Controls.Add(this.trafficToLbl);
            this.groupBox1.Controls.Add(this.trafficToInput);
            this.groupBox1.Controls.Add(this.trafficFrLbl);
            this.groupBox1.Controls.Add(this.trafficFrInput);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(445, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "QUANTITY_OF_GOODS";
            // 
            // quantityOfGoodsInput
            // 
            this.quantityOfGoodsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityOfGoodsInput.Location = new System.Drawing.Point(185, 216);
            this.quantityOfGoodsInput.Margin = new System.Windows.Forms.Padding(4);
            this.quantityOfGoodsInput.Name = "quantityOfGoodsInput";
            this.quantityOfGoodsInput.Size = new System.Drawing.Size(237, 22);
            this.quantityOfGoodsInput.TabIndex = 15;
            this.quantityOfGoodsInput.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "DIRECTION";
            // 
            // directionInput
            // 
            this.directionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.directionInput.Location = new System.Drawing.Point(185, 172);
            this.directionInput.Margin = new System.Windows.Forms.Padding(4);
            this.directionInput.Name = "directionInput";
            this.directionInput.Size = new System.Drawing.Size(237, 22);
            this.directionInput.TabIndex = 13;
            this.directionInput.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "TR_NUMBER";
            // 
            // trNumberInput
            // 
            this.trNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trNumberInput.Location = new System.Drawing.Point(185, 262);
            this.trNumberInput.Margin = new System.Windows.Forms.Padding(4);
            this.trNumberInput.Name = "trNumberInput";
            this.trNumberInput.Size = new System.Drawing.Size(237, 22);
            this.trNumberInput.TabIndex = 11;
            this.trNumberInput.Text = "1";
            // 
            // currencyTypeLbl
            // 
            this.currencyTypeLbl.AutoSize = true;
            this.currencyTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeLbl.Location = new System.Drawing.Point(47, 139);
            this.currencyTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currencyTypeLbl.Name = "currencyTypeLbl";
            this.currencyTypeLbl.Size = new System.Drawing.Size(124, 17);
            this.currencyTypeLbl.TabIndex = 8;
            this.currencyTypeLbl.Text = "CURRENCY TYPE";
            // 
            // currencyTypeInput
            // 
            this.currencyTypeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currencyTypeInput.Location = new System.Drawing.Point(185, 134);
            this.currencyTypeInput.Margin = new System.Windows.Forms.Padding(4);
            this.currencyTypeInput.Name = "currencyTypeInput";
            this.currencyTypeInput.Size = new System.Drawing.Size(237, 22);
            this.currencyTypeInput.TabIndex = 7;
            this.currencyTypeInput.Text = "840";
            // 
            // trafficToLbl
            // 
            this.trafficToLbl.AutoSize = true;
            this.trafficToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trafficToLbl.Location = new System.Drawing.Point(23, 96);
            this.trafficToLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trafficToLbl.Name = "trafficToLbl";
            this.trafficToLbl.Size = new System.Drawing.Size(152, 17);
            this.trafficToLbl.TabIndex = 6;
            this.trafficToLbl.Text = "GOODS_TRAFFIC_TO";
            // 
            // trafficToInput
            // 
            this.trafficToInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trafficToInput.Location = new System.Drawing.Point(185, 92);
            this.trafficToInput.Margin = new System.Windows.Forms.Padding(4);
            this.trafficToInput.Name = "trafficToInput";
            this.trafficToInput.Size = new System.Drawing.Size(237, 22);
            this.trafficToInput.TabIndex = 5;
            this.trafficToInput.Text = "031";
            // 
            // trafficFrLbl
            // 
            this.trafficFrLbl.AutoSize = true;
            this.trafficFrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trafficFrLbl.Location = new System.Drawing.Point(23, 51);
            this.trafficFrLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trafficFrLbl.Name = "trafficFrLbl";
            this.trafficFrLbl.Size = new System.Drawing.Size(150, 17);
            this.trafficFrLbl.TabIndex = 4;
            this.trafficFrLbl.Text = "GOODS_TRAFFIC_FR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileChooseLbl);
            this.Controls.Add(this.fileChooseBtn);
            this.Controls.Add(this.convertBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //this.fileDialog = new OpenFileDialog();
        //    this.convertBtn = new Button();
        //    this.trafficFrInput = new TextBox();
        //    this.fileChooseBtn = new Button();
        //    this.fileChooseLbl = new Label();
        //    this.groupBox1 = new GroupBox();
        //    this.label3 = new Label();
        //    this.quantityOfGoodsInput = new TextBox();
        //    this.label2 = new Label();
        //    this.directionInput = new TextBox();
        //    this.label1 = new Label();
        //    this.trNumberInput = new TextBox();
        //    this.currencyTypeLbl = new Label();
        //    this.currencyTypeInput = new TextBox();
        //    this.trafficToLbl = new Label();
        //    this.trafficToInput = new TextBox();
        //    this.trafficFrLbl = new Label();
        //    this.groupBox1.SuspendLayout();
        //this.SuspendLayout();
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.TextBox trafficFrInput;
        private System.Windows.Forms.Button fileChooseBtn;
        private System.Windows.Forms.Label fileChooseLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityOfGoodsInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directionInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trNumberInput;
        private System.Windows.Forms.Label currencyTypeLbl;
        private System.Windows.Forms.TextBox currencyTypeInput;
        private System.Windows.Forms.Label trafficToLbl;
        private System.Windows.Forms.TextBox trafficToInput;
        private System.Windows.Forms.Label trafficFrLbl;
    }
}
