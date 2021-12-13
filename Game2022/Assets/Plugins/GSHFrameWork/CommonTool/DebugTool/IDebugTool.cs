using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Interface
{
    public interface IDebugTool
    {
        /// <summary>
        /// 色彩日志
        /// </summary>
        /// <param name="color">颜色值</param>
        /// <param name="content">错误内容</param>
        /// <param name="type">脚本类型</param>
        public void ColorLog(string color, string content, Type type = null);

        /// <summary>
        /// 色彩错误
        /// </summary>
        /// <param name="color">颜色值</param>
        /// <param name="content">错误内容</param>
        /// <param name="type">脚本类型</param>
        public void ColorLogError(string color, string content, Type type = null);

        /// <summary>
        /// 色彩警告
        /// </summary>
        /// <param name="color">颜色值</param>
        /// <param name="content">警告内容</param>
        /// <param name="type">脚本类型</param>
        public void ColorLogWaring(string color, string content, Type type = null);

    }
}
