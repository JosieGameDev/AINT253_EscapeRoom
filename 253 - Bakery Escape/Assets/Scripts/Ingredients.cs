using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Ingredients
{
    public string ingredientName;
    public string measurementType; // eg cups, grams, units
    public int maxNumber;
    public int minNumber;

    public int amount;

    public Ingredients(string name, int quantity)
    {
        this.ingredientName = name;
        this.amount = quantity;
    }
    public int getAmount()
    {
        return this.amount;
    }

    public void setAmount(int newAmount )
    {
        this.amount = newAmount;
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
