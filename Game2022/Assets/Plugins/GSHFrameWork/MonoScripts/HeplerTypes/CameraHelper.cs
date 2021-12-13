using GSHFrameWork.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSHFrameWork.MonoScripts.HeplerTypes
{
    class CameraHelper : IModuleHelper
    {
        private IMonoModule module;

        public IMonoModule MonoModule { get => module; set => module = value; }

        public void Dispose()
        {
            module = null;
        }

        public void InitModuleHelper()
        {
            throw new NotImplementedException();
        }
    }
}
