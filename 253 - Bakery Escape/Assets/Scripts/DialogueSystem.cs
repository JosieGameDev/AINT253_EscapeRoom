using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public Queue<string> sentences;
    public DialogueTrigger openingDialogueTrigger;
    public TextMeshProUGUI dialogueTextBox;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        openingDialogueTrigger.triggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && dialogueTextBox.isActiveAndEnabled)
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
            return;
        }

        string currentSentence = sentences.Dequeue();
        dialogueTextBox.text = currentSentence;
    }
}
