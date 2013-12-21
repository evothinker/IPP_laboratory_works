using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Problem_1
{
    class ImageDownloader
    {
        public Boolean DownloadRemoteImageFile(string uri,string fileName)
        {
            Boolean retVal = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //check that the remote file was found. The ContentType check is performed
            //since a request for a non-existent image file might be redirected to a 
            //404-page, which would yield the StatusCode "OK", even though the image 
            //was not found.

            if ((response.StatusCode == HttpStatusCode.OK || 
                response.StatusCode == HttpStatusCode.Moved || 
                response.StatusCode == HttpStatusCode.Redirect) && 
                response.ContentType.StartsWith("image",StringComparison.OrdinalIgnoreCase))
            {
                 //if the remote file was not found, download it
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer,0,buffer.Length);
                        outputStream.Write(buffer,0,bytesRead);
                    } while (bytesRead != 0);
                }
                retVal = true;
            }
            return retVal;
        }

        public Boolean StoreInMemoryRemoteImage(string uri,string fileName,MemoryStream outputStream)
        {
            Boolean retVal = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //check that the remote file was found. The ContentType check is performed
            //since a request for a non-existent image file might be redirected to a 
            //404-page, which would yield the StatusCode "OK", even though the image 
            //was not found.

            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {
                //if the remote file was not found, download it
                using (Stream inputStream = response.GetResponseStream())
                //using (Stream outputStream = File.OpenWrite(fileName))
                {
                    //Stream tmpStream = new MemoryStream();

                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Flush(); //flushes the stream
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                    //outputStream.Flush(); //flushes the stream
                    //?
                    //inputStream.Close();
                }
                retVal = true;
            }
            return retVal;
        }

        public void DownloadImageFromMemory(MemoryStream _imageStream,string fileName)
        {
            using (Stream outputStream = File.OpenWrite(fileName))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;
                do
                {
                    bytesRead = _imageStream.Read(buffer, 0, buffer.Length);
                    outputStream.Write(buffer, 0, bytesRead);
                } while (bytesRead != 0);
                 
                //_imageStream.CopyTo(outputStream);
                //outputStream.Close();
            }
            //_imageStream.Close();
        }

    }
}
