namespace TestForm2
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
            this.btnOfNewFileCreation = new System.Windows.Forms.Button();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(22, 19);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(118, 39);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // txtCellNameSet
            // 
            this.txtCellNameSet.Location = new System.Drawing.Point(26, 68);
            this.txtCellNameSet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellNameSet.Name = "txtCellNameSet";
            this.txtCellNameSet.Size = new System.Drawing.Size(114, 20);
            this.txtCellNameSet.TabIndex = 1;
            this.txtCellNameSet.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCellValue
            // 
            this.txtCellValue.Location = new System.Drawing.Point(144, 68);
            this.txtCellValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellValue.Name = "txtCellValue";
            this.txtCellValue.Size = new System.Drawing.Size(114, 20);
            this.txtCellValue.TabIndex = 2;
            // 
            // txtCellNameGet
            // 
            this.txtCellNameGet.Location = new System.Drawing.Point(27, 91);
            this.txtCellNameGet.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellNameGet.Name = "txtCellNameGet";
            this.txtCellNameGet.Size = new System.Drawing.Size(114, 20);
            this.txtCellNameGet.TabIndex = 3;
            // 
            // txtCellGetValue
            // 
            this.txtCellGetValue.Location = new System.Drawing.Point(262, 91);
            this.txtCellGetValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtCellGetValue.Name = "txtCellGetValue";
            this.txtCellGetValue.Size = new System.Drawing.Size(114, 20);
            this.txtCellGetValue.TabIndex = 4;
            // 
            // Get
            // 
            this.Get.Enabled = false;
            this.Get.Location = new System.Drawing.Point(144, 91);
            this.Get.Margin = new System.Windows.Forms.Padding(2);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(113, 18);
            this.Get.TabIndex = 5;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // Set
            // 
            this.Set.Enabled = false;
            this.Set.Location = new System.Drawing.Point(262, 68);
            this.Set.Margin = new System.Windows.Forms.Padding(2);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(113, 18);
            this.Set.TabIndex = 6;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // BtnGetGroup
            // 
            this.BtnGetGroup.Enabled = false;
            this.BtnGetGroup.Location = new System.Drawing.Point(144, 162);
            this.BtnGetGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGetGroup.Name = "BtnGetGroup";
            this.BtnGetGroup.Size = new System.Drawing.Size(113, 18);
            this.BtnGetGroup.TabIndex = 7;
            this.BtnGetGroup.Text = "GetStudents ";
            this.BtnGetGroup.UseVisualStyleBackColor = true;
            this.BtnGetGroup.Click += new System.EventHandler(this.BtnGetGroup_Click);
            // 
            // txtGetGroup
            // 
            this.txtGetGroup.Location = new System.Drawing.Point(27, 162);
            this.txtGetGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGetGroup.Name = "txtGetGroup";
            this.txtGetGroup.Size = new System.Drawing.Size(114, 20);
            this.txtGetGroup.TabIndex = 8;
            // 
            // txtStudents
            // 
            this.txtStudents.Location = new System.Drawing.Point(262, 162);
            this.txtStudents.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudents.Multiline = true;
            this.txtStudents.Name = "txtStudents";
            this.txtStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStudents.Size = new System.Drawing.Size(209, 197);
            this.txtStudents.TabIndex = 9;
            this.txtStudents.TextChanged += new System.EventHandler(this.txtStudents_TextChanged);
            // 
            // txtNameSheets
            // 
            this.txtNameSheets.Location = new System.Drawing.Point(145, 19);
            this.txtNameSheets.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameSheets.Name = "txtNameSheets";
            this.txtNameSheets.Size = new System.Drawing.Size(387, 20);
            this.txtNameSheets.TabIndex = 10;
            this.txtNameSheets.TextChanged += new System.EventHandler(this.txtNameSheets_TextChanged);
            // 
            // txtNumOfTextBox
            // 
            this.txtNumOfTextBox.Location = new System.Drawing.Point(26, 402);
            this.txtNumOfTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumOfTextBox.Name = "txtNumOfTextBox";
            this.txtNumOfTextBox.Size = new System.Drawing.Size(114, 20);
            this.txtNumOfTextBox.TabIndex = 11;
            // 
            // btnMakeTextBox
            // 
            this.btnMakeTextBox.Enabled = false;
            this.btnMakeTextBox.Location = new System.Drawing.Point(145, 402);
            this.btnMakeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeTextBox.Name = "btnMakeTextBox";
            this.btnMakeTextBox.Size = new System.Drawing.Size(113, 18);
            this.btnMakeTextBox.TabIndex = 12;
            this.btnMakeTextBox.Text = "Make TextBox";
            this.btnMakeTextBox.UseVisualStyleBackColor = true;
            this.btnMakeTextBox.Click += new System.EventHandler(this.btnMakeTextBox_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(514, 410);
            this.txtData.Margin = new System.Windows.Forms.Padding(2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(114, 20);
            this.txtData.TabIndex = 13;
            // 
            // btnGetData
            // 
            this.btnGetData.Enabled = false;
            this.btnGetData.Location = new System.Drawing.Point(397, 410);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(113, 18);
            this.btnGetData.TabIndex = 14;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnOfNewFileCreation
            // 
            this.btnOfNewFileCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfNewFileCreation.Location = new System.Drawing.Point(747, 126);
            this.btnOfNewFileCreation.Name = "btnOfNewFileCreation";
            this.btnOfNewFileCreation.Size = new System.Drawing.Size(180, 30);
            this.btnOfNewFileCreation.TabIndex = 16;
            this.btnOfNewFileCreation.TabStop = false;
            this.btnOfNewFileCreation.Text = "Створити новий файл на диску";
            this.btnOfNewFileCreation.UseVisualStyleBackColor = true;
            this.btnOfNewFileCreation.Click += new System.EventHandler(this.btnOfNewFileCreation_Click);
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(747, 100);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(180, 20);
            this.fileNameTxt.TabIndex = 17;
            this.fileNameTxt.TextChanged += new System.EventHandler(this.fileNameTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1157, 482);
            this.Controls.Add(this.fileNameTxt);
            this.Controls.Add(this.btnOfNewFileCreation);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnOfNewFileCreation;
        private System.Windows.Forms.TextBox fileNameTxt;
    }
}

