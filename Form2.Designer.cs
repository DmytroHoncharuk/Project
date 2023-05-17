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
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(37, 30);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 62);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Авторизація";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("TT Firs Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(233, 42);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(239, 32);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Статус авторизації";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // textBoxStatusLogin
            // 
            this.textBoxStatusLogin.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxStatusLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatusLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxStatusLogin.Location = new System.Drawing.Point(499, 42);
            this.textBoxStatusLogin.Name = "textBoxStatusLogin";
            this.textBoxStatusLogin.Size = new System.Drawing.Size(212, 36);
            this.textBoxStatusLogin.TabIndex = 2;
            this.textBoxStatusLogin.Text = "Не авторизовано";
            // 
            // LblNumberTest
            // 
            this.LblNumberTest.AutoSize = true;
            this.LblNumberTest.Font = new System.Drawing.Font("TT Firs Neue", 10F);
            this.LblNumberTest.Location = new System.Drawing.Point(33, 118);
            this.LblNumberTest.Name = "LblNumberTest";
            this.LblNumberTest.Size = new System.Drawing.Size(133, 22);
            this.LblNumberTest.TabIndex = 19;
            this.LblNumberTest.Text = "Кількість тестів";
            // 
            // btnMakeTextBox
            // 
            this.btnMakeTextBox.Enabled = false;
            this.btnMakeTextBox.Location = new System.Drawing.Point(324, 113);
            this.btnMakeTextBox.Name = "btnMakeTextBox";
            this.btnMakeTextBox.Size = new System.Drawing.Size(151, 31);
            this.btnMakeTextBox.TabIndex = 18;
            this.btnMakeTextBox.Text = "Створити тест";
            this.btnMakeTextBox.UseVisualStyleBackColor = true;
            this.btnMakeTextBox.Click += new System.EventHandler(this.btnMakeTextBox_Click);
            // 
            // txtNumOfTextBox
            // 
            this.txtNumOfTextBox.BackColor = System.Drawing.Color.White;
            this.txtNumOfTextBox.Location = new System.Drawing.Point(167, 117);
            this.txtNumOfTextBox.Name = "txtNumOfTextBox";
            this.txtNumOfTextBox.Size = new System.Drawing.Size(151, 22);
            this.txtNumOfTextBox.TabIndex = 17;
            // 
            // btnVerifySheets
            // 
            this.btnVerifySheets.Enabled = false;
            this.btnVerifySheets.Location = new System.Drawing.Point(499, 114);
            this.btnVerifySheets.Name = "btnVerifySheets";
            this.btnVerifySheets.Size = new System.Drawing.Size(151, 31);
            this.btnVerifySheets.TabIndex = 20;
            this.btnVerifySheets.Text = "Перевірити таблиці";
            this.btnVerifySheets.UseVisualStyleBackColor = true;
            this.btnVerifySheets.Click += new System.EventHandler(this.btnVerifySheets_Click);
            // 
            // Get
            // 
            this.Get.Enabled = false;
            this.Get.Location = new System.Drawing.Point(716, 197);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(151, 22);
            this.Get.TabIndex = 23;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // txtCellGetValue
            // 
            this.txtCellGetValue.Location = new System.Drawing.Point(873, 197);
            this.txtCellGetValue.Name = "txtCellGetValue";
            this.txtCellGetValue.Size = new System.Drawing.Size(151, 22);
            this.txtCellGetValue.TabIndex = 22;
            // 
            // txtCellNameGet
            // 
            this.txtCellNameGet.Location = new System.Drawing.Point(560, 197);
            this.txtCellNameGet.Name = "txtCellNameGet";
            this.txtCellNameGet.Size = new System.Drawing.Size(151, 22);
            this.txtCellNameGet.TabIndex = 21;
            // 
            // textBoxSheetNumber
            // 
            this.textBoxSheetNumber.Location = new System.Drawing.Point(560, 169);
            this.textBoxSheetNumber.Name = "textBoxSheetNumber";
            this.textBoxSheetNumber.Size = new System.Drawing.Size(151, 22);
            this.textBoxSheetNumber.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ввести номер табл в списку таблиць";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 450);
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
    }
}