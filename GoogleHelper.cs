using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm2
{
    internal class GoogleHelper
    {
        private readonly string token;
        private readonly string sheetFileName;
        private UserCredential credentials;
        public DriveService driveService;
        public SheetsService sheetService;
        private string sheetFileId;
        private string sheetName;

        public GoogleHelper(string token, string sheetFileNeme)
        {
            this.token = token;
            this.sheetFileName = sheetFileNeme;
        }

        public string ApplicationName
        {
            get;
            private set;
        } = "TestForm2";
        public string[] Scopes
        {
            get;
            private set;
        } = new string[] {DriveService.Scope.Drive, SheetsService.Scope.Spreadsheets};

        internal string Get(string cellName)
        {
            var range = this.sheetName + "!" + cellName + ":" + cellName;
            var request = this.sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range);
            var response = request.Execute();
            return response.Values?.First()?.First()?.ToString();
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
        internal List<string> GetListRequest(string range)
        {
            var request = this.sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range);
            var response = request.Execute();
            List<object> informationFromSheet = response.Values.SelectMany(x => x).ToList();
            List<string> informationFromSheetAsString = informationFromSheet.ConvertAll(x => x.ToString());
            return informationFromSheetAsString;
        }
        internal void Set(string cellName, string value)
        {
            var range = this.sheetName + "!" + cellName + ":" + cellName; 
            var values = new List<List<object>> { new List<object> { value} };

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
        internal async Task <bool> Start()
        {
            string credentionalpath = Path.Combine(Environment.CurrentDirectory, ".credentials", ApplicationName);

            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                this.credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets: GoogleClientSecrets.Load(stream).Secrets,
                    scopes: this.Scopes,
                    user: "user",
                    taskCancellationToken: CancellationToken.None,
                    new NullDataStore()).Result; 
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            this.driveService = new DriveService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = this.credentials,
                ApplicationName = ApplicationName,
            });
            this.sheetService = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = this.credentials,
                ApplicationName = ApplicationName,
            });

            var request = this.driveService.Files.List();
            var response = request.Execute(); 
            foreach (var file in response.Files)
            {
                if (file.Name == this.sheetFileName)
                {
                    this.sheetFileId = file.Id; //отримуємо ID файлу
                    break;
                }
            }
            if (!string.IsNullOrEmpty( this.sheetFileId))
            {
                var sheetRequest = this.sheetService.Spreadsheets.Get(this.sheetFileId);
                var sheetResponse = sheetRequest.Execute();

                this.sheetName = sheetResponse.Sheets[0].Properties.Title; 
                return true; 
            }
            return false;
        }
    }
}
