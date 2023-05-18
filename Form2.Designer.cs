namespace TestForm2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textBoxStatusLogin = new System.Windows.Forms.TextBox();
            this.LblNumberTest = new System.Windows.Forms.Label();
            this.btnMakeTextBox = new System.Windows.Forms.Button();
            this.txtNumOfTextBox = new System.Windows.Forms.TextBox();
            this.btnVerifySheets = new System.Windows.Forms.Button();
            this.Get = new System.Windows.Forms.Button();
            this.txtCellGetValue = new System.Windows.Forms.TextBox();
            this.txtCellNameGet = new System.Windows.Forms.TextBox();
            this.textBoxSheetNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.btnOfNewFileCreation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(28, 24);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 50);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Авторизація";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(175, 34);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(191, 25);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус авторизації";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // textBoxStatusLogin
            // 
            this.textBoxStatusLogin.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxStatusLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatusLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxStatusLogin.Location = new System.Drawing.Point(374, 34);
            this.textBoxStatusLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStatusLogin.Name = "textBoxStatusLogin";
            this.textBoxStatusLogin.Size = new System.Drawing.Size(160, 30);
            this.textBoxStatusLogin.TabIndex = 2;
            this.textBoxStatusLogin.Text = "Не авторизовано";
            // 
            // LblNumberTest
            // 
            this.LblNumberTest.AutoSize = true;
            this.LblNumberTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblNumberTest.Location = new System.Drawing.Point(25, 96);
            this.LblNumberTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumberTest.Name = "LblNumberTest";
            this.LblNumberTest.Size = new System.Drawing.Size(109, 17);
            this.LblNumberTest.TabIndex = 19;
            this.LblNumberTest.Text = "Кількість тестів";
            // 
            // btnMakeTextBox
            // 
            this.btnMakeTextBox.Enabled = false;
            this.btnMakeTextBox.Location = new System.Drawing.Point(243, 92);
            this.btnMakeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeTextBox.Name = "btnMakeTextBox";
            this.btnMakeTextBox.Size = new System.Drawing.Size(113, 25);
            this.btnMakeTextBox.TabIndex = 18;
            this.btnMakeTextBox.Text = "Створити тест";
            this.btnMakeTextBox.UseVisualStyleBackColor = true;
            this.btnMakeTextBox.Click += new System.EventHandler(this.btnMakeTextBox_Click);
            // 
            // txtNumOfTextBox
            // 
            this.txtNumOfTextBox.BackColor = System.Drawing.Color.White;
            this.txtNumOfTextBox.Location = new System.Drawing.Point(125, 95);
            this.txtNumOfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumOfTextBox.Name = "txtNumOfTextBox";
            this.txtNumOfTextBox.Size = new System.Drawing.Size(114, 20);
            this.txtNumOfTextBox.TabIndex = 17;
            // 
            // btnVerifySheets
            // 
            this.btnVerifySheets.Enabled = false;
            this.btnVerifySheets.Location = new System.Drawing.Point(374, 93);
            this.btnVerifySheets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerifySheets.Name = "btnVerifySheets";
            this.btnVerifySheets.Size = new System.Drawing.Size(113, 25);
            this.btnVerifySheets.TabIndex = 20;
            this.btnVerifySheets.Text = "Перевірити таблиці";
            this.btnVerifySheets.UseVisualStyleBackColor = true;
            this.btnVerifySheets.Click += new System.EventHandler(this.btnVerifySheets_Click);
            // 
            // Get
            // 
            this.Get.Enabled = false;
            this.Get.Location = new System.Drawing.Point(537, 160);
            this.Get.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(113, 18);
            this.Get.TabIndex = 23;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // txtCellGetValue
            // 
            this.txtCellGetValue.Location = new System.Drawing.Point(655, 160);
            this.txtCellGetValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCellGetValue.Name = "txtCellGetValue";
            this.txtCellGetValue.Size = new System.Drawing.Size(114, 20);
            this.txtCellGetValue.TabIndex = 22;
            // 
            // txtCellNameGet
            // 
            this.txtCellNameGet.Location = new System.Drawing.Point(420, 160);
            this.txtCellNameGet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCellNameGet.Name = "txtCellNameGet";
            this.txtCellNameGet.Size = new System.Drawing.Size(114, 20);
            this.txtCellNameGet.TabIndex = 21;
            // 
            // textBoxSheetNumber
            // 
            this.textBoxSheetNumber.Location = new System.Drawing.Point(420, 137);
            this.textBoxSheetNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSheetNumber.Name = "textBoxSheetNumber";
            this.textBoxSheetNumber.Size = new System.Drawing.Size(114, 20);
            this.textBoxSheetNumber.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ввести номер табл в списку таблиць";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(970, 158);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(180, 20);
            this.fileNameTxt.TabIndex = 27;
            // 
            // btnOfNewFileCreation
            // 
            this.btnOfNewFileCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfNewFileCreation.Location = new System.Drawing.Point(970, 192);
            this.btnOfNewFileCreation.Name = "btnOfNewFileCreation";
            this.btnOfNewFileCreation.Size = new System.Drawing.Size(180, 64);
            this.btnOfNewFileCreation.TabIndex = 26;
            this.btnOfNewFileCreation.TabStop = false;
            this.btnOfNewFileCreation.Text = "Створити новий файл на диску та виконати необхідні дії";
            this.btnOfNewFileCreation.UseVisualStyleBackColor = true;
            this.btnOfNewFileCreation.Click += new System.EventHandler(this.btnOfNewFileCreation_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 566);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.btnOfNewFileCreation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSheetNumber);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.txtCellGetValue);
            this.Controls.Add(this.txtCellNameGet);
            this.Controls.Add(this.btnVerifySheets);
            this.Controls.Add(this.LblNumberTest);
            this.Controls.Add(this.btnMakeTextBox);
            this.Controls.Add(this.txtNumOfTextBox);
            this.Controls.Add(this.textBoxStatusLogin);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textBoxStatusLogin;
        private System.Windows.Forms.Label LblNumberTest;
        private System.Windows.Forms.Button btnMakeTextBox;
        private System.Windows.Forms.TextBox txtNumOfTextBox;
        private System.Windows.Forms.Button btnVerifySheets;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.TextBox txtCellGetValue;
        private System.Windows.Forms.TextBox txtCellNameGet;
        private System.Windows.Forms.TextBox textBoxSheetNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.Button btnOfNewFileCreation;
    }
}