using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Windows.ApplicationModel.Calls;
using System.Threading;

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
                //Name = fileNameTxt.Text, // задає ім'я створеного файлу, можна реалізувати те, що користувач буде вводити ім'я в textbox сам
                Name = "Новий файл",
                MimeType = "application/vnd.google-apps.spreadsheet"
            };
            var request = helper.driveService.Files.Create(fileMetadata);
            request.Fields = "id";
            var file = request.Execute();
            var fileid = file.Id;

            Tools.SheetCreation(helper, fileid, "Номер 2");


            //////////////////////
            var values = helper.GetMarksAndNickOfEachStudent();
            var range1 = "A";
            var sheetreq = helper.sheetService.Spreadsheets.Get(fileid);
            var respSheetreq = sheetreq.Execute();
            //
            int j;
            int i = 0;
            char beginningRange = 'A';
            foreach (List<string> item in values) // вставляє нік телеги на другий листок, ПІБ на перший
            {
                Thread.Sleep(700);
                j = 1;
                foreach (var smth in item)
                {
                    Thread.Sleep(700); // задля зменшення кількості запитів
                    string cell = beginningRange.ToString() + j.ToString(); // клітинка, у яку будуть вставлятися дані
                    helper.Set2(cellName: cell, value: smth, respSheetreq.Sheets[i].Properties.Title, fileid); // вставлення даних
                    j++;
                }
                beginningRange++;
                i++;
            }
        }

        private void txtStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
