using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPauseButton : MonoBehaviour {


	public void OnClick()
    {
        if (StageManager.Instance.fPause == false)
        {
            StageManager.Instance.fPause = true;
            
        }

    }

}
