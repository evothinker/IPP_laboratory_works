using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class CachingProxy
    {
        //number of operations
        //int nrOfOperations = 6;

        //instance of Image Downloader Class which simply downloads an image from uri
        ImageDownloader imgDwn = new ImageDownloader();

        //array that stores each image and data related to it(uri,file name)
        DataObjectCachingProxy[] DObjCP = new DataObjectCachingProxy[6];

        public void DownloadImage(int btnNr,string uri,string fileName)
        {
            //if the image was not cached on the proxy
            if (!checkPresence(btnNr-1))
            {
                //download the image and store on proxy
                DObjCP[btnNr - 1] = new DataObjectCachingProxy(btnNr, uri, fileName);
                //write the image from proxy to a file
                imgDwn.StoreInMemoryRemoteImage(uri, fileName,DObjCP[btnNr-1].getImageStream());
                //imgDwn.DownloadImageFromMemory(DObjCP[btnNr - 1].getImageStream(), fileName); //getImageStream()
                //?
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = DObjCP[btnNr-1].imageStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);

                    //_imageStream.CopyTo(outputStream);
                    //outputStream.Close();
                }
                //\?

            }

                //if the image was allready cached on the proxy
            else
            {
                imgDwn.DownloadImageFromMemory(DObjCP[btnNr - 1].getImageStream(), fileName);
            }
            //Console.WriteLine("test");
            DObjCP[btnNr - 1].imageStream.Close();
        }

        private Boolean checkPresence(int _btnNr)
        {
            //Proxy proxy = new Proxy();
            //return (proxy.checkPresence(_btnNr));
            if (DObjCP[_btnNr] == null)
            {
                return false;
            }
            return true;
        }

       
        
    }
}
