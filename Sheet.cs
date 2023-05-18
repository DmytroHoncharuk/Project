using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm2
{
    public  class Sheet
    {
        private string sheetFileName;
        private readonly string  sheetFileID;

        public string FileName
        { 
            get
            {
            return sheetFileName; }
            set
            {
                sheetFileName = value;
            }
        
        }
        public string FileID
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
