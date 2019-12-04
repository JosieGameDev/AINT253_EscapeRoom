using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddIngredient : MonoBehaviour
{
    // object which handles the adding of ingredients 

    //vars
    //private Ingredients thisIngredient;
    public string ingredientName;
    
    public TMP_Dropdown amountDropdown;
    public Recipe theRecipe;
    public TMP_Text ingredientLabel;

    // Start is called before the first frame update
    void Start()
    {
        //thisIngredient = new Ingredients(ingredientName, 0);
        ingredientLabel.text = ingredientName;
    }

    public void updateQuantity()
    {
        if(ingredientLabel.text == "butter")
        {
            theRecipe.butterAmount = int.Parse(amountDropdown.captionText.text);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
