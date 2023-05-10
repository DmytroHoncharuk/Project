using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm2
{
    public class Services
    {
        private Form2 form; 
        private SheetsService sheetService;
        private DriveService driveService;

        private IList<Google.Apis.Drive.v3.Data.File> files; 
        private List<Sheet> sheets = new List<Sheet>();

        public List<Sheet> Sheets
        {
            get
            {
                return sheets;
            }
            set
            {
                sheets = value;
            }
        
        }
        public IList<Google.Apis.Drive.v3.Data.File> Files
        { get; set; }
        public SheetsService SheetService
        { get; }
        public DriveService DriveService
        {
            get;
        }

        public Services(DriveService driveService , SheetsService sheetService, Form2 form  )
        {
        this.sheetService = sheetService;
        this.driveService = driveService;
          Files  = new List<Google.Apis.Drive.v3.Data.File>();
            this.form = form; 
        }

        public IList<Google.Apis.Drive.v3.Data.File>  GetFiles()
        {
            IList<Google.Apis.Drive.v3.Data.File> files = driveService.Files.List().Execute().Files;
            
            return files;
        }
        public void VerifySheets()
        {
            foreach (TextBox textBox in form.textBoxes)
            {

                
            }
        }

        public void GetSheet(string SheetFileName, int index)
        {
            string sheetId = "";
            if (CheckSheet(SheetFileName, out sheetId))
            {
                Sheet sheet = new Sheet(SheetFileName, sheetId);
                Sheets.Add(sheet);
                form.checkBoxes[index].Checked = true;
                form.textBoxes[index].BackColor = Color.LightGreen;

            }
            else
            {
                form.textBoxes[index].BackColor = Color.LightCoral; 
            }

        }

        public bool CheckSheet(string SheetFileName, out string sheetId)
        {
            foreach (var file in Files)
            {
                if (file.Name == SheetFileName)
                {
                    sheetId = file.Id;
                    return true;
                    
                }
            }
            sheetId = "";

            return false;

        }

    }
}
