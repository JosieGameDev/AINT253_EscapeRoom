using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject music1;
    public GameObject music2;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            switchToMusic2();
        }
    }
    public void switchToMusic2()
    {
        music1.SetActive(false);
        music2.SetActive(true);
    }


}
