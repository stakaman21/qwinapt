using System;
using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WinApt.Common;

namespace WinApt.Client
{
    /// <summary>
    /// class to descript local config files.
    /// it should contains:
    /// local info: en_us, zh_cn, etc.
    /// app that has already downloaded
    /// local dirs
    /// </summary>
[XmlRoot("AppInfoConfig")]
    public class AppInfoConfig
    {
        [XmlElement("local")]
        public string local = string.Empty;

        [XmlElement("updateUrl")]
        public string updateUrl = string.Empty;

        [XmlElement("basePath")]
        public string basePath = string.Empty;

        [XmlElement(Type = typeof(AppInfoBase))]
        public ArrayList Items = null;

        public AppInfoConfig()
        {
            updateUrl = "";
            basePath = "";
            Items = new ArrayList();
        }

        public AppInfoConfig(string local, string basepath, string updateurl)
        {
            this.local = local;
            this.basePath = basepath;
            this.updateUrl = updateurl;
            Items = new ArrayList();
        }
    }
}
