using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DUMBWAITER : MonoBehaviour
{
    public GameObject cake;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            if(cake.activeSelf == true)
            {
                Debug.Log("cake sent up");
            }
            else
            {
                Debug.Log("Nothing sent");
            }
        }
    }
}
