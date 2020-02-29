using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParseXmlResume.Data
{
    [XmlRoot(ElementName = "cv", DataType = "string", IsNullable = true)]
    public class Resume
    {
        [XmlElement("personal-data")]
        public PersonalData PersonalData { get; set; }
        [XmlElement("course-data")]
        public CourseData CourseData { get; set; }
    }

}
