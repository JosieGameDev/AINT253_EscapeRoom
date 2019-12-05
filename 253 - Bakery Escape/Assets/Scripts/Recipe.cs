using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    

    public int butterAmount;
    public int butterNeeded;

    public Ingredients[] recipeIngredients;
    public Ingredients[] usersIngredients;
   

    // Start is called before the first frame update
    void Start()
    {
        recipeIngredients = new Ingredients[5];
        recipeIngredients[0] = new Ingredients("butter", 3);
        recipeIngredients[1] = new Ingredients("sugar", 2);
        recipeIngredients[2] = new Ingredients("eggs", 2);
        recipeIngredients[3] = new Ingredients("flour", 2);
        recipeIngredients[4] = new Ingredients("vanilla", 2);

        usersIngredients = new Ingredients[5];
        usersIngredients[0] = new Ingredients("butter", 0);
        usersIngredients[1] = new Ingredients("sugar",0);
        usersIngredients[2] = new Ingredients("eggs", 0);
        usersIngredients[3] = new Ingredients("flour", 0);
        usersIngredients[4] = new Ingredients("vanilla", 0);
        
    }

    public void updateUserIngredients(string name, int newAmount)
    {
        for (int i = 0; i < 4; i++)
        {
            if(usersIngredients[i].ingredientName == name)
            {
                usersIngredients[i].setAmount(newAmount);
            }
        }
    }

    public bool compareWholeRecipe()
    {
        bool theyMatch = true;
        for (int i = 0; i < 4; i++)
        {
            if(usersIngredients[i].amount != recipeIngredients[i].amount)
            {
                theyMatch = false;
            }
        }

        return theyMatch;
    }

    public bool compareIngredientAmount(int expectedAmount, int realAmount)
    {
        bool theyMatch = true;

        return theyMatch;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
