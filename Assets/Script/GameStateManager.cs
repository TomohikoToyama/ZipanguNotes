using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    float distance = 1000;
    [SerializeField]
    private string currentScene = "Title"; //現在のシーン.
    [SerializeField]
    private string beforeScene  = "Title";
    [SerializeField]
    string objectName =""; //タップしたオブジェクト名.
    Vector3 tapPosition;


    protected static GameStateManager instance;

    public static GameStateManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (GameStateManager)FindObjectOfType(typeof(GameStateManager));

                if (instance == null)
                {
                    Debug.LogError("GameStateManager Instance Error");
                }
            }

            return instance;
        }
    }

    // Use this for initialization
    void Start() {

        GameObject[] obj = GameObject.FindGameObjectsWithTag("GameStateManager");
        if (obj.Length > 1)
        {
            //既に存在してるなら削除
            Destroy(gameObject);
        }
        else
        {
            //管理マネージャーはシーン遷移では破棄させない
            DontDestroyOnLoad(gameObject);
        }

    }

    // Update is called once per frame
    void Update() {


            /*
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
        */
    }

    //シーン名取得
    public string GetCurrentSceneName()
    {
        return currentScene;

    }

    //前のシーン名取得
    public string GetBeforeSceneName()
    {
        return beforeScene;

    }

    //シーン遷移処理(仮)
    public void ChangeScene(string sceneName ) {

        //タイトル画面でボタン以外タップした場合

        if (currentScene == "Title") {
            beforeScene = currentScene;
            currentScene = "Home";
            SceneManager.LoadScene("Home");
        }

        //楽曲選択後の遷移
        if ( currentScene == "Live")
        {
            sceneName = "Stage";
            currentScene = sceneName;
            SceneManager.LoadScene(sceneName);
        }
        if ( currentScene == "Music")
        {
            currentScene = sceneName;
            SceneManager.LoadScene(sceneName);
        }

        
        else
        {
           
                beforeScene = currentScene;
            
            currentScene = sceneName;
            SceneManager.LoadScene(sceneName);
        }

    }

    //戻るボタンが押された時のシーン遷移
    public void BackScene()
    {
        if(currentScene == "Live")
        {
            currentScene = "Home";
            SceneManager.LoadScene(currentScene);
        }


        currentScene = beforeScene;
        SceneManager.LoadScene(currentScene);
    }
}
