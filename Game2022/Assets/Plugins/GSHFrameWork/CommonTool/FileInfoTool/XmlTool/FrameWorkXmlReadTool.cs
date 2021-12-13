
using GSHFrameWork.Interface;

using System;
using System.IO;
using System.Xml;

/// <summary>
/// 工具空间
/// </summary>
namespace GSHFrameWork.SingleTool
{
    /// <summary>
    /// Xml读取工具
    /// </summary>
    internal class FrameWorkXmlReadTool : SingleClass<FrameWorkXmlReadTool>, IFrameWorkXmlReadTool
    {

        XmlDocument xmlDocument;

        /// <summary>
        /// 单例Xml读取工具 初始化
        /// </summary>
        public override void Init()
        {
            base.Init();
            xmlDocument = new XmlDocument();
        }

        public string GetTargetXmlContent(string path, Func<XmlDocument, string> action)
        {
            string content = "Xml未正确读取";
            xmlDocument.Load(path);
            string rightContent = action(xmlDocument);
            return string.IsNullOrEmpty(rightContent) ? content : rightContent;
        }

   
        public string[] GetTargetNodeAllContent(string path, string rootNodeName, string targetNodeName, Func<XmlNode, string, string[]> action)
        {
            string[] content = { "Xml未正确读取!" };
            if (!File.Exists(path))
            {
                return content;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNode xmlNode = xmlDocument.SelectSingleNode(rootNodeName);
            string[] rightContent = action(xmlNode, targetNodeName);
            return rightContent == null ? content : rightContent;
        }
   
        public XmlNode[] GetTargetNodeAllContent(string path, string rootNodeName, string targetNodeName, Func<XmlNode, string, XmlNode[]> action)
        {
            XmlNode[] content = { };
            if (!File.Exists(path))
            {
                return content;
            }
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Root");
            XmlNode[] rightContent = action(xmlNode, targetNodeName);
            return rightContent == null ? content : rightContent;
        }

        /// <summary>
        /// 卸载
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
            xmlDocument = null;
        }
    }


}
