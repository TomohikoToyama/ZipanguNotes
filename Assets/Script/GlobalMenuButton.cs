using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMenuButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    //ボタンを押したときの処理
    public void OnClick()
    {
        if (GameStateManager.Instance.getSceneName() != transform.name)
        {
           
                    Debug.Log(transform.name);
                    GameStateManager.Instance.ChangeScene(transform.name);
         }
    }
}
