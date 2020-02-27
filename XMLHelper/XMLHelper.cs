using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLHelper
{
    public class XMLHelper
    {
        public static XmlNode AddNode(XmlDocument xmlDoc, string newNodeName,
           string innerText = null,
           string attributeName = null, string attributeValue = null,
           XmlNode parentNode = null)
        {
            XmlNode newNode = xmlDoc.CreateElement(newNodeName);

            // Add innertext
            if (innerText != null)
            {
                newNode.InnerText = innerText;
            }

            // Add if attribute if there is any
            if (attributeName != null)
            {
                XmlAttribute newNodeAttribute = xmlDoc.CreateAttribute(attributeName);
                if (attributeValue != null) newNodeAttribute.Value = attributeValue;
                newNode.Attributes.Append(newNodeAttribute);
            }

            if (parentNode != null) // Append newNode to parentNode
            {
                parentNode.AppendChild(newNode);
            }
            else // Append newNode to xmlDoc
            {
                xmlDoc.AppendChild(newNode);
            }

            return newNode;
        }

        public static void AddAttribute(XmlDocument xmlDoc, string attributeName, string attributeVal, XmlNode node)
        {
            XmlAttribute xmlAttribute = xmlDoc.CreateAttribute(attributeName);
            xmlAttribute.Value = attributeVal;
            node.Attributes.Append(xmlAttribute);
        }
    }
}
