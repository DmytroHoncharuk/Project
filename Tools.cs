using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm2
{

    public static class Tools
    {
        internal static void SheetCreation(Services services, string fileid, string nameOfSheet)
        {
            var requestNewsheet = new Request
            {
                AddSheet = new AddSheetRequest
                {
                    Properties = new SheetProperties
                    {
                        Title = nameOfSheet
                    }
                }
            };
            // Створення батч-запиту
            var batchUpdateRequest = new BatchUpdateSpreadsheetRequest
            {
                Requests = new List<Request> { requestNewsheet }
            };
            // Виклик сервісу для створення листка
            SpreadsheetsResource.BatchUpdateRequest batchUpdate = services.SheetService.Spreadsheets.BatchUpdate(batchUpdateRequest, fileid);
            BatchUpdateSpreadsheetResponse batchUpdateResponse = batchUpdate.Execute();
        }
    }
}
