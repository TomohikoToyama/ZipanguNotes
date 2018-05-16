using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Onclick()
    {
        //現在のシーンを取得
        GameStateManager.Instance.GetCurrentSceneName();

        //Yesボタン押した場合
        if(transform.name != null && transform.name == "Yes")
        {

        }

        //Noボタン押した場合
        if (transform.name != null && transform.name == "No")
        {

        }

    }
}
