using System;
using System.Collections.Generic;
using System.Text;

namespace TestAssetClient.Data
{
    public class Story
    {
        public string Scope { get; set; }
        public string Href { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public Boolean IsClosed { get; set; }
        public string[] OwnersNickname { get; set; }
        public Attachment[] Attachments { get; set; }
        public class Attachment
        {
            public string type { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }
        public string GetXML()
        {
            string xml = String.Empty;

            xml += "<Asset>";

            xml += "<Attribute name = \"Name\" act = \"set\" >" + Name + "</Attribute>";

            xml += "<Relation name = \"Scope\" act = \"set\" ><Asset idref = \"" + Scope + "\"/></Relation>";

            //isClosed
            //Owners
            //href - at update?
            xml += "</Asset>";
            return xml;
        }
    }
}
