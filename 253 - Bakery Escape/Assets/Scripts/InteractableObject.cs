using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    public string messageOnClick;
    public TextMeshProUGUI outputTextBox;
    private GameObject outputImage;
    public GameObject feedbackUI;
    
    private GameObject player;

    public GameObject popUpGO;
    public popUps popUpSystem;

    public GameObject HoverLabel;

    public bool isIngredient;
    public recipeAddIngredients ingredientDetailInPanel;

    public noteSystem E_noteSystem;

    //audio
    public AudioSource pickUpAudio;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        popUpSystem = GameObject.FindGameObjectWithTag("Canvas").GetComponent<popUps>();

        //outputTextBox = GameObject.FindGameObjectWithTag("outputTextBox").GetComponent<TextMeshProUGUI>();
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
            if(E_noteSystem != null)
            {
                popUpSystem.showInteractPrompt();
            }

            if (isIngredient)
            {
                popUpSystem.showPickUpPrompt();
            }

            if(this.gameObject.name == "POSTER")
            {
                this.gameObject.GetComponent<posterRip>().destroyPoster();
            }
        }
        
    }

    
    private void OnMouseEnter()
    {
        if(Vector3.Distance(
            player.
            transform.position, this.gameObject.transform.position) < 8 && outputImage != null)
        {
            Debug.Log("This object is interactable");

            popUpSystem.showClickPrompt();
            if(HoverLabel != null)
            {
                HoverLabel.SetActive(true);
            }

            
        }
    }

    private void OnMouseOver()
    {
        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 &&  outputTextBox.text == "")
        {
            popUpSystem.showClickPrompt();
        }

        if (Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 && Input.GetKeyDown(KeyCode.E))
        {
            if(E_noteSystem != null)
            {
                if(E_noteSystem.isActiveAndEnabled)
                {
                    E_noteSystem.closeNote();
                }
                else
                {
                    if(E_noteSystem.GetComponent<AddIngredient>() != null)
                    {
                        E_noteSystem.GetComponent<AddIngredient>().updateIngredientToAdd(gameObject.name);
                    }

                    E_noteSystem.openNote();
                    popUpSystem.hidePrompts();
                }
                
            }
            else if (isIngredient)
            {
                popUpSystem.showPickUpPrompt();
            }
            
        }
        if(isIngredient)
        {
            if(Vector3.Distance(player.transform.position, this.gameObject.transform.position) < 8 && Input.GetKeyDown(KeyCode.Q))
            {
                // collect it!
                ingredientDetailInPanel.hasBeenFound();
                pickUpAudio.Play();
                Destroy(this.gameObject);
            }
        }

    }

    private void OnMouseExit()
    {
        popUpSystem.hidePrompts();
        outputTextBox.text = "";
        outputImage.SetActive(false);
        if (HoverLabel != null)
        {
            HoverLabel.SetActive(false);
        }
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
