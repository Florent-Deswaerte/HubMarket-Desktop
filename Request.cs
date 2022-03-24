using System;
using System.IO;
using System.Net;
using System.Text;

namespace HubMarket_Desktop
{
    public class Request
    {
        private string baseUrl;
        private HttpWebResponse response;
        private Stream responseStream;
        private StreamReader reader;

        public Request() { }

        public Request(string url)
        {
            this.baseUrl = url;
        }

        public void ResetRequest()
        {
            this.response = null;
            this.responseStream = null;
            this.baseUrl=null;
        }

        public string Get()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.GetUrl());
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            this.response = response;
            Stream stream = response.GetResponseStream();
            this.responseStream = stream;
            StreamReader reader = new StreamReader(stream);
            this.reader = reader;
            return reader.ReadToEnd();
        }

        public string Post(string data, string contentType, string method = "POST")
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.baseUrl);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.ContentLength = dataBytes.Length;
            request.ContentType = contentType;
            request.Method = method;

            using (Stream requestBody = request.GetRequestStream())
            {
                requestBody.Write(dataBytes, 0, dataBytes.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            this.response = response;
            Stream stream = response.GetResponseStream();
            this.responseStream = stream;
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public string GetUrl()
        {
            if (this.baseUrl == null) return null;
            return this.baseUrl;
        }

        public string SetUrl(string newUrl)
        {
            if (newUrl == null) return null;
            else
            {
                this.baseUrl = newUrl;
                return this.baseUrl;
            }
        }

        public HttpWebResponse GetResponse()
        {
            if (this.response == null) return null;
            else
            {
                return this.response;
            }
        }

        public Stream GetResponseStream()
        {
            if (this.responseStream == null) return null;
            else
            {
                return this.responseStream;
            }
        }

        public StreamReader GetStreamReader()
        {
            if(this.reader == null) return null;
            else
            {
                return this.reader;
            }
        }
    }
}
