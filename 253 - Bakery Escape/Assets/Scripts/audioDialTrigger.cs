using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class audioDialTrigger : MonoBehaviour
{

    public string dialogueToTriggerOn;
    public AudioSource soundEffect;
    public TextMeshProUGUI dialogueText;
    public bool played = false;

    private void Update()
    {
        if(dialogueText.text == dialogueToTriggerOn && !played)
        {
            soundEffect.Play();
            played = true;
        }
    }
}
