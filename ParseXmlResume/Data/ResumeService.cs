using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ParseXmlResume.Data
{
    public class ResumeService
    {
        public Resume ParseResumeFromXml()
        {
            string testData = @"<cv>
                                <personal-data>
                                </personal-data>
                                <course-data>
                                <cn>FUCK YOUSEF</cn>
                                <cd>696969</cd>
                                </course-data>
                                </cv>";
            XmlSerializer serializer = new XmlSerializer(typeof(Resume));
            Resume result = new Resume{ };
            using (TextReader reader = new StringReader(testData))
            {
                result = (Resume)serializer.Deserialize(reader);
            }
            Console.WriteLine(result.CourseData.CourseDescription);
            return result;
            
            //XDocument doc = XDocument.Parse(str);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
            //byte[] bytes;
            //bytes = System.Text.Encoding.ASCII.GetBytes(str);
            //request.ContentType = "text/xml; encoding='utf-8'";
            //request.ContentLength = bytes.Length;
            //request.Method = "POST";
            //Stream requestStream = request.GetRequestStream();
            //requestStream.Write(bytes, 0, bytes.Length);
            //requestStream.Close();
            //HttpWebResponse response;
            //response = (HttpWebResponse)request.GetResponse();
            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    Stream responseStream = response.GetResponseStream();
            //    string responseStr = new StreamReader(responseStream).ReadToEnd();
            //    return responseStr;
            //}
            //return null;
        }
    }
}
