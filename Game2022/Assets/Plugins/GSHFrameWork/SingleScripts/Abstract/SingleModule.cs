using GSHFrameWork.Interface;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Abstract
{
    /// <summary>
    /// 抽象单例模块
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class SingleModule<T> : ISingleModule where T : ISingleModule, new()
    {
        private T t;

        public T Instance { get => t; set => t = value; }

        /// <summary>
        /// 处理
        /// </summary>
        public void Dispose()
        {
            t = default(T);
        }

        public abstract void Init();

    }
}
