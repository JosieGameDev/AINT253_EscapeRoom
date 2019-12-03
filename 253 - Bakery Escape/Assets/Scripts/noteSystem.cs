using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;


public class noteSystem : MonoBehaviour
{

    public GameObject note;
    public FirstPersonController firstPersContr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openNote()
    {
        this.gameObject.SetActive(true);
        firstPersContr.unlockCursor();
    }

    public void closeNote()
    {
        note.SetActive(false);
        firstPersContr.lockCursor();
    }
}
