
using GSHFrameWork.Enum;
using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using UnityEngine;

namespace GSHFrameWork.SingleTool
{
    /// <summary>
    /// 程序集工具
    /// </summary>
    internal class FrameWorkAssemblyTool : SingleClass<FrameWorkAssemblyTool>, IFrameWorkAssemblyTool
    {
        /// <summary>
        /// 配置表中模块程序集字典
        /// </summary>
        Dictionary<string, Assembly> assemblies;

        /// <summary>
        /// 配置表中Mono模块字典
        /// </summary>
        Dictionary<string, Type> monoModules;

        /// <summary>
        /// 配置表中单例模块字典
        /// </summary>
        Dictionary<string, Type> singleModules;

        /// <summary>
        /// 配置表路径
        /// </summary>
        private string pathConfig;

        /// <summary>
        /// 初始化
        /// </summary>
        public override void Init()
        {
            pathConfig = FrameWorkConfigTool.Single.FramWorkConfigFullPath;

            //读取配置表
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

            string[] assembliesTemp = FrameWorkXmlReadTool.Single.GetTargetNodeAllContent(pathConfig, "Root", "Assembly", GetNeedXmlContent);
            string[] monoTypes = FrameWorkXmlReadTool.Single.GetTargetNodeAllContent(pathConfig, "Root", "IMonoModule", GetNeedXmlContent);
            //string[] singleTypes = FrameWorkXmlReadTool.Single.GetTargetNodeAllContent(pathConfig, "Root", "ISingModule", GetNeedXmlContent);

            //是否存在
            bool IsExites(string name, string[] arr)
            {
                foreach (var item in arr)
                {
                    if (!item.Contains(name))
                        continue;

                    return true;
                }
                return false;
            }


            assemblies = new Dictionary<string, Assembly>();
            monoModules = new Dictionary<string, Type>();
            singleModules = new Dictionary<string, Type>();


            Assembly[] systemAssemblies = AppDomain.CurrentDomain.GetAssemblies();

            for (int i = 0; i < systemAssemblies.Length; i++)
            {
                Assembly assembly = systemAssemblies[i];
                AssemblyName assemblyName = assembly.GetName();

                if (!IsExites(assemblyName?.Name, assembliesTemp))
                    continue;

                //框架模块程序集
                assemblies.Add(assemblyName?.Name, assembly);

                //foreach (var item in assembly.GetTypes())
                //{
                //    if (!IsExites(item?.Name, singleTypes))
                //        continue;
                //    //获取所有单例模块
                //    singleModules.Add(item.Name, item);
                //}

                foreach (var item in assembly.GetTypes())
                {
                    if (!IsExites(item?.Name, monoTypes))
                        continue;
                    //获取所有Mono模块
                    monoModules.Add(item.Name, item);
                }
            }
        }

        public Dictionary<string, T> GetTargetTypeDictionary<T>(ModuleEnumType moduleEnumType)
        {
            Dictionary<string, T> tempDic = null;

            switch (moduleEnumType)
            {
                case ModuleEnumType.IMonoModule:

                    tempDic = monoModules as Dictionary<string, T>;

                    break;
                case ModuleEnumType.ISingleModule:

                    tempDic = singleModules as Dictionary<string, T>;

                    break;
                default:
                    break;
            }
            return tempDic;
        }

        public Type GetTargetType(string typeName, ModuleEnumType moduleEnumType)
        {
            Type type = null;
            switch (moduleEnumType)
            {
                case ModuleEnumType.IMonoModule:
                    if (monoModules.ContainsKey(typeName))
                        type = monoModules[typeName];

                    break;
                case ModuleEnumType.ISingleModule:
                    if (singleModules.ContainsKey(typeName))
                        type = singleModules[typeName];
                    break;
                default:
                    break;
            }
            return type;
        }

        public Type GetTargetType<T>(ModuleEnumType moduleEnumType) where T : IMonoModule, ISingleModule
        {
            Type type = null;
            T t = default;
            string typeName = t.ToString();
            switch (moduleEnumType)
            {
                case ModuleEnumType.IMonoModule:
                    if (monoModules.ContainsKey(typeName))
                        type = monoModules[typeName];
                    break;
                case ModuleEnumType.ISingleModule:
                    if (singleModules.ContainsKey(typeName))
                        type = monoModules[typeName];
                    break;
                default:
                    break;
            }
            return type;
        }
        public Type GetTargetType<T>()
        {
            Type type = null;
            Type t = typeof(T);
            string typeName = t.ToString();

            if (monoModules.ContainsKey(typeName))
                type = monoModules[typeName];

            if (singleModules.ContainsKey(typeName))
                type = monoModules[typeName];

            return type;
        }

        public override void Dispose()
        {
            base.Dispose();
            DebugTool.Single.ColorLog("", "单例程序集工具释放", GetType());

        }

    }
}
