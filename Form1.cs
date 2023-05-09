﻿using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm2
{
    public partial class Form1 : Form
    {
        private GoogleHelper helper;
        private Maker Maker;
        public List<TextBox> textBoxes = new List<TextBox>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {



            this.helper = new GoogleHelper(Properties.Settings.Default.GoogleToken, txtNameSheets.Text /*Properties.Settings.Default.SheetFileNeme*/);

            bool succsess = this.helper.Start().Result;
            Maker = new Maker(this);

            Get.Enabled = Set.Enabled = BtnGetGroup.Enabled = btnMakeTextBox.Enabled = succsess;


        }

        private void Set_Click(object sender, EventArgs e)
        {
            this.helper.Set(cellName: txtCellNameSet.Text, value: txtCellValue.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Get_Click(object sender, EventArgs e)
        {
            var result = this.helper.Get(cellName: txtCellNameGet.Text);
            txtCellGetValue.Text = result;
        }

        private void BtnGetGroup_Click(object sender, EventArgs e)
        {
            var result = this.helper.GetStudent();
            this.helper.DisplayStudentFromGroup(group: txtGetGroup.Text, textBox: ref txtStudents, listOfStudent: result);
        }

        private void btnMakeTextBox_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumOfTextBox.Text);
            Maker.TexBoxMake(number);
            Maker.LableMake(number);
            btnGetData.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (textBoxes.Count > 0)
            {

                txtData.Text = textBoxes[0].Text;
            }
        }

        private void txtNameSheets_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnOfNewFileCreation_Click(object sender, EventArgs e) // створення нової таблиці, робочий варіант
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = fileNameTxt.Text, // задає ім'я створеного файлу, можна реалізувати те, що користувач буде вводити ім'я в textbox сам
                MimeType = "application/vnd.google-apps.spreadsheet"
            };
            var request = helper.driveService.Files.Create(fileMetadata);
            request.Fields = "id";
            var file = request.Execute();
            var fileid = file.Id;


            var data = helper.GetMarksAndNickOfEachStudent();


             var updateRange = "A:Z";
            var newrequest = helper.sheetService.Spreadsheets.Values.Update(
               new ValueRange { Values = new List<IList<object>>(data) },
               spreadsheetId: fileid, range: updateRange
               );
            newrequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            var response = newrequest.Execute();
            //var updateRange = "A:A";
            //var updateRequest = new ValueRange { Values = data };
            //var updateResponse = helper.sheetService.Spreadsheets.Values.Update(updateRequest, fileid, updateRange);
            //var result = updateResponse.Execute();
        }

        private void txtStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
