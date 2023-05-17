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
        readonly string  sheetFileID;

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
        public string SheetFileID
        {
            get
            {
            return sheetFileID; }
        }

        public Sheet(string sheetFileName, string sheetFileID)
        {
            this.sheetFileName = sheetFileName;
            this.sheetFileID = sheetFileID;
            
        }
    }
}
