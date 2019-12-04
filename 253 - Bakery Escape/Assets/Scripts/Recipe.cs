using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    

    public int butterAmount;
    public int butterNeeded;
   

    // Start is called before the first frame update
    void Start()
    {

        
    }

    public bool compareWholeRecipe()
    {
        bool isMatch = true;
        if(!compareIngredientAmount(butterAmount, butterNeeded))
        {
            isMatch = false;
        }


        return isMatch;
    }

    public bool compareIngredientAmount(int expectedAmount, int realAmount)
    {
        if(expectedAmount == realAmount)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
