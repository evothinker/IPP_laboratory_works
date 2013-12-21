using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class DataObjectCachingProxy : DataObjectProxy
    {
        public MemoryStream imageStream;

        DataObjectCachingProxy() : base()
        {
            imageStream = null;
        }

       public DataObjectCachingProxy(int btnNr,string uri,string fileName) : base(btnNr, uri, fileName)
        {
            //base(btnNr, uri, fileName); //not working here :(
            //file = File.OpenWrite("tmp.jpg");
            imageStream = new MemoryStream();
        }

        public MemoryStream getImageStream()
        {
            return imageStream;
        }

        public void setImageStream(MemoryStream input)
        {
            imageStream = input;
        }
    }
}
