using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using GSHFrameWork.Interface;
using GSHFrameWork.Enum;
using GSHFrameWork.SingleTool;
using GSHFrameWork.Global;

public class StartMono : MonoBehaviour
{

    Dictionary<Type, IMonoModule> monoModules = GlobalVariableMgr.SingleFactory.CreateInstancesDic<Type, IMonoModule>();


    private void Awake()
    {
        Debug debug = GlobalVariableMgr.SingleFactory.CreateInstance<Debug>();
        ITestModule test = GlobalVariableMgr.SingleFactory.CreateInstance<ITestModule>();
        test.Test();
        string s = GlobalVariableMgr.frameWorkConfig.GetTargetConfigFullPath(ConfigEnumType.ExpendConfig);
        //foreach (var item in monoModules)
        //{
        //    item.Value.AwakeModule();
        //}


        //DebugTool.Instance.ColorLog("red", "sss", GetType());
    }


    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in monoModules)
        {
            item.Value.StartModule();
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var item in monoModules)
        {
            item.Value.UpdateModule();
        }
    }

    private void FixedUpdate()
    {

        foreach (var item in monoModules)
        {
            item.Value.FixedUpdateModule();
        }
    }

    private void LateUpdate()
    {
        foreach (var item in monoModules)
        {
            item.Value.LateUpdateModule();
        }
    }







}
