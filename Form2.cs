﻿using Google.Apis.Util;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm2
{
    public partial class Form2 : Form
    {
        private GoogleLogin helper;
        private Maker Maker;
        public List<TextBox> textBoxes = new List<TextBox>();
        public List<CheckBox> checkBoxes = new List<CheckBox>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.helper = new GoogleHelper(Properties.Settings.Default.GoogleToken, txtNameSheets.Text /*Properties.Settings.Default.SheetFileNeme*/);



            this.helper = new GoogleLogin(this); 

            bool succsess = this.helper.Login().Result;
            Maker = new Maker(textBoxes, checkBoxes, this);
            btnMakeTextBox.Enabled = succsess;

            Get.Enabled = succsess;



            if (succsess)
            {
                textBoxStatusLogin.Text = "Авторизовано";
                textBoxStatusLogin.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxStatusLogin.Text = "Не авторизовано";
                textBoxStatusLogin.BackColor = Color.LightCoral;
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public static void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // заблокувати подію CheckedChanged
            CheckBox checkBox = (CheckBox)sender;
            checkBox.CheckedChanged -= CheckBox_CheckedChanged;

            
        }

        private void btnMakeTextBox_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumOfTextBox.Text);
            if (number <= 20)
            {
                Maker.MakeInputBox(number, LblNumberTest.Location.X, LblNumberTest.Location.Y);
                foreach (TextBox textBox in textBoxes)
                {
                    Controls.Add(textBox);
                }
                foreach (CheckBox checkBox in checkBoxes)
                {
                    Controls.Add(checkBox);

                }
                btnVerifySheets.Enabled = true;
            }
            else
            {
                txtNumOfTextBox.BackColor = Color.LightCoral;
                var notify = new ToastContentBuilder();
                notify.AddText("Кількість тестів не може перевищувати 20");
                notify.Show();
            }
        }

        private void btnVerifySheets_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (textBoxes[i].Text !="")
                {
                    helper.Services.GetSheet(textBoxes[i].Text, i);
                }
            }
            //foreach (var item in textBoxes)
            //{
            //    if (string.IsNullOrWhiteSpace(item.Text))
            //    {
            //        helper.Services.GetSheet(item.Text);
            //    }
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void Get_Click(object sender, EventArgs e)
        {
            int number_sheet = int.Parse(textBoxSheetNumber.Text); 

            var result = helper.services.Get(cellName: txtCellNameGet.Text, helper.Services.Sheets[number_sheet]);
            txtCellGetValue.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOfNewFileCreation_Click(object sender, EventArgs e)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "New file2", // задає ім'я створеного файлу, можна реалізувати те, що користувач буде вводити ім'я в textbox сам
                MimeType = "application/vnd.google-apps.spreadsheet",
            };

            var fileid = helper.Services.driveService.Files.Create(fileMetadata).Execute().Id;
            Tools.SheetCreation(helper.Services, fileid, "Неліквідні випадки");
            var ab = helper.services.GetGroup(sheetName: helper.services.SheetService.Spreadsheets.Get(helper.services.Sheets[0].FileID).Execute().Sheets[0].Properties.Title, sheetFileId: helper.services.Sheets[0].FileID);
            foreach (string item in ab)
                Tools.SheetCreation(helper.Services, fileid, item);


            //////////////////////
            // var ae = helper.services.SheetService.Spreadsheets.Get(helper.services.Sheets[0].FileID); // або.Title так можна отримати ім'я та id усієї таблиці
            // var aq = helper.services.SheetService.Spreadsheets.Get(helper.services.Sheets[0].FileID).Execute().Sheets[1].Properties.Title; // отримали ім'я певного листа
            // var values = helper.services.GetStudentDataFromTestResults(sheetName: helper.services.SheetService.Spreadsheets.Get(helper.services.Sheets[0].FileID).Execute().Sheets[0].Properties.Title, sheetFileId: helper.services.Sheets[0].FileID);
            // var values2 = helper.services.GetStudentDataFromTestResults(sheetName: "А1", sheetFileId: helper.services.Sheets[0].FileID);


            /// sheetName: Get(helper.services.Sheets[0].FileID ось тут Sheets - це поле, яке ми самі створили
            /// Execute().Sheets[0].Properties.Title Sheets - це поле класу Spreadsheets, тобто поле Google API 

            /// створення нових листків відповідно до груп



            var sheetreq = helper.services.SheetService.Spreadsheets.Get(fileid);
            var respSheetreq = sheetreq.Execute();
            //
            /*
            int j;
            int i = 0;
            char beginningRange = 'A';
            foreach (List<string> item in values2) // вставляє нік телеги на другий листок, ПІБ на перший
            {
                Thread.Sleep(700);
                j = 1;
                foreach (var smth in item)
                {
                    Thread.Sleep(700); // задля зменшення кількості запитів
                    string cell = beginningRange.ToString() + j.ToString(); // клітинка, у яку будуть вставлятися дані
                    helper.Services.SetCell(cellName: cell, value: smth, helper.services.SheetService.Spreadsheets.Get(fileid).Execute().Sheets[i].Properties.Title, fileid); // вставлення даних
                    j++;
                }
                beginningRange++;
                i++;
            }
           */
        }

    }
}
