
using GSHFrameWork.SingleTool;
using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Global
{

    /// <summary>
    /// 全局变量管理器 外部调用
    /// </summary>
    public static class GlobalVariableMgr
    {

        /// <summary>
        /// 单例工厂接口
        /// </summary>
        public static IFrameWorkFactoryTool SingleFactory => FrameWorkFactoryTool.Single;

        /// <summary>
        /// 单例
        /// </summary>
        public static IFrameWorkXmlReadTool SingleXmlReader => FrameWorkXmlReadTool.Single;


        public static IFrameWorkAssemblyTool frameWorkAssemblyTool => FrameWorkAssemblyTool.Single;

        public static IFrameWorkConfigTool frameWorkConfig => FrameWorkConfigTool.Single;


        public static IDebugTool debugTool => DebugTool.Single;

        public static void Test()
        {
            string name = frameWorkConfig.GetTargetConfigFullPath(Enum.ConfigEnumType.RoleConfig);
        }



        /// <summary>
        /// 卸载所有全局变量
        /// </summary>
        public static void Dispose()
        {

        }
    }
}
