using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    string currentScene = "Title"; //現在のシーン.
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    //シーン遷移処理
    public void ChangeScene() { 

        if( currentScene == "Title")
            SceneManager.LoadScene("Home");

    }
}
