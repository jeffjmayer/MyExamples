using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {


            const string url = "https://www.le.ac.uk/oerresources/bdra/html/page_09.htm";

            DownloadHtml(url);

            Console.ReadLine();

        }

        private static void DownloadHtml(string url)
        {
            var httpWebRequest = (HttpWebRequest) WebRequest.Create(url);

            httpWebRequest.BeginGetRequestStream(ar =>
            {
                var webResponse = httpWebRequest.EndGetResponse(ar);
                using (var responseStream = webResponse.GetResponseStream())
                {
                    var manualResetEvent = new ManualResetEvent(false);
                    var buffer = new byte[2048];

                    AsyncCallback readCallback = null;

                    readCallback = iar =>
                                                     {

                                                         var bytesRead = responseStream.EndRead((iar));
                                                         if (bytesRead > 0)
                                                         {
                                                             Console.WriteLine(Encoding.UTF8.GetString(buffer, 0,bytesRead));
                                                             responseStream.BeginRead(buffer, 0, buffer.Length, readCallback, null);
                                                         }
                                                         else
                                                         {
                                                             manualResetEvent.Set();
                                                         }

                                                     };

                   responseStream.BeginRead(buffer,0,buffer.Length, readCallback, null);


                }
            }, null);
        }
    }
}
