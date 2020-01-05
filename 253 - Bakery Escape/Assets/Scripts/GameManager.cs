using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;

public class GameManager : MonoBehaviour
{
    public FirstPersonController fpc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void loseScreen()
    {
        SceneManager.LoadScene("Lose");
    }

    public void winScreen()
    {
        fpc.unlockCursor();
        SceneManager.LoadScene("Win");

    }

    public void loadMenu()
    {
        fpc.unlockCursor();
        SceneManager.LoadScene("Menu");
    }
}
