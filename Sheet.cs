using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm2
{
    public  class Sheet
    {
        string sheetFileName;
        readonly string  sheetID;

        public string SheetFileName
        { 
            get
            {
            return sheetFileName; }
            set
            {
                sheetFileName = value;
            }
        
        }
        public string SheetID
        {
            get
            {
            return sheetID; }
        }

        public Sheet(string sheetFileName, string sheetID)
        {
            this.sheetFileName = sheetFileName;
            this.sheetID = sheetID;
            
        }
    }
}
