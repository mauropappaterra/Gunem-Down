/* Gun'em Down
 * SpawnBoxes.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoxes : MonoBehaviour
{

    public GameObject box;

    // All positions where boxes can be spawn
    public Vector3 pos_1;
    public Vector3 pos_2;
    public Vector3 pos_3;
    public Vector3 pos_4;
    public Vector3 pos_5;
    public Vector3 pos_6;

    public int box_count;

    public float startWait;
    public float spawnWait;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnRandom());

    }

    IEnumerator SpawnRandom()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        { // Endless Loop

            for (int i = 0; i < box_count; i++)
            {

                int position = Random.Range(1, 10); // Choose a random int between 1 and 9

                switch (position)
                { // spawn box in one of the 6 possible positions, destroy box after 25 sec
                    case 1:
                        //Instantiate(box, pos_1, Quaternion.Euler(0, 0, 0));
                        Destroy(Instantiate(box, pos_1, Quaternion.Euler(0, 0, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 2:
                        Destroy(Instantiate(box, pos_2, Quaternion.Euler(0, 45, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 3:
                        Destroy(Instantiate(box, pos_3, Quaternion.Euler(0, 120, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 4:
                        Destroy(Instantiate(box, pos_4, Quaternion.Euler(0, 0, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 5:
                        Destroy(Instantiate(box, pos_5, Quaternion.Euler(0, 0, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                    case 6:
                        Destroy(Instantiate(box, pos_6, Quaternion.Euler(0, 120, 0)), 25);
                        yield return new WaitForSeconds(spawnWait);
                        break;
                }

            }

        }

    }
}