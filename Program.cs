using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleApp1.TextCasingService;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program proga = new Program();
            TextCasing obj = new TextCasing();
            string s = Console.ReadLine();
            Console.WriteLine(obj.InvertStringCase(s));
            proga.CreateSOAPWebRequest();
            Console.ReadKey();
            
        }

        public HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request  
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://www.dataaccess.com/webservicesserver/TextCasing.wso?wsdl");
            //Content_type  
            request.ContentType = "text/xml;";
            request.Accept = "text/xml";
            //HTTP method  
            request.Method = "POST";
            //return HttpWebRequest  
            Console.WriteLine("Total tid: " + request.Timeout);
            return request;
        }

    }


    
}