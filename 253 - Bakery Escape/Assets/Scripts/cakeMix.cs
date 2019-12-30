using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakeMix : MonoBehaviour
{
    public Recipe theRecipe;
    public PanelManage panelManager;
    public GameObject cake;
    public DialogueTrigger note3Trigger;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
    }

    public void CookMix()
    {
        panelManager.togglePanel();
        if(theRecipe.compareWholeRecipe() == true)
        {
            Debug.Log("made a perfect cake");
            note3Trigger.triggerDialogue();
            cake.SetActive(true);
            
        }
        else
        {
            Debug.Log("uh-oh");
        }
        
    }
}
