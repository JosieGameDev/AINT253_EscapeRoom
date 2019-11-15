using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteractableObject : MonoBehaviour
{
    public string messageOnClick;
    public GameObject feedbackUI;
    private Animator objAnimator;
    public Animation onClickAnim;
    public Material glowMaterial;

    // Start is called before the first frame update
    void Start()
    {
        feedbackUI.SetActive(false);
        objAnimator = this.gameObject.GetComponent<Animator>();
        //glowMaterial.SetFloat
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(this.gameObject.name + " has been clicked");
        Debug.Log(messageOnClick);
        if (feedbackUI != null)
        {
            feedbackUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

        }

        if(onClickAnim != null)
        {
            objAnimator.Play("");
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("This object is interactable");
        hoverLight.intensity = 2f;
    }

    private void OnMouseExit()
    {
        hoverLight.intensity = 0f;
    }

}
