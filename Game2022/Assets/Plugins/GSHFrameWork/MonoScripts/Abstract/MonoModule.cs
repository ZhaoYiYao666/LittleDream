using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.Abstract
{
    /// <summary>
    /// Mono模块脚本抽象类
    /// </summary>
    abstract class MonoModule : IMonoModule
    {
        private IModuleHelper moudleHelper;

        public IModuleHelper MoudleHelper { get => moudleHelper; set => moudleHelper = value; }

        public virtual void AwakeModule()
        {

        }
   
        public virtual void FixedUpdateModule()
        {

        }

        public virtual void LateUpdateModule()
        {

        }

        public virtual void StartModule()
        {

        }

        public virtual void UpdateModule()
        {

        }

        public virtual void DestoryModule()
        {

        }

    }
}
