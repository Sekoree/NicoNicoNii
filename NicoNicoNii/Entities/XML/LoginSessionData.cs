using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NicoNicoNii.Entities.XML
{
    [XmlRoot(ElementName = "nicovideo_user_response")]
    public class LoginSessionData
    {
        [XmlElement(ElementName = "session_key")]
        public string SessionKey { get; set; }
        [XmlElement(ElementName = "expire")]
        public string Expire { get; set; }
        [XmlElement(ElementName = "user_id")]
        public string UserId { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }
}
