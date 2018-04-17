using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    float distance = 1000;
    [SerializeField]
    string currentScene = "Title"; //現在のシーン.
    [SerializeField]
    string objectName =""; //タップしたオブジェクト名.
    Vector3 tapPosition;

    // Use this for initialization
    void Start() {
        DontDestroyOnLoad(this);


    }

    // Update is called once per frame
    void Update() {



        if (Input.GetMouseButtonDown(0))
        {
            Vector2 tapPoint  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collition2d  = Physics2D.OverlapPoint(tapPoint);
            if (collition2d)
            {
                RaycastHit2D hitObject = Physics2D.Raycast(tapPoint, -Vector2.up);
                if (hitObject)
                {
                    Debug.Log("hit object is " + hitObject.collider.gameObject.name);
                }
            }
        }
    }

    //シーン遷移処理(仮)
    public void ChangeScene() {

        //タイトル画面でボタン以外タップした場合
        if (currentScene == "Title") { 
        currentScene = "Home";
        SceneManager.LoadScene("Home");
        }
        if( currentScene == "Home")
        {
            /*
             * 
             * 
             *
             */

            
           

                if(objectName == "Home")

                if (objectName == "Live")
                        SceneManager.LoadScene("Live");

                if (objectName == "Other")
                    SceneManager.LoadScene("Other");


        }

    }
}
