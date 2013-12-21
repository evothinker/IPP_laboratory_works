using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    public class DataObjectProxy
    {
        int btnNr;
        string uri;
        string fileName;

        public DataObjectProxy()
        {
            btnNr = 0;
            uri = null;
            fileName = null;
        }

        public DataObjectProxy(int btnNr,string uri,string fileName)
        {
            this.btnNr = btnNr;
            this.uri = uri;
            this.fileName = fileName;
        }

        public int getBtnNr()
        {
            return btnNr;
        }

        public string getUri()
        {
            return uri;
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}
