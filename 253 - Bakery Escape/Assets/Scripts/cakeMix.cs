using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakeMix : MonoBehaviour
{
    public Recipe theRecipe;
    //public noteSystem showCurrentMix;
    public InteractableObject interaction;
    public GameObject cake;
    public GameObject check2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        interaction.messageOnClick = theRecipe.returnCurrentIngredientString();
    }

    private void OnMouseDown()
    {
        
    }

    public void CookMix()
    {
        if(theRecipe.compareWholeRecipe() == true)
        {
            Debug.Log("made a perfect cake");
            cake.SetActive(true);
            check2.SetActive(true);
        }
        else
        {
            Debug.Log("uh-oh");
        }
        
    }
}
