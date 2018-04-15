using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    float distance = 200;
    [SerializeField]
    string currentScene = "Title"; //現在のシーン.
    string objectName =""; //タップしたオブジェクト名.
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        DontDestroyOnLoad(this);
    }

    //シーン遷移処理(仮)
    public void ChangeScene() {

        //タイトル画面でボタン以外タップした場合
        if (currentScene == "Title")
            currentScene = "Home";
            SceneManager.LoadScene("Home");

        if( currentScene == "Home")
        {
            /*
             * 
             * 
             *
             */

            
            // タップを取得
            if (Input.GetMouseButtonDown(0))
            {
                // タップ座標をrayに変換
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // Rayの当たったオブジェクトの情報を格納する
                RaycastHit hit = new RaycastHit();
                // オブジェクトにrayが当たった時
                if (Physics.Raycast(ray, out hit, distance))
                {
                    // rayが当たったオブジェクトの名前を取得
                    objectName = hit.collider.gameObject.name;
                    Debug.Log(objectName);
                }

                if(objectName == "Home")

                if (objectName == "Live")
                        SceneManager.LoadScene("Live");

                if (objectName == "Other")
                    SceneManager.LoadScene("Other");


            }
        }

    }
}
