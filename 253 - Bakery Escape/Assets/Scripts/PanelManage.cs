using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class PanelManage : MonoBehaviour
{
    // vars
    public string keyToTab;
    public GameObject panel;
    public FirstPersonController fpc;

    // Start is called before the first frame update
    void Start()
    {
        keyToTab = "X";
        togglePanel();
        togglePanel();
        togglePanel();
    }

    // Update is called once per frame
    void Update()
    {
        if (keyToTab == "X")
        {
            if(Input.GetKeyDown(KeyCode.X))
            {
                togglePanel();
            }
        }
    }

    public void togglePanel()
    {
        if (panel.activeSelf == true)
        {
            panel.SetActive(false);
            fpc.lockCursor();
            
        }
        else if (panel.activeSelf == false)
        {
            panel.SetActive(true);
            panel.GetComponent<cakeMix>().updateButtons();
            fpc.unlockCursor();
        }
    }
}
