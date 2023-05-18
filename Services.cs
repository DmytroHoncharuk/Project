using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
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
        {
            get
            {
                return sheetService;
            }
        }
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


        internal List<List<string>> GetMarksAndNickOfEachStudent(string sheetName)
        {
            var rangeForName = sheetName + "!" + "E" + ":" + "E";
            var rangeForNickname = sheetName + "!" + "H" + ":" + "H";
            var studentName = GetListRequest(rangeForName);
            var studentNickName = GetListRequest(rangeForNickname);
            List<List<string>> list_Of_Student_Name_and_Nickname = new List<List<string>>() { studentName, studentNickName };
            return list_Of_Student_Name_and_Nickname;
        }
        internal List<List<string>> GetStudentDataFromTestResults(string sheetName)
        {
            var rangeForName = sheetName + "!" + "E" + ":" + "E";
            var rangeForNickname = sheetName + "!" + "H" + ":" + "H";
            var studentName = GetListRequest(rangeForName);
            var studentNickName = GetListRequest(rangeForNickname);
            List<List<string>> list_Of_Student_Name_and_Nickname = new List<List<string>>() { studentName, studentNickName };
            return list_Of_Student_Name_and_Nickname;
        }
        internal List<string> GetListRequest(string range, string fileId)
        {
            var request = sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range);
            var response = request.Execute();
            List<object> informationFromSheet = response.Values.SelectMany(x => x).ToList();
            List<string> informationFromSheetAsString = informationFromSheet.ConvertAll(x => x.ToString());
            return informationFromSheetAsString;
        }
        internal void Set(string cellName, string value)
        {
            var range = this.sheetName + "!" + cellName + ":" + cellName;
            var values = new List<List<object>> { new List<object> { value } };

            var request = this.sheetService.Spreadsheets.Values.Update(
                new ValueRange { Values = new List<IList<object>>(values) },
                spreadsheetId: this.sheetFileId, range: range
                );
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var response = request.Execute();
        }
        internal void SetCell(string cellName, string value, string sheetName, string fileid)
        {
            //var range = sheetName + "!" + cellName + ":" + cellName;
            var range = sheetName + "!" + cellName + ":" + cellName;
            var values = new List<List<object>> { new List<object> { value } };

            var request = this.sheetService.Spreadsheets.Values.Update(
                new ValueRange { Values = new List<IList<object>>(values) },
                spreadsheetId: fileid, range: range
                );
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
            var response = request.Execute();
        }

    }
}
