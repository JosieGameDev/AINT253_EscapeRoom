using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour
{
    public Queue<string> sentences;
    public DialogueTrigger openingDialogueTrigger;
    //public TextMeshProUGUI dialogueTextBox;
    public GameObject dialogueTextGO;
    public Text tempText;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        openingDialogueTrigger.triggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && dialogueTextGO.activeSelf)
        {
            displayNextSentence();
        }
    }

    public void beginDialogue(Dialogue dialogue)
    {
        Debug.Log("Running dialogue");

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
    }

    public void displayNextSentence()
    {
        if(sentences.Count == 0)
        {
            Debug.Log("end of dialogue");
            hideDialogueBox();
            return;
        }

        string currentSentence = sentences.Dequeue();
        
        tempText.text = currentSentence;
    }

    public void showDialogueBox()
    {
        dialogueTextGO.SetActive(true);
    }

    public void hideDialogueBox()
    {
        tempText.text = "...";
        dialogueTextGO.SetActive(false);
    }
}
