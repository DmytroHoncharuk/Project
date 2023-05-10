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
        private Form parentForm;
        private List<TextBox> textBoxes;
        private List<CheckBox> checkBoxes;

        public Maker(List<TextBox> textBoxes, List<CheckBox> checkBoxes, Form parentForm)
        {
        this.textBoxes = textBoxes;
            this.checkBoxes = checkBoxes;

            this.parentForm = parentForm;
        }

        public void MakeInputBox(int number, int positionX, int positionY)
        {
            LableMake(number , positionX,  positionY + 25 );
            TexBoxMake(number, positionX+150, positionY + 25);
            CheckBoxMake(number, positionX + 420, positionY + 25); 

        }

        private void CheckBoxMake(int number, int positionX, int positionY)
        {
            int textBoxHeight = 20;
            for (int i = 0; i < number; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Location = new Point(positionX, positionY + i * (textBoxHeight + 8));
                checkBox.Enabled = false;


                checkBoxes.Add(checkBox);



                //parentForm.textBoxes.Add(textBox);
                //parentForm.Controls.Add(textBox);

            }
        }

        public  void TexBoxMake(int numberOfTexNox, int positionX, int positionY)
        {
            
            int textBoxWidth = 250;
            int textBoxHeight = 20;
            for (int i = 0; i < numberOfTexNox; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(positionX, positionY + i * (textBoxHeight + 8));
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBoxes.Add(textBox);
                


                //parentForm.textBoxes.Add(textBox);
                //parentForm.Controls.Add(textBox);
                
            }
        }
        public void LableMake(int numberOflable, int positionX, int positionY)
        {
            
            
            int textBoxHeight = 20;
            for (int i = 0; i < numberOflable; i++)
            {
                Label label = new Label();
                label.Font = new System.Drawing.Font("TT Firs Neue", 10F);


                label.Location = new Point(positionX, positionY + i * (textBoxHeight + 8));
                string text = (i + 1) + " тест";
                label.Text = text;


                parentForm.Controls.Add(label);
            }
        }
    }
}
