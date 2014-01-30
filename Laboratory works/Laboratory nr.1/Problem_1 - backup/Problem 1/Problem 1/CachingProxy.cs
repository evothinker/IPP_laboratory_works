using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem_1
{
    class CachingProxy
    {
        //instance of Image Downloader Class which simply downloads an image from uri
        ImageDownloader imgDwn = new ImageDownloader();

        //array that stores each image and data related to it(uri,file name)
        //actually is the caching proxy that can store max 6 images
        DataObjectCachingProxy[] DObjCP = new DataObjectCachingProxy[6];

        public void DownloadImage(int btnNr,string uri,string fileName)
        {
            //if the image was not cached on the proxy
            if (!checkPresence(btnNr-1))
            {
                //allocate memory in Caching Proxy for store the remote image and metadata related to it
                DObjCP[btnNr - 1] = new DataObjectCachingProxy(btnNr, uri, fileName);
                
                //store the remote image into Caching Proxy
                imgDwn.StoreInMemoryRemoteImage(uri, fileName,ref DObjCP[btnNr-1].imageStream);

                //writes the image from proxy to a file
                using (FileStream outputStream = File.OpenWrite(fileName))
                {
                    //writes stream from proxy into buffer array
                    byte[] buffer = DObjCP[btnNr - 1].imageStream.ToArray();

                    //get the length of the buffer
                    int bytesRead = (int) DObjCP[btnNr - 1].imageStream.Length;

                    //flash the outputStream
                    outputStream.Flush();

                    //writes the buffer to outputStream
                    outputStream.Write(buffer, 0, bytesRead);

                }

            }

                //if the image was allready cached on the proxy
            else
            {
                //writes the image from proxy to a file
                imgDwn.DownloadImageFromMemory(DObjCP[btnNr - 1].imageStream, fileName);
            }
            return;
        }

        //checks if the image is pressent allready on the proxy
        private Boolean checkPresence(int _btnNr)
        {;
            if (DObjCP[_btnNr] == null)
            {
                return false;
            }
            return true;
        }

       
        
    }
}
