/* Gun'em Down
 * ContactDestoy.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDestroy : MonoBehaviour {

    public GameObject explosion;
    public GameObject zombie;

    //External Scripts
    public GameController game;
    public PlayerController player;

    //Crate Contents
    public GameObject skull;
    public GameObject bottle;
    public GameObject ammox50;
    public GameObject bat;
    public GameObject mushroom;
    public GameObject idol;

    private void Start()
    {
        // BIND ALL EXTERNAL SCRIPTS

        // load GameController script
        game = GameObject.FindGameObjectWithTag("GController").GetComponent<GameController>();
        
        // load PlayerController script
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        // ERROR HANDLING
        if (game == null)
        {
            Debug.LogError("Unable to find the GameController script");
        }

        if (player == null)
        {
            Debug.LogError("Unable to find the PlayerController script");
        }

    }

    void OnTriggerEnter(Collider other){


        //EXCEPTION HANDLING
        if (other.tag == "Boundary" || other.tag == "Inmortal") {
            // do nothing
            return;
            }


        //ENEMY COLLIDES WITH ENEMY
        if (other.tag == "Enemy" && gameObject.tag == "Enemy")
        {
            //do nothing
            return;
        }

        //AMMO BOXES SPAWNING IN THE SAME SPOT
        if (other.tag == "Ammo" && gameObject.tag == "Ammo")
        {
            Destroy(other.gameObject); // destroy old ammo box
            return;
        }

        //CRATES SPAWNING IN THE SAME SPOT
        if (other.tag == "Crate" && gameObject.tag == "Crate")
        {
            Destroy(other.gameObject); // destroy old crate
            return;
        }


        // else

        // SHOOT AN ENEMY
        if ((other.tag == "Enemy" && gameObject.tag == "Shot") || other.tag == "Shot" && gameObject.tag == "Enemy")
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);


            game.AddScore();
            return;
        }

        // SHOOT AMMO BOX
        if ((other.tag == "Ammo" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Ammo"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            player.addAmmo(10); // add ammo
            game.UpdateAmmo(player.ammo); // update ammo
            return;
        }

        // SHOOT CRATE
        if ((other.tag == "Crate" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Crate"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);


            // spawn random item!
            int item = Random.Range(1, 7); // Choose a random int between 1 and 6

            switch (item) // all items instantiate and destroy after 20 sec
            {
                case 1:
                    Destroy(Instantiate(skull, transform.position, transform.rotation), 20);
                    break;
                case 2:
                    Destroy(Instantiate(bottle, transform.position, transform.rotation), 20); 
                    break;
                case 3:
                    Destroy(Instantiate(ammox50, transform.position, transform.rotation), 20); 
                    break;
                case 4:
                    Destroy(Instantiate(bat, transform.position, transform.rotation), 20); 
                    break;
                case 5:
                    Destroy(Instantiate(mushroom, transform.position, transform.rotation), 20);
                    break;
                case 6:
                    Destroy(Instantiate(idol, transform.position, transform.rotation), 20);
                    break;
                default: // not implemented
                    // fart noices for empty box
                    break;
            }

            return;
        }

        // ALL SPECIAL ITEMS

        // Special Ammo Box
        if ((other.tag == "Item_Ammo" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Ammo"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            player.addAmmo(50); // add ammo
            game.UpdateAmmo(player.ammo); // update ammo
            return;
        }

        // Bottle
        if ((other.tag == "Item_Bottle" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Bottle"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            // CODE GOES HERE
            player.increaseFireRate();
            return;
        }

        // Skull
        if ((other.tag == "Item_Skull" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Skull"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            // CODE GOES HERE
            player.circleOfdeath();
            return;
        }

        // Mushroom
        if ((other.tag == "Item_Mushroom" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Mushroom"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            // CODE GOES HERE
            player.downgrade();
            return;
        }

        // Idol
        if ((other.tag == "Item_Idol" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Idol"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            // CODE GOES HERE
            player.idolRage();
            return;
        }

        // Baseball Bat
        if ((other.tag == "Item_Bat" && gameObject.tag == "Shot") || (other.tag == "Shot" && gameObject.tag == "Item_Bat"))
        {

            Destroy(other.gameObject); // destroy collition object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            // CODE GOES HERE
            player.upgrade();
            return;
        }

        // The Idol's Rage
        if (this.tag == "Idol")
        {
            Destroy(other.gameObject); // destroy collision object the idol is invencible

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            game.EndGame();
            return;
        }

        if (other.tag == "Idol")
        {
            Destroy(gameObject); // destroy collision object the idol is invencible

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);

            game.EndGame();
            return;
        }

        // PLAYER GETS HIT
        if (other.tag == "Player")
        {
            Destroy(other.gameObject); // destroy collision object
            Destroy(gameObject); // destroy shot

            explosion = Instantiate(explosion, transform.position, transform.rotation); // explosion
            Destroy(explosion, 1);


            game.EndGame();
            return;
        }

    }

}