
using GSHFrameWork.Enum;
using GSHFrameWork.Interface;

using System.Collections.Generic;
using System.Xml;

using UnityEngine;

/// <summary>
/// 工具空间
/// </summary>
namespace GSHFrameWork.SingleTool
{
    /// <summary>
    /// 框架配置表（所有配置表路径均在FrameWork.config中）
    /// </summary>
    class FrameWorkConfigTool : SingleClass<FrameWorkConfigTool>, IFrameWorkConfigTool
    {
        private string framWorkConfig = string.Empty;
        /// <summary>
        /// 框架配置表完全路径
        /// </summary>
        public string FramWorkConfigFullPath { get => framWorkConfig; private set => framWorkConfig = value; }

        /// <summary>
        /// 其他配置表路径
        /// </summary>
        private Dictionary<ConfigEnumType, string> otherConfig;

        /// <summary>
        /// 框架配置表初始化
        /// </summary>
        public override void Init()
        {
            base.Init();
            otherConfig = new Dictionary<ConfigEnumType, string>();

#if UNITY_STANDALONE_WIN
            framWorkConfig = Application.streamingAssetsPath;
#elif UNITY_ANDROID
            pathConfig = Application.dataPath + "!assets";
#elif UNITY_EDITOR_WIN
            pathConfig = Application.streamingAssetsPath;
#endif
            framWorkConfig += "/GSHFrameWork.xml";

            string[] GetNeedXmlContent(XmlNode rootNode, string nodeName)
            {
                string[] checkContent = { "Xml所有指定节点获取失败" };
                if (rootNode == null)
                    return checkContent;
                XmlNodeList xmlNodes = rootNode.SelectNodes(nodeName);
                string[] rightContents = new string[xmlNodes == null ? 0 : xmlNodes.Count];
                for (int i = 0; i < xmlNodes.Count; i++)
                {
                    rightContents[i] = xmlNodes[i]?.InnerText;
                }
                return rightContents.Length > 0 ? rightContents : checkContent;
            }


            string[] configFullNames = FrameWorkXmlReadTool.Single.GetTargetNodeAllContent(framWorkConfig, "Root", "ConfigFullName", GetNeedXmlContent);

            for (uint i = (uint)ConfigEnumType.NoneConfig; i < (uint)ConfigEnumType.Max; i++)
            {
                if (i >= configFullNames.Length)
                    break;

                otherConfig.Add((ConfigEnumType)i, Application.streamingAssetsPath + "/" + configFullNames[i]);
            }
        }

        public string GetTargetConfigFullPath(ConfigEnumType configEnumType)
        {

            return otherConfig.ContainsKey(configEnumType) ? otherConfig[configEnumType] : "配置表路径获取失败";
        }


        public override void Dispose()
        {
            base.Dispose();
            otherConfig.Clear();
            otherConfig = null;
        }
    }
}