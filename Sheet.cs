using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm2
{
    internal class Sheet
    {
        string sheetFileName;
        readonly string  sheetID;

        public string SheetFileName
        { get; set; }
        public string SheetID
        {
            get; 
        }

        public Sheet(string sheetFileName, string sheetID)
        {
            SheetFileName = sheetFileName;
            this.sheetID = sheetID;
            
        }
    }
}
