using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParseXmlResume.Data
{
    
    public class CourseData
    {
        [XmlElement("CN")]
        public string CourseName { get; set; }
        [XmlElement("CD")]
        public string CourseDescription { get; set; }
    }
}
