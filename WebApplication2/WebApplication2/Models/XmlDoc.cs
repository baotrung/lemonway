using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WebApplication2.Models
{
    public class XmlDoc
    {
        public string text;

        private bool IsValidXML()
        {
            try
            {
                if (string.IsNullOrEmpty(this.text) == false)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(this.text);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Xml.XmlException)
            {
                return false;
            }
        }
    }
}