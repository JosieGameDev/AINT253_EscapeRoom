using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUps : MonoBehaviour
{
    //vars
    public GameObject clickToExaminePopIp;
    public GameObject pressToInteract;

    public GameObject[] popUpArray;

    // Start is called before the first frame update
    void Start()
    {
        popUpArray = new GameObject[] { clickToExaminePopIp, pressToInteract };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hidePrompts()
    {
        foreach (GameObject g in popUpArray)
        {
            g.SetActive(false);
        }
    }

    public void showClickPrompt()
    {
        hidePrompts();

        clickToExaminePopIp.SetActive(true);
    }

    

    public void showInteractPrompt()
    {
        hidePrompts();

        pressToInteract.SetActive(true);
    }
}
