using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestForm2
{
    public  class GoogleLogin
    {
        private Form2 Form2;

        private UserCredential credentials;
        public Services services;
        public DriveService driveService;
        public SheetsService sheetService;
        public Services Services
        {
            get
            {
                return services;
            }
        }

        public string[] Scopes
        {
            get;
            private set;
        } = new string[] { DriveService.Scope.Drive, SheetsService.Scope.Spreadsheets };



        // Поток OAuth 2.0, используемый для авторизации пользователя.
        //static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "TestLogin";

        public GoogleLogin(Form2 form2)
        {

            Form2 = form2;
        }


        public async Task<bool> Login()
        {
            try
            {
                string credentionalpath = Path.Combine(Environment.CurrentDirectory, ".credentials", ApplicationName);

                using (var stream =
                    new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
                {
                    // Файл credentials.json содержит учетные данные OAuth 2.0, полученные от Google API Console.
                    // После получения учетных данных с помощью Google API Console сохраните их в файле credentials.json.
                    string credPath = "token.json";
                    credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new NullDataStore()).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }



                //using (var stream = 
                //    new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
                //{
                //    // Файл credentials.json содержит учетные данные OAuth 2.0, полученные от Google API Console.
                //    // После получения учетных данных с помощью Google API Console сохраните их в файле credentials.json.
                //    string credPath = "token.json";
                //    this.credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                //        GoogleClientSecrets.Load(stream).Secrets,
                //        this.Scopes,
                //        "user",
                //        CancellationToken.None,
                //        new NullDataStore()).Result;
                //    Console.WriteLine("Credential file saved to: " + credPath);
                //}







                /// підключення до диску 
                this.driveService = new DriveService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = this.credentials,
                    ApplicationName = ApplicationName,
                });

                /// підключення до таблиць
                /// 

                this.sheetService = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = this.credentials,
                    ApplicationName = ApplicationName,
                });
                services = new Services(driveService, sheetService,Form2);

                services.Files = Services.GetFiles(); 

                return true;

            }
            catch (Exception)
            {

                return false;

                throw;
            }


        }

        internal string Get(string cellName, Sheet sheet)
        {
            string sheetName = ""; 
            if (!string.IsNullOrEmpty(sheet.SheetFileID))
            {

                var sheetRequest = services.SheetService.Spreadsheets.Get(sheet.SheetFileID);
                var sheetResponse = sheetRequest.Execute();

                sheetName = sheetResponse.Sheets[0].Properties.Title;
            }
            var range = sheetName + "!" + cellName + ":" + cellName;
            var request = services.SheetService.Spreadsheets.Values.Get(sheet.SheetFileID, range);
            var response = request.Execute();
            return response.Values?.First()?.First()?.ToString();
        }
    }
}
