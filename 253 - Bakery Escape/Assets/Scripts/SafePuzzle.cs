﻿using System.Collections;
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
    public GameObject safeNote;
    public Animator safeAnimator;
    public GameObject recipeUI;
    public DialogueTrigger note2trigger;

    public GameObject timer;
    public MusicManager musicControl;
    
    
    


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
            safeAnimator.SetBool("anim1Bool", true);

            note2trigger.triggerDialogue();

            recipeUI.SetActive(true);
            
            gameObject.GetComponent<noteSystem>().closeNote();

            musicControl.switchToMusic2();
            timer.SetActive(true);
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
