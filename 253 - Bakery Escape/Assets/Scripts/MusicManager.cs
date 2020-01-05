using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject music1;
    public GameObject music2;
    public GameObject music3;

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.M))
        //{
        //    switchToMusic2();
        //}
    }
    public void switchToMusic2()
    {
        music1.SetActive(false);
        music2.SetActive(true);
        music3.SetActive(false);
    }

    public void switchToJudgeMusic()
    {
        music1.SetActive(false);
        music2.SetActive(false);
        music3.SetActive(true);
    }

    public void pauseMusic()
    {
        music1.SetActive(false);
        music2.SetActive(false);
        music3.SetActive(false);
    }


}
