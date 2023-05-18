using Google.Apis.Util;
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
       ///private Services services;
        public GoogleLogin Helper
        { 
            get
            {
            return helper; }
            set
            {
                helper = value;
            }
        
        }

        //public Services Services
        //{
        //    get
        //    {
        //        return services;
        //    }
          
        
        //}

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

            var result = helper.Get(cellName: txtCellNameGet.Text, helper.Services.Sheets[number_sheet]);
            txtCellGetValue.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOfNewFileCreation_Click(object sender, EventArgs e)
        {
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "New file", // задає ім'я створеного файлу, можна реалізувати те, що користувач буде вводити ім'я в textbox сам
                MimeType = "application/vnd.google-apps.spreadsheet"
            };


            var test = helper.Services.SheetService;
            var request = helper.Services.driveService.Files.Create(fileMetadata);
            request.Fields = "id";
            var file = request.Execute();
            var fileid = file.Id;
            Tools.SheetCreation(helper.Services, fileid, "Неліквідні випадки");



            //////////////////////
            /*
            var values = helper.GetMarksAndNickOfEachStudent("А1");
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
                    helper.SetCell(cellName: cell, value: smth, respSheetreq.Sheets[i].Properties.Title, fileid); // вставлення даних
                    j++;
                }
                beginningRange++;
                i++;
            }*/
        }

    }
}
