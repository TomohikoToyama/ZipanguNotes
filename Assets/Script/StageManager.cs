using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour {

    //ライブがポーズ状態かのフラグ
    public bool fPause = false;

    protected static StageManager instance;

    public static StageManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (StageManager)FindObjectOfType(typeof(StageManager));

                if (instance == null)
                {
                    Debug.LogError("GameStateManager Instance Error");
                }
            }

            return instance;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
