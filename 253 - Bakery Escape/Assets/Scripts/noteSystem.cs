using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class noteSystem : MonoBehaviour
{

    public GameObject note;
    public 

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
    }

    public void closeNote()
    {
        note.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
