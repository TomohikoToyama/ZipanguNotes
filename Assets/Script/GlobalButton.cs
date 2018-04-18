using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //ボタンを押したときの処理
    public void GlobalBUttonClick()
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
