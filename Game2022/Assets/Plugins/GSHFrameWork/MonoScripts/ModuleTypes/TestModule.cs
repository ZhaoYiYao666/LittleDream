using GSHFrameWork.Abstract;
using GSHFrameWork.Global;
using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace GSHFrameWork.RealizeModule
{
    class TestModule : MonoModule, ITestModule
    {


        public override void AwakeModule()
        {


            Debug.LogError("AwakeModule");
        }

        public override void DestoryModule()
        {
            Debug.LogError("DestoryModule");

        }

        public override void FixedUpdateModule()
        {

            Debug.LogError("FixedUpdateModule");

        }

        public override void LateUpdateModule()
        {
            Debug.LogError("LateUpdateModule");

        }

        public override void StartModule()
        {
            Debug.LogError("StartModule");

        }

        public void Test()
        {
            GlobalVariableMgr.debugTool.ColorLog("green", "的点点滴滴", GetType());
        }

        public override void UpdateModule()
        {
            Debug.LogError("UpdateModule");

        }
    }
}
