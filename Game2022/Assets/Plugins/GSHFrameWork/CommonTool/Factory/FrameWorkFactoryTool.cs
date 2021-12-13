
using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;

/// <summary>
/// 工具空间
/// </summary>
namespace GSHFrameWork.SingleTool
{
    /// <summary>
    /// 单例工厂
    /// </summary>
    internal class FrameWorkFactoryTool : SingleClass<FrameWorkFactoryTool>, IFrameWorkFactoryTool
    {
        /// <summary>
        /// 单例工厂初始化
        /// </summary>
        public override void Init()
        {

        }

        /// <summary>
        /// 销毁
        /// </summary>
        public override void Dispose()
        {
            base.Dispose();
        }


        Dictionary<Key, Value> IFrameWorkFactoryTool.CreateInstancesDic<Key, Value>()
        {
            Dictionary<Key, Value> keyValuePairs = new Dictionary<Key, Value>();

            return keyValuePairs;
        }

        /// <summary>
        /// 创建泛型实例
        /// </summary>
        /// <returns></returns>
        T IFrameWorkFactoryTool.CreateInstance<T>()
        {

            
            Type type = FrameWorkAssemblyTool.Single.GetTargetType<T>();
            return typeof(T) != null ? (T)Activator.CreateInstance(type) : default(T);
        }
    }
}
