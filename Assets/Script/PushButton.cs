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

        //再開ボタン押した場合
        if(transform.name != null && transform.name == "Resume")
        {

        }

        //中断ボタン押した場合
        if (transform.name != null && transform.name == "Giveup")
        {
            //諸々の処理

            //楽曲選択シーンに遷移
            
            sceneName = "Live";
            StageManager.Instance.fPause = false;
            GameStateManager.Instance.ChangeScene(sceneName);
        }

    }
}
