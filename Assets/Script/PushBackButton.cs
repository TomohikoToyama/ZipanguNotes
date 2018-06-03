using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackButton : MonoBehaviour {
    //ボタンを押したときの処理
    public void OnClick()
    {
        //
        Debug.Log("バックボタン");
        if (GameStateManager.Instance.GetCurrentSceneName() == "Live")
        {
            GameStateManager.Instance.ChangeScene("Home");
        }
        

        else{
            Debug.Log("バックシーン");
            GameStateManager.Instance.BackScene();
        }
     }
}
