using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

/// <summary>
/// 接口空间
/// </summary>
namespace GSHFrameWork.Interface
{
    /// <summary>
    /// Xml读取工具接口
    /// </summary>
    public interface IFrameWorkXmlReadTool
    {
        /// <summary>
        /// 获取Xml自需内容
        /// </summary>
        /// <param name="path">xml完整路径</param>
        /// <param name="action">外部回调函数处理逻辑</param>
        /// <returns>自需内容</returns>
        string GetTargetXmlContent(string path, Func<XmlDocument, string> action);

        /// <summary>
        /// 获取目标XmlNode的所有Node内容
        /// </summary>
        /// <param name="path">Xml文件完整路径</param>
        /// <param name="rootNodeName">根节点名称</param>
        /// <param name="targetNodeName">目标节点名称</param>
        /// <param name="action">外部回调函数处理逻辑</param>
        /// <returns>InnerText[]</returns>
        string[] GetTargetNodeAllContent(string path, string rootNodeName, string targetNodeName, Func<XmlNode, string, string[]> action);



        /// <summary>
        /// 获取目标XmlNode的所有Node
        /// </summary>
        /// <param name="path">xml完整路径</param>
        /// <param name="rootNodeName">根节点名称</param>
        /// <param name="targetNodeName">目标节点名称</param>
        /// <param name="action">外部回调函数处理逻辑</param>
        /// <returns>XmlNode[]</returns>
        XmlNode[] GetTargetNodeAllContent(string path,string rootNodeName, string targetNodeName, Func<XmlNode, string, XmlNode[]> action);


    }
}
