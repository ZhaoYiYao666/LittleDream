using GSHFrameWork.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Interface
{
    public interface IFrameWorkAssemblyTool
    {
        /// <summary>
        /// 获取指定类型模块字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Dictionary<string, T> GetTargetTypeDictionary<T>(ModuleEnumType moduleEnumType);

        /// <summary>
        /// 获取目标类型
        /// </summary>
        /// <param name="typeName">类型名称</param>
        /// <param name="moduleEnumType"></param>
        /// <returns></returns>
        Type GetTargetType(string typeName, ModuleEnumType moduleEnumType);


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="moduleEnumType"></param>
        /// <returns></returns>
        Type GetTargetType<T>(ModuleEnumType moduleEnumType) where T : IMonoModule, ISingleModule;


    }
}
