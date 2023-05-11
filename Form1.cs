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

            Tools.SheetCreation(helper, fileid);

            ///////////////////////
            /*
            // Запит на створення нового листка
            var requestNewsheet = new Request
            {
                AddSheet = new AddSheetRequest
                {
                    Properties = new SheetProperties
                    {
                        Title = "New Sheet 2"
                    }
                }
            };

            // Створення батч-запиту
            var batchUpdateRequest = new BatchUpdateSpreadsheetRequest
            {
                Requests = new List<Request> { requestNewsheet }
            };

            // Виклик сервісу для створення листка
            SpreadsheetsResource.BatchUpdateRequest batchUpdate = helper.sheetService.Spreadsheets.BatchUpdate(batchUpdateRequest, fileid);
            BatchUpdateSpreadsheetResponse batchUpdateResponse = batchUpdate.Execute();
            */
            //////////////////////
            var values = helper.GetMarksAndNickOfEachStudent();
            var range1 = "A";

            var value = values[0].ToList();
            List<string> finalValueList = value.ConvertAll(x => x.ToString());
            var sheetreq = helper.sheetService.Spreadsheets.Get(fileid);
            var respSheetreq = sheetreq.Execute();
            var value2 = values[1].ToList();

            List<string> finalValueList2 = value2.ConvertAll(x => x.ToString());

            var sheetname = respSheetreq.Sheets[0].Properties.Title;
            var sheername2 = respSheetreq.Sheets[1].Properties.Title; //виходить за межі
            
            int j = 1;  
            /*
                foreach (string item in finalValueList2) // тестова версія 
                {
                    string temp = range1 + j.ToString();
                    helper.Set2(cellName: temp, value: item, sheername2, fileid);
                    j++;
                }
            */
            //int j = 1;


            int i = 0;
            char beginningRange = 'A';
            foreach (List<string> item in values) // вставляє нік телеги на другий листок, ПІБ на перший
            {
                Thread.Sleep(700);
                j = 1;
                foreach (var smth in item)
                {
                    Thread.Sleep(700); // задля зменшення кількості запитів
                    string temp = beginningRange.ToString() + j.ToString();
                    helper.Set2(cellName: temp, value: smth, respSheetreq.Sheets[i].Properties.Title, fileid);
                    j++;
                }
                beginningRange++;
                i++;
            }
            /*
            var values = helper.GetMarksAndNickOfEachStudent();
           // IList<IList<object>> value = (IList<IList<object>>)values[0];
            var range = "B3:D80"; 
            var value_range_body = new ValueRange
            {
                Values = values,
                MajorDimension = "COLUMNS",

            };
            
             записує дані, однак лише масив масивів та у більше, ніж один стовпчик

            var Qrequest = helper.sheetService.Spreadsheets.Values.Update(value_range_body, fileid, range);
            Qrequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var Qresponce=Qrequest.Execute();
            */
        }

        private void txtStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
