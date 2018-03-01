﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsumeWebService.Services
{
    public class WebService
    {
        public string Url { get; private set; }
        public string Method { get; private set; }
        public Dictionary<string, string> Params = new Dictionary<string, string>();
        public XDocument ResponseSOAP = XDocument.Parse("<root/>");
        public XDocument ResultXML = XDocument.Parse("<root/>");
        public string ResultString = String.Empty;
       

        public WebService()
        {
            Url = String.Empty;
            Method = String.Empty;
        }

        public WebService(string baseUrl)
        {
            Url = baseUrl;
            Method = String.Empty;
        }

        public WebService(string baseUrl, string methodName)
        {
            Url = baseUrl;
            Method = methodName;
        }

        // Public API

        /// <summary>
        /// Adds a parameter to the WebMethod invocation.
        /// </summary>
        /// <param name="name">Name of the WebMethod parameter (case sensitive)</param>
        /// <param name="value">Value to pass to the paramenter</param>
        public void AddParameter(string name, string value)
        {
            Params.Add(name, value);
        }

        public void Invoke()
        {
            Invoke(Method, true);
        }

        /// <summary>
        /// Using the base url, invokes the WebMethod with the given name
        /// </summary>
        /// <param name="methodName">Web Method name</param>
        public void Invoke(string methodName)
        {
            Invoke(methodName, true);
        }

        /// <summary>
        /// Cleans all internal data used in the last invocation, except the WebService's URL.
        /// This avoids creating a new WebService object when the URL you want to use is the same.
        /// </summary>
        public void CleanLastInvoke()
        {
            ResponseSOAP = ResultXML = null;
            ResultString = Method = String.Empty;
            Params = new Dictionary<string, string>();
        }

        #region Helper Methods

        /// <summary>
        /// Checks if the WebService's URL and the WebMethod's name are valid. If not, throws ArgumentNullException.
        /// </summary>
        /// <param name="methodName">Web Method name (optional)</param>
        private void AssertCanInvoke(string methodName = "")
        {
            if (Url == String.Empty)
                throw new ArgumentNullException("You tried to invoke a webservice without specifying the WebService's URL.");
            if ((methodName == "") && (Method == String.Empty))
                throw new ArgumentNullException("You tried to invoke a webservice without specifying the WebMethod.");
        }

        private void ExtractResult(string methodName)
        {
            // Selects just the elements with namespace http://tempuri.org/ (i.e. ignores SOAP namespace)
            XmlNamespaceManager namespMan = new XmlNamespaceManager(new NameTable());
            namespMan.AddNamespace("ns1", "http://schemas.xmlsoap.org/soap/envelope/");

            XElement webMethodResult = ResponseSOAP.XPathSelectElement("//ns1:" + methodName + "Response", namespMan);
            // If the result is an XML, return it and convert it to string

            if (webMethodResult != null)
            {
                if (webMethodResult.FirstNode.NodeType == XmlNodeType.Element)
                {
                    ResultXML = XDocument.Parse(webMethodResult.FirstNode.ToString());
                    ResultXML = Utils.RemoveNamespaces(ResultXML);
                    ResultString = ResultXML.ToString();
                }
                // If the result is a string, return it and convert it to XML (creating a root node to wrap the result)
                else
                {
                    ResultString = webMethodResult.FirstNode.ToString();
                    ResultXML = XDocument.Parse("<root>" + ResultString + "</root>");
                }
            }else
            {
                ResultString = ResponseSOAP.ToString();
            }
            
        }

        /// <summary>
        /// Invokes a Web Method, with its parameters encoded or not.
        /// </summary>
        /// <param name="methodName">Name of the web method you want to call (case sensitive)</param>
        /// <param name="encode">Do you want to encode your parameters? (default: true)</param>
        private void Invoke(string methodName, bool encode)
        {
            AssertCanInvoke(methodName);
            string soapStr =
                @"<?xml version=""1.0"" encoding=""utf-8""?>
                <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
                   xmlns:xsd=""http://www.w3.org/2001/XMLSchema""
                   xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                  <soap:Body>
                    <{0} xmlns=""http://tempuri.org/"">
                      {1}
                    </{0}>
                  </soap:Body>
                </soap:Envelope>";

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.Headers.Add("SOAPAction", "\"http://tempuri.org/" + methodName + "\"");
            req.ContentType = "text/xml;charset=\"utf-8\"";
            req.Accept = "text/xml";
            req.Method = "POST";

            using (Stream stm = req.GetRequestStream())
            {
                string postValues = "";
                foreach (var param in Params)
                {
                    if (encode) postValues += string.Format("<{0}>{1}</{0}>", HttpUtility.HtmlEncode(param.Key), HttpUtility.HtmlEncode(param.Value));
                    else postValues += string.Format("<{0}>{1}</{0}>", param.Key, param.Value);
                }

                soapStr = string.Format(soapStr, methodName, postValues);
                using (StreamWriter stmw = new StreamWriter(stm))
                {
                    stmw.Write(soapStr);
                }
            }

            using (StreamReader responseReader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                string result = responseReader.ReadToEnd();
                ResponseSOAP = XDocument.Parse(Utils.UnescapeString(result));
                ExtractResult(methodName);
            }
        }

        /// <summary>
        /// This method should be called before each Invoke().
        /// </summary>
        internal void PreInvoke()
        {
            CleanLastInvoke();
            //InitialCursorState = Cursor.Current;
            //Cursor.Current = Cursor.WaitCursor;
            // feel free to add more instructions to this method
        }

        /// <summary>
        /// This method should be called after each (successful or unsuccessful) Invoke().
        /// </summary>
        internal void PosInvoke()
        {
            //Cursor.Current = InitialCursorState;
            // feel free to add more instructions to this method
        }


        #endregion


    }
}