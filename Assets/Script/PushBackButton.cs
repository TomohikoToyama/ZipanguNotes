using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBackButton : MonoBehaviour {
    //ボタンを押したときの処理
    public void OnClick()
    {
        GameStateManager.Instance.BackScene();

     }
}
