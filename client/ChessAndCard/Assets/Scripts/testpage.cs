﻿using System.Collections;
using System.Collections.Generic;
using UIFrameWork.UI;
using UnityEngine;

public class testpage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //初始化网络
        NetWriter.SetUrl("192.168.1.58:9001");
        Net.Instance.HeadFormater = new CustomHeadFormater();

        TTUIPage.ShowPage<UILoginPage>();
	}
	
}
