using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Interface
{
    /// <summary>
    /// 单例模块接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISingleModule : IDisposable
    {
        /// <summary>
        /// 初始化
        /// </summary>
        void Init();

    }
}
