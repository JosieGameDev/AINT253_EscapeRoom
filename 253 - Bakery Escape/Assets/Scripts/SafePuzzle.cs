using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SafePuzzle : MonoBehaviour
{
    // vars

    //public InputField safeInput;
    //public InputField safeInput;
    public TMP_InputField safeInput;
    public int safePassword;
    
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void safePasswordCheck()
    {
        if(safeInput.text == safePassword.ToString())
        {
            unlockSafe();
            Debug.Log("you did it! safe open");
        }
        else
        {
            safeInput.text = "wrong answer";
           
            Debug.Log("wrong code entered");
        }
    }

    private void unlockSafe()
    {

    }
}
