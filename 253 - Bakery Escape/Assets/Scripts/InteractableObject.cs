using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    public string messageOnClick;
    private TextMeshProUGUI outputTextBox;
    public GameObject feedbackUI;
    public Animator objAnimator;
    public bool anim1Bool = false;
    public Material glowMaterial;

    // Start is called before the first frame update
    void Start()
    {
        outputTextBox = GameObject.FindGameObjectWithTag("outputTextBox").GetComponent<TextMeshProUGUI>();
        
        if(feedbackUI != null)
        {
            feedbackUI.SetActive(false);
        }
        
        
        //glowMaterial.SetFloat
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " has been clicked");
        outputTextBox.text = messageOnClick;

        //if (feedbackUI != null)
        //{
        //    feedbackUI.SetActive(true);
        //    Cursor.lockState = CursorLockMode.None;

        //}
        //objAnimator.SetBool("anim1Bool", true);
        //if (objAnimator != null)
        //{
        //    objAnimator.SetBool("anim1Bool", true);
        //}
    }

    private void OnMouseOver()
    {
        Debug.Log("This object is interactable");
        //hoverLight.intensity = 2f;

        if(Input.GetKey(KeyCode.Space))
        {
            if(feedbackUI != null)
            {
                feedbackUI.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    private void OnMouseExit()
    {
       //hoverLight.intensity = 0f;
    }

}
