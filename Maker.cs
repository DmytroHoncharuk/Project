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

        public void MakeInputBox(int number, int positionX, int positionY)
        {
            LableMake(number , positionX,  positionY + 25 );
            TexBoxMake(number, positionX+150, positionY + 25);

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
                parentForm.textBoxes.Add(textBox);
                parentForm.Controls.Add(textBox);
                
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
