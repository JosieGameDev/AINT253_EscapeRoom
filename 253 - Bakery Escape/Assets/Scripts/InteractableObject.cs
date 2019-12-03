using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    public string messageOnClick;
    private TextMeshProUGUI outputTextBox;
    private GameObject outputImage;
    public GameObject feedbackUI;
    public Animator objAnimator;
    public bool anim1Bool = false;
    public Material glowMaterial;
    private GameObject player;

    public GameObject popUpGO;
    public popUps popUpSystem;

    
    public noteSystem noteSystem;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        popUpSystem = GameObject.FindGameObjectWithTag("Canvas").GetComponent<popUps>();

        outputTextBox = GameObject.FindGameObjectWithTag("outputTextBox").GetComponent<TextMeshProUGUI>();
        outputImage = GameObject.FindGameObjectWithTag("outputImage");
        
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
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8)
        {
            outputImage.SetActive(true);
            popUpSystem.hidePrompts();
            outputTextBox.text = messageOnClick;

        }
        
    }

    
    private void OnMouseEnter()
    {
        if(Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 && outputImage != null)
        {
            Debug.Log("This object is interactable");

            popUpSystem.showClickPrompt();
        }
    }

    private void OnMouseOver()
    {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 && outputTextBox.text == "")
        {
            popUpSystem.showClickPrompt();
        }

        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 && Input.GetKeyDown(KeyCode.E))
        {
            if(noteSystem != null)
            {
                if(noteSystem.isActiveAndEnabled)
                {
                    noteSystem.closeNote();
                }
                else
                {
                    noteSystem.openNote();
                }
                
            }
            
        }

    }

    private void OnMouseExit()
    {
        popUpSystem.hidePrompts();
        outputTextBox.text = "";
        outputImage.SetActive(false);
    }

    private void showPopUp(GameObject popUp)
    {
        popUp.SetActive(true);
    }
    private void hidePopUp(GameObject popUp)
    {
        popUp.SetActive(false);
    }

}
