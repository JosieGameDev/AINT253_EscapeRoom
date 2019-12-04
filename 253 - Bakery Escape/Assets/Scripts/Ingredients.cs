using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ingredients : MonoBehaviour
{
    public string ingredientName;
    public string measurementType; // eg cups, grams, units
    public int maxNumber;
    public int minNumber;

    public int recipeAmountNeeded;

    public Ingredients(string name, int quantity)
    {
        this.ingredientName = name;
        this.recipeAmountNeeded = quantity;
    }
    public int getAmount()
    {
        return this.recipeAmountNeeded;
    }

    public void setAmount(int newAmount )
    {
        this.recipeAmountNeeded = newAmount;
    }

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
}
