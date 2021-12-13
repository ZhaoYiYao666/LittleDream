using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace GSHFrameWork.Interface
{
    /// <summary>
    /// 模块接口
    /// </summary>
    public interface IMonoModule
    {
        /// <summary>
        /// 模块助手
        /// </summary>
        IModuleHelper MoudleHelper { get; set; }

        /// <summary>
        /// 模块唤醒
        /// Tip:数据初始化在此位置进行
        /// </summary>
        void AwakeModule();


        /// <summary>
        /// 模块初始帧
        /// Tip:组件初始化在此位置进行
        /// </summary>
        void StartModule();

        /// <summary>
        /// 模块帧执行
        /// Tip:帧刷新执行在此位置进行
        /// </summary>
        void UpdateModule();

        /// <summary>
        /// 模块物理帧
        /// Tip:物理固定帧刷新在此进行
        /// </summary>
        void FixedUpdateModule();

        /// <summary>
        /// 模块末尾帧
        /// Tip:帧末尾处理刷新在此进行
        /// </summary>
        void LateUpdateModule();

        /// <summary>
        /// 模块卸载
        /// Tip:模块卸载引用在此进行
        /// </summary>
        void DestoryModule();

    }




}


