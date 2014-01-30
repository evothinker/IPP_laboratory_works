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
        //download an image into a file from specified uri
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

                        outputStream.Flush();
                        outputStream.Write(buffer,0,bytesRead);
                    } while (bytesRead != 0);
                }
                retVal = true;
            }
            return retVal;
        }

        //store in a memory stream a image downloaded from specified uri
        public Boolean StoreInMemoryRemoteImage(string uri,string fileName,ref MemoryStream outputStream)
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
                using (MemoryStream tmpStream = new MemoryStream())
                {
                    //get the response stream and copy it to tmpStream
                    response.GetResponseStream().CopyTo(tmpStream);

                    //writes the tmpStream into buffer array
                    byte[] buffer = tmpStream.ToArray();

                    //writes the buffer to tmpStream
                    int bytesRead = (int)tmpStream.Length;

                    outputStream.Flush(); //flushes the stream 
                    outputStream.Write(buffer, 0, bytesRead);
                }
                retVal = true;
            }
            return retVal;
        }

        //writes an image to a file from the memory
        public void DownloadImageFromMemory(MemoryStream _imageStream,string fileName)
        {
            using (Stream outputStream = File.OpenWrite(fileName))
            {
                //writes the stream into buffer array
                byte[] buffer = _imageStream.ToArray();

                //the length of the stream
                int bytesRead = (int) _imageStream.Length;

                //writes the buffer to outputStream
                outputStream.Write(buffer, 0, bytesRead);
            }
            //_imageStream.Close();
        }

    }
}
