using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class Proxy
    {
        //number of operations
        int nrOfOperations = 6; 

        //instance of Image Downloader Class which simply downloads an image from uri
        ImageDownloader imgDwn = new ImageDownloader();

        //array that stores data about images, not the images itself
        DataObjectProxy[] DObjP = new DataObjectProxy[6];



        public void DownloadImage(int btnNr,string uri,string fileName)
        {
            if (nrOfOperations > 0)
            {
                if (!checkPresence(btnNr-1))
                {
                    DObjP[btnNr-1] = new DataObjectProxy(btnNr,uri,fileName);
                    nrOfOperations--;
                }
            }
            if (nrOfOperations == 0) this.DownloadAllImages(this.DObjP);
        }

        protected void DownloadAllImages(DataObjectProxy[] DObj)
        {
            for (int i = 0; i < DObj.Length; i++)
            {
                imgDwn.DownloadRemoteImageFile(DObj[i].getUri(), DObj[i].getFileName());
            }
        }

        public Boolean checkPresence(int _btnNr)
        {
                if (DObjP[_btnNr] == null)
                {
                    return false;
                }
            return true;
        }
    }
}
