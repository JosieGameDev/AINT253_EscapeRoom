using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUMBWAITER : MonoBehaviour
{
    public GameObject cake;
    public Recipe recipe;
    public DialogueTrigger winDialogue;
    public DialogueTrigger loseDialogue;

    public AudioSource recordScratch;
    public MusicManager musicManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(cake.activeSelf == true)
            {
                musicManager.pauseMusic();
                recordScratch.Play();
                musicManager.switchToJudgeMusic();
                Debug.Log("cake sent up");
                if(recipe.compareWholeRecipe() == true)
                {
                    winDialogue.triggerDialogue();
                }
                else
                {
                    loseDialogue.triggerDialogue();
                }
            }
            else
            {
                Debug.Log("Nothing sent");
            }
        }
    }
}
