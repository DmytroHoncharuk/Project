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
        private DriveService driveService;
        private SheetsService sheetService;
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
        internal void DisplayStudentFromGroup(string group, ref TextBox textBox, List<List<string>> listOfStudent)
        {
            textBox.Clear();
            for (int i = 0; i < listOfStudent[0].Count; i++)
            {
                if (listOfStudent[0][i] == group)
                {
                    textBox.Text+= listOfStudent[1][i] + Environment.NewLine;
                }
            }
        }

        internal string Get(string cellName)
        {
            var range = this.sheetName + "!" + cellName + ":" + cellName;
            var request = this.sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range);
            var response = request.Execute();
            return response.Values?.First()?.First()?.ToString();
        }
        internal List<List<string>>/*IList<IList<object>>*/ GetStudent()
        {
            var range1 = this.sheetName + "!" + "E" + ":" + "E";
            var range2 = this.sheetName + "!" + "C" + ":" + "C";
            var request = this.sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range1);
            var response = request.Execute();

            List<object> StudentsGroup = response.Values.SelectMany(x => x).ToList();
            List<string> Student_Group_As_String = StudentsGroup.ConvertAll(x => x.ToString());
            ////////////////////////////////////////////////////////////////
            request = this.sheetService.Spreadsheets.Values.Get(spreadsheetId: this.sheetFileId, range: range2);
            response = request.Execute();

            List<object> StudentsName = response.Values.SelectMany(x => x).ToList();
            List<string> Student_Name_As_String = StudentsName.ConvertAll(x => x.ToString());

            List<List<string>> finalList = new List<List<string>>() { Student_Group_As_String, Student_Name_As_String };
            return finalList; 
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

        public Google.Apis.Drive.v3.Data.File CreateSheet()
        {
            string[] scopes = new string[] { DriveService.Scope.Drive,
                      DriveService.Scope.DriveFile,};
            var clientId = "468012233136-6ta4lbrmue4jqp1p5i739ukb8s1sjc0u.apps.googleusercontent.com";      // From https://console.developers.google.com  
            var clientSecret = "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";          // From https://console.developers.google.com  
                                                                  // here is where we Request the user to give us access, or use the Refresh Token that was previously stored in %AppData%  
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            }, scopes,
            Environment.UserName, CancellationToken.None, new FileDataStore("MyAppsToken")).Result;
            //Once consent is recieved, your token will be stored locally on the AppData directory, so that next time you wont be prompted for consent.   
            DriveService _service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "MyAppName",

            });
            var _parent = "";//ID of folder if you want to create spreadsheet in specific folder
            var filename = "helloworld";
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = filename,
                MimeType = "application/vnd.google-apps.spreadsheet",
                //TeamDriveId = teamDriveID, // IF you want to add to specific team drive  
            };
            FilesResource.CreateRequest request = _service.Files.Create(fileMetadata);
            request.SupportsTeamDrives = true;
            fileMetadata.Parents = new List<string> { _parent }; // Parent folder id or TeamDriveID  
            request.Fields = "id";
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            var file = request.Execute();
            MessageBox.Show("File ID: " + file.Id);
            return file;
        }
    }
}
