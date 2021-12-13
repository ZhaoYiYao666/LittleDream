using GSHFrameWork.Interface;

using System;

using UnityEngine;
/// <summary>
/// 工具空间
/// </summary>
namespace GSHFrameWork.SingleTool
{
    internal class DebugTool : SingleClass<DebugTool>, IDebugTool
    {
        /// <summary>
        /// Debug工具初始化
        /// </summary>
        public override void Init()
        {
            base.Init();

        }

        public void ColorLog(string color, string content, Type type)
        {
            Debug.Log($"<color={color}> {content} from {type.Name}</color>");
        }

        public void ColorLogError(string color, string content, Type type)
        {
            Debug.LogError($"<color={color}> {content} from {type.Name}</color>");
        }

        public void ColorLogWaring(string color, string content, Type type)
        {
            Debug.LogWarning($"<color={color}> {content} from {type.Name}</color>");
        }
    }
}
