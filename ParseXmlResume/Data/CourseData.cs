using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParseXmlResume.Data
{
    
    [XmlRoot("cl")]
    public class CourseData
    {
        [XmlElement("cn")]
        public string CourseName { get; set; }
        [XmlElement("cd")]
        public string CourseDescription { get; set; }
    }
}
