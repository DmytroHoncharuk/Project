using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForm2
{
    internal  class Maker 
    {
        private Form1 parentForm;

        public Maker(Form1 form)
        {
        
        parentForm = form;}


        
        public  void TexBoxMake(int numberOfTexNox)
        {
            int startX = 150;
            int startY = 495;
            int textBoxWidth = 100;
            int textBoxHeight = 20;
            for (int i = 0; i < numberOfTexNox; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(startX, startY + i * (textBoxHeight + 5));
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                parentForm.textBoxes.Add(textBox);
                parentForm.Controls.Add(textBox);
                
            }
        }
        public void LableMake(int numberOflable)
        {
            int startX = 35;
            int startY = 495;
            
            int textBoxHeight = 20;
            for (int i = 0; i < numberOflable; i++)
            {
                Label label = new Label();
                label.Location = new Point(startX, startY + i * (textBoxHeight + 5));
                string text = (i + 1) + " тест";
                label.Text = text;


                parentForm.Controls.Add(label);
            }
        }
    }
}
