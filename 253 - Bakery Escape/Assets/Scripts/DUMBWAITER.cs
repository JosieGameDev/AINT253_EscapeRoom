﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUMBWAITER : MonoBehaviour
{
    public GameObject cake;
    public Recipe recipe;
    public DialogueTrigger winDialogue;
    public DialogueTrigger loseDialogue;
    public bool GameWon = false;
    public bool GameLost = false;
    public GameObject dialogueBox;

    public AudioSource recordScratch;
    public MusicManager musicManager;
    public GameManager gameManager;
    public tIMER timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameWon && dialogueBox.activeSelf == false )
        {
            StartCoroutine("winGame");
        }

        if (GameLost && dialogueBox.activeSelf == false)
        {
            loseRestartMusic();
        }
    }

     IEnumerator winGame()
    {
        yield return new WaitForSeconds(1);
        gameManager.winScreen();
    }

    private void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(cake.activeSelf == true)
            {
                timer.pauseTimer();
                musicManager.pauseMusic();
                recordScratch.Play();
                musicManager.switchToJudgeMusic();
                Debug.Log("cake sent up");
                if(recipe.compareWholeRecipe() == true)
                {
                    winDialogue.triggerDialogue();
                    GameWon = true;
                    
                }
                else
                {
                    timer.restartTimer();
                    loseDialogue.triggerDialogue();
                    GameLost = true;
                }
            }
            else
            {
                Debug.Log("Nothing sent");
            }
        }
    }

    public void loseRestartMusic()
    {
        GameLost = false;
        musicManager.switchToMusic2();
    }
}
