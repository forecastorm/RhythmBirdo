using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab1;
    //public GameObject platformPrefab2;
    public GameObject platformPrefab3;
    public GameObject platformPrefab3_bounce;
    public GameObject levelClearedPanel;


    public GameObject doggoPrefab;

  

    public int numberOfPlatforms;

    public float levelWidth = 3f;

     
    public float y_increment;
    public float y_increment_long;
    public float y_increment_long2;
 

    public float x_increment;
    public float doggo_y_offset;
    public float doggo_x_offset_plat3;

    public float rabbito_y_offset;
    public float rabbitto_x_offset;


    public float winning_pannel_y = 65f;
    public float winning_pannel_z = 0f;


    // Start is called before the first frame update
    void Start()
    {
         

        Vector3 spawnPosition = new Vector3();
        Vector3 winningPosition = new Vector3();

        Vector3 doggoSpawnPosition = new Vector3();
       

        int doggoSpawnDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        
        for (int i = 1; i <11; i++)
        {

            if (i == 2)
            {

                doggoSpawnDirection = Random.Range(0, 2) == 0 ? -1 : 1;

                spawnPosition.y += y_increment;

                doggoSpawnPosition.y = spawnPosition.y + doggo_y_offset;
                doggoSpawnPosition.x = spawnPosition.x + doggo_x_offset_plat3 * doggoSpawnDirection;


                if (doggoSpawnDirection == -1)
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.Euler(0f,180f,0f));
                }
                else
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.identity);
                }
              
                Instantiate(platformPrefab3, spawnPosition, Quaternion.identity);
                continue;
            }



            if (i == 4)
            {

                doggoSpawnDirection = Random.Range(0, 2) == 0 ? -1 : 1;

                spawnPosition.y += y_increment;

                doggoSpawnPosition.y = spawnPosition.y + doggo_y_offset;
                doggoSpawnPosition.x = spawnPosition.x + doggo_x_offset_plat3*doggoSpawnDirection;

                if (doggoSpawnDirection == -1)
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.Euler(0f, 180f, 0f));
                }
                else
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.identity);
                }
                Instantiate(platformPrefab3_bounce, spawnPosition, Quaternion.identity);
                continue;
            }

            if (i == 5)
            {
                spawnPosition.y += y_increment_long;
                Instantiate(platformPrefab3_bounce, spawnPosition, Quaternion.identity);
                continue;
            }


            if (i == 6)
            {
                
                spawnPosition.y += (y_increment_long-1);
                spawnPosition.x += Random.Range(-x_increment, x_increment);

                Instantiate(platformPrefab3, spawnPosition, Quaternion.identity);
                continue;
            }


            if (i == 8)
            {
                doggoSpawnDirection = Random.Range(0, 2) == 0 ? -1 : 1;

                spawnPosition.y += y_increment;

                doggoSpawnPosition.y = spawnPosition.y + doggo_y_offset;
                doggoSpawnPosition.x = spawnPosition.x + doggo_x_offset_plat3 * doggoSpawnDirection;


                if (doggoSpawnDirection == -1)
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.Euler(0f, 180f, 0f));
                }
                else
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.identity);
                }

                Instantiate(platformPrefab3, spawnPosition, Quaternion.identity);
                continue;

            }

            if (i == 10)
            {
                doggoSpawnDirection = Random.Range(0, 2) == 0 ? -1 : 1;

                spawnPosition.y += y_increment;

                doggoSpawnPosition.y = spawnPosition.y + doggo_y_offset;
                doggoSpawnPosition.x = spawnPosition.x + doggo_x_offset_plat3 * doggoSpawnDirection;


                if (doggoSpawnDirection == -1)
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.Euler(0f, 180f, 0f));
                }
                else
                {
                    Instantiate(doggoPrefab, doggoSpawnPosition, Quaternion.identity);
                }

                Instantiate(platformPrefab3_bounce, spawnPosition, Quaternion.identity);



                //instantiate winning panel

                winningPosition.x = spawnPosition.x;
                winningPosition.y = winning_pannel_y;
                winningPosition.z = winning_pannel_z;
                Instantiate(levelClearedPanel, winningPosition, Quaternion.identity);

                continue;




            }




        



            //if (i == 4)
            //{
            //    spawnPosition.y += y_long_bounce_increment;
            //    spawnPosition.x += Random.Range(-x_increment, x_increment);
            //    Instantiate(platformPrefab3_bounce, spawnPosition, Quaternion.identity);
            //    break;

            //}


            /*normal spawn*/

            spawnPosition.y += y_increment;
            spawnPosition.x += Random.Range(-x_increment, x_increment);
            Instantiate(platformPrefab1, spawnPosition, Quaternion.identity);
            /*normal spawn*/


        }





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
