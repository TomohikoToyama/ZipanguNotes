using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPauseButton : MonoBehaviour {

    [SerializeField]
    GameObject pausePopUp;

   // [SerializeField]
  //  GameObject fadeGuard;

    public void OnClick()
    {
        if (StageManager.Instance.fPause == false)
        {
            StageManager.Instance.fPause = true;
            pausePopUp.SetActive(true);
     //       fadeGuard.SetActive(true);

        }

    }

}
