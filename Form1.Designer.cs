﻿namespace TestForm2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.txtCellNameSet = new System.Windows.Forms.TextBox();
            this.txtCellValue = new System.Windows.Forms.TextBox();
            this.txtCellNameGet = new System.Windows.Forms.TextBox();
            this.txtCellGetValue = new System.Windows.Forms.TextBox();
            this.Get = new System.Windows.Forms.Button();
            this.Set = new System.Windows.Forms.Button();
            this.BtnGetGroup = new System.Windows.Forms.Button();
            this.txtGetGroup = new System.Windows.Forms.TextBox();
            this.txtStudents = new System.Windows.Forms.TextBox();
            this.txtNameSheets = new System.Windows.Forms.TextBox();
            this.txtNumOfTextBox = new System.Windows.Forms.TextBox();
            this.btnMakeTextBox = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumberTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.Location = new System.Drawing.Point(35, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(158, 48);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // txtCellNameSet
            // 
            this.txtCellNameSet.Location = new System.Drawing.Point(35, 84);
            this.txtCellNameSet.Name = "txtCellNameSet";
            this.txtCellNameSet.Size = new System.Drawing.Size(151, 22);
            this.txtCellNameSet.TabIndex = 1;
            this.txtCellNameSet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCellValue
            // 
            this.txtCellValue.Location = new System.Drawing.Point(192, 84);
            this.txtCellValue.Name = "txtCellValue";
            this.txtCellValue.Size = new System.Drawing.Size(151, 22);
            this.txtCellValue.TabIndex = 2;
            // 
            // txtCellNameGet
            // 
            this.txtCellNameGet.Location = new System.Drawing.Point(36, 112);
            this.txtCellNameGet.Name = "txtCellNameGet";
            this.txtCellNameGet.Size = new System.Drawing.Size(151, 22);
            this.txtCellNameGet.TabIndex = 3;
            // 
            // txtCellGetValue
            // 
            this.txtCellGetValue.Location = new System.Drawing.Point(349, 112);
            this.txtCellGetValue.Name = "txtCellGetValue";
            this.txtCellGetValue.Size = new System.Drawing.Size(151, 22);
            this.txtCellGetValue.TabIndex = 4;
            // 
            // Get
            // 
            this.Get.Enabled = false;
            this.Get.Location = new System.Drawing.Point(192, 112);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(151, 22);
            this.Get.TabIndex = 5;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Set
            // 
            this.Set.Enabled = false;
            this.Set.Location = new System.Drawing.Point(349, 84);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(151, 22);
            this.Set.TabIndex = 6;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // BtnGetGroup
            // 
            this.BtnGetGroup.Enabled = false;
            this.BtnGetGroup.Location = new System.Drawing.Point(192, 200);
            this.BtnGetGroup.Name = "BtnGetGroup";
            this.BtnGetGroup.Size = new System.Drawing.Size(151, 22);
            this.BtnGetGroup.TabIndex = 7;
            this.BtnGetGroup.Text = "GetStudents ";
            this.BtnGetGroup.UseVisualStyleBackColor = true;
            this.BtnGetGroup.Click += new System.EventHandler(this.BtnGetGroup_Click);
            // 
            // txtGetGroup
            // 
            this.txtGetGroup.Location = new System.Drawing.Point(36, 200);
            this.txtGetGroup.Name = "txtGetGroup";
            this.txtGetGroup.Size = new System.Drawing.Size(151, 22);
            this.txtGetGroup.TabIndex = 8;
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(349, 200);
            this.txtStudents.Multiline = true;
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStudents.Size = new System.Drawing.Size(277, 241);
            this.txtStudents.TabIndex = 9;
            // 
            // txtNameSheets
            // 
            this.txtNameSheets.Location = new System.Drawing.Point(360, 25);
            this.txtNameSheets.Name = "txtNameSheets";
            this.txtNameSheets.Size = new System.Drawing.Size(515, 22);
            this.txtNameSheets.TabIndex = 10;
            this.txtNameSheets.TextChanged += new System.EventHandler(this.txtNameSheets_TextChanged);
            // 
            // txtNumOfTextBox
            // 
            this.txtNumOfTextBox.BackColor = System.Drawing.Color.White;
            this.txtNumOfTextBox.Location = new System.Drawing.Point(160, 503);
            this.txtNumOfTextBox.Name = "txtNumOfTextBox";
            this.txtNumOfTextBox.Size = new System.Drawing.Size(151, 22);
            this.txtNumOfTextBox.TabIndex = 11;
            this.txtNumOfTextBox.TextChanged += new System.EventHandler(this.txtNumOfTextBox_TextChanged);
            // 
            // btnMakeTextBox
            // 
            this.btnMakeTextBox.Enabled = false;
            this.btnMakeTextBox.Location = new System.Drawing.Point(317, 499);
            this.btnMakeTextBox.Name = "btnMakeTextBox";
            this.btnMakeTextBox.Size = new System.Drawing.Size(151, 31);
            this.btnMakeTextBox.TabIndex = 12;
            this.btnMakeTextBox.Text = "Make TextBox";
            this.btnMakeTextBox.UseVisualStyleBackColor = true;
            this.btnMakeTextBox.Click += new System.EventHandler(this.btnMakeTextBox_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(686, 504);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(151, 22);
            this.txtData.TabIndex = 13;
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(529, 504);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(151, 28);
            this.btnGetData.TabIndex = 14;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TT Firs Neue", 10F);
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Назва таблиці";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblNumberTest
            // 
            this.LblNumberTest.AutoSize = true;
            this.LblNumberTest.Font = new System.Drawing.Font("TT Firs Neue", 10F);
            this.LblNumberTest.Location = new System.Drawing.Point(26, 504);
            this.LblNumberTest.Name = "LblNumberTest";
            this.LblNumberTest.Size = new System.Drawing.Size(133, 22);
            this.LblNumberTest.TabIndex = 16;
            this.LblNumberTest.Text = "Кількість тестів";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.Controls.Add(this.LblNumberTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnMakeTextBox);
            this.Controls.Add(this.txtNumOfTextBox);
            this.Controls.Add(this.txtNameSheets);
            this.Controls.Add(this.txtStudents);
            this.Controls.Add(this.txtGetGroup);
            this.Controls.Add(this.BtnGetGroup);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.txtCellGetValue);
            this.Controls.Add(this.txtCellNameGet);
            this.Controls.Add(this.txtCellValue);
            this.Controls.Add(this.txtCellNameSet);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox txtCellNameSet;
        private System.Windows.Forms.TextBox txtCellValue;
        private System.Windows.Forms.TextBox txtCellNameGet;
        private System.Windows.Forms.TextBox txtCellGetValue;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button BtnGetGroup;
        private System.Windows.Forms.TextBox txtGetGroup;
        private System.Windows.Forms.TextBox txtStudents;
        private System.Windows.Forms.TextBox txtNameSheets;
        private System.Windows.Forms.TextBox txtNumOfTextBox;
        private System.Windows.Forms.Button btnMakeTextBox;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumberTest;
    }
}

