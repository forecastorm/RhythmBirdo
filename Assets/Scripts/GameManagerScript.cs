using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class GameManagerScript : MonoBehaviour
{


    public PlayableDirector playableDirector;

    public GameObject completLevelUI;

    public GameObject birddo;

  

    private int zeroGravity =0;


   public void EndGame()
    {
        playableDirector.Stop();
        birddo.GetComponent<Rigidbody2D>().gravityScale = zeroGravity;

    }


    public void winLevel()
    {
        Debug.Log("level won");

        FindObjectOfType<AudioManagerScript>().Play("winning_sound");

        playableDirector.Stop();
       
        birddo.GetComponent<Rigidbody2D>().gravityScale = zeroGravity;
       




    }




 
}
