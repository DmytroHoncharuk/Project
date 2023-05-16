using Google.Apis.Util;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.helper = new GoogleLogin(this); 

            bool succsess = this.helper.Login().Result;
            Maker = new Maker(textBoxes, checkBoxes, this);
            btnMakeTextBox.Enabled = succsess;

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
    }
}
