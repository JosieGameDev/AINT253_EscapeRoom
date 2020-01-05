using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class cakeMix : MonoBehaviour
{
    public Recipe theRecipe;
    public PanelManage panelManager;
    public GameObject cake;
    public DialogueTrigger note3Trigger;

    //baking
    public Button bakeBtn;
    public recipeAddIngredients[] allIngredients;

    // Start is called before the first frame update
    void Start()
    {
        bakeBtn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(allIngsFound())
        {
            if(bakeBtn!= null)
            {
                bakeBtn.interactable = true;
            }
            
        }
    }

    private void OnMouseDown()
    {
        
    }

    public void updateButtons()
    {
        foreach (recipeAddIngredients recipe in allIngredients)
        {
            if(recipe.isFound)
            {
                recipe.icon.sprite = recipe.ingredientIcon;
                recipe.ingredientNameLabel.text = recipe.IngredientName;
                foreach (Button b in recipe.buttons)
                {
                    b.interactable = true;
                }
            }
            
        }
    }

    public bool allIngsFound()
    {
        foreach(recipeAddIngredients recipe in allIngredients)
        {
            if (recipe.isFound == false)
            {
                return false;
            }
        }
        return true;
    }

    public void CookMix()
    {
        panelManager.togglePanel();

        note3Trigger.triggerDialogue();
        cake.SetActive(true);

    }
}
