using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningTrigger : MonoBehaviour
{

    public GameManagerScript gameManagerScript;
    private bool hasWon;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!hasWon)
        {
            hasWon = true;
            gameManagerScript.winLevel();
        }

       
        
    }

}
