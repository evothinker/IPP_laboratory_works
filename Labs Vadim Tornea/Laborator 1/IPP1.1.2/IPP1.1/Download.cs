using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace IPP1._1
{
    class Download : IDownload
    {
        //function for downloading the images
        public void GetImage(string fileName, string url)
        {
            string localFilename = @"D:\DownloadedImages\" + fileName + ".jpg";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, localFilename);
            }
        }
    }
}
