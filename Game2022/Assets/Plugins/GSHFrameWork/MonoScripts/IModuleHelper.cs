using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Interface
{
    /// <summary>
    /// 模块助手
    /// </summary>
    public interface IModuleHelper : IDisposable
    {
        /// <summary>
        /// 模块
        /// </summary>
        IMonoModule MonoModule { get; set; }

        /// <summary>
        /// 初始化模块儿助手
        /// </summary>
        void InitModuleHelper();
    }
}
