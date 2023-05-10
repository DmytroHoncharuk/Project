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
        private Services services;
        public Services Services
        {
            get
            {
                return services;
            }
        }


        // Поток OAuth 2.0, используемый для авторизации пользователя.
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
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
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new NullDataStore()).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                /// підключення до диску 
                var driveServiceTemp = new DriveService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = this.credentials,
                    ApplicationName = ApplicationName,
                });

                /// підключення до таблиць
                /// 

                var sheetServiceTemp = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = this.credentials,
                    ApplicationName = ApplicationName,
                });
                services = new Services(driveServiceTemp, sheetServiceTemp,Form2);

                services.Files = Services.GetFiles(); 

                return true;

            }
            catch (Exception)
            {

                return false;

                throw;
            }


        }
    }
}
