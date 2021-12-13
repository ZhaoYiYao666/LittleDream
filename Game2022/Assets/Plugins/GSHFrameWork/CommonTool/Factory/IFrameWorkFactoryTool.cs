using System;
using System.Collections.Generic;

/// <summary>
/// 接口空间
/// </summary>
namespace GSHFrameWork.Interface
{
    /// <summary>
    /// 单例工厂接口
    /// </summary>
    public interface IFrameWorkFactoryTool
    {
        /// <summary>
        /// 创建任意类型的字典
        /// </summary>
        /// <typeparam name="Key"></typeparam>
        /// <typeparam name="Value"></typeparam>
        /// <returns></returns>
        Dictionary<Key, Value> CreateInstancesDic<Key, Value>();

        /// <summary>
        /// 泛型创建实例
        /// </summary>
        /// <typeparam name="T">指定类型</typeparam>
        /// <returns></returns>
        T CreateInstance<T>();

    }
}
