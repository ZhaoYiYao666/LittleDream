using GSHFrameWork.Interface;


/// <summary>
/// 工具空间
/// </summary>
namespace GSHFrameWork.SingleTool
{
    /// <summary>
    /// 普通单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class SingleClass<T> : ISingClass where T : class, ISingClass, new()
    {
        static T t;

        /// <summary>
        /// 单例
        /// </summary>
        public static T Single
        {
            get
            {
                if (t == null)
                {
                    t = new T();
                    t.Init();
                }
                return t;
            }
            protected set
            {
                t = value;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void Init() { }

        public virtual void Dispose()
        {
            DebugTool.Single.ColorLog("green", "单例基类释放", GetType());
            Single = null;
        }
    }
}
