﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    //ボタンを押したときの処理
    public void OnClick()
    {
        switch (transform.name)
        {
            case "Home":
                Debug.Log("ホーム");
                break;
            case "Live":
                Debug.Log("ライブ");
                break;
            case "Other":
                Debug.Log("アザー");
                break;
            default:
                break;
        }
    }
}
