using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class XmlToJsonController : ApiController
    {
        [HttpPost]
        public dynamic Post([FromBody] string text)
        {
  
            try
            {
                if (string.IsNullOrEmpty(text) == false)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(text);
                    string jsonText = JsonConvert.SerializeXmlNode(xmlDoc);
                    return JObject.Parse(jsonText);
                }
                else
                {
                    return "input is empty";
                }
            }
            catch (System.Xml.XmlException)
            {
                return "Bad xml format";
            }
        }


    }
}
