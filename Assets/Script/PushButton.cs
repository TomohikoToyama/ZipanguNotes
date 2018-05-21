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

    public void Onclick()
    {
        string sceneName = GameStateManager.Instance.GetCurrentSceneName();
        //現在のシーンを取得
        if (sceneName == "Live")
        {
            GameStateManager.Instance.ChangeScene(sceneName);
        }

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
