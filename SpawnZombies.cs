/* Gun'em Down
 * SpawnZombies.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombies : MonoBehaviour {

    public GameObject zombie;

    // All positions where zombies can be spawn
    public Vector3 pos_1;
    public Vector3 pos_2;
    public Vector3 pos_3;
    public Vector3 pos_4;
    public Vector3 pos_5;
    public Vector3 pos_6;
    public Vector3 pos_7;
    public Vector3 pos_8;

    public int zombie_count;

    public float startWait;
    public float spawnWait;


    // Use this for initialization
    void Start () {
        StartCoroutine ( SpawnWaves() );

	}

	IEnumerator SpawnWaves () {

        yield return new WaitForSeconds(startWait);

        while (true){ // Endless Loop

            for (int i = 0; i < zombie_count; i++){

                int position = Random.Range(1, 9); // Choose a random int between 1 and 8

                switch (position)
                { // spawn zombie in one of the 8 possible positions
                    case 1:
                        Instantiate(zombie, pos_1, Quaternion.Euler(0, 0, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 2:
                        Instantiate(zombie, pos_2, Quaternion.Euler(0, -90, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 3:
                        Instantiate(zombie, pos_3, Quaternion.Euler(0, 95, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 4:
                        Instantiate(zombie, pos_4, Quaternion.Euler(0, 169, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 5:
                        Instantiate(zombie, pos_5, Quaternion.Euler(0, -225, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 6:
                        Instantiate(zombie, pos_6, Quaternion.Euler(0, -45, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 7:
                        Instantiate(zombie, pos_7, Quaternion.Euler(0, -140, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 8:
                        Instantiate(zombie, pos_8, Quaternion.Euler(0, 50, 0));
                        yield return new WaitForSeconds(spawnWait);
                        break;
                }

            }

        }

    }

}
