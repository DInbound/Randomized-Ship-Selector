﻿using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Randomized_Ship_Selector
{
    public class Config
    {
        public Uri WebShipDataJson { get; }
        public Uri WebImages { get; }
        public Uri WebVersionAPI { get; }
        public string LocalShipDataJson { get; }
        public string LocalImages { get; }
        public string AppID { get; }

        public Config()
        {
            string resource = "Randomized_Ship_Selector.Resources.rss.config";

            XmlDocument doc = new XmlDocument();
            doc.Load(this.GetType().Assembly.GetManifestResourceStream(resource));

            WebShipDataJson = new Uri(doc.DocumentElement.SelectSingleNode("web/shipData").InnerText);
            WebImages = new Uri(doc.DocumentElement.SelectSingleNode("web/shipImages").InnerText);
            WebVersionAPI = new Uri(doc.DocumentElement.SelectSingleNode("web/version").InnerText);
            LocalShipDataJson = doc.DocumentElement.SelectSingleNode("local/shipData").InnerText;
            LocalImages = doc.DocumentElement.SelectSingleNode("local/shipImages").InnerText;
            AppID = doc.DocumentElement.SelectSingleNode("appId").InnerText;
        }
    }
}
