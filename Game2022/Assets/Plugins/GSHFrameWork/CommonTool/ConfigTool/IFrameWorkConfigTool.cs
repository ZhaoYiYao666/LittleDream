using GSHFrameWork.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Interface
{
    public interface IFrameWorkConfigTool
    {
        /// <summary>
        /// 获取枚举目标配置表绝对路径
        /// </summary>
        /// <param name="configEnumType">配置表枚举类型</param>
        /// <returns>配置表全路径字符串</returns>
        string GetTargetConfigFullPath(ConfigEnumType configEnumType);

        /// <summary>
        /// 卸载
        /// </summary>
        void Dispose();
    }
}
