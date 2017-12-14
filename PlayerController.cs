/* Gun'em Down
 * PLayerController.cs
 * Created by Mauro J. Pappaterra on 07 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {

    public float RotationSpeed;
    

    // fields related to shooting
    public GameObject shot; // objects to spawn
    public GameObject idol;

    public Transform deadByIdol;

    public int level = 1;
    public Transform shotSpawn; // place to spawn
    public Transform shotSpawn2;
    public Transform shotSpawn3;
    public Transform shotSpawn4;
    public Transform shotSpawn5;
    public Transform shotSpawn6;

    public double fireRate; // how many shots you can fire per second
    public double nextFire; // time 'till next shot available
    public float ammo; // number of bullets left

    //External Scripts Binding
    public GameController game;

    // circle of death

    public Transform die1;
    public Transform die2;
    public Transform die3;
    public Transform die4;
    public Transform die5;
    public Transform die6;
    public Transform die7;
    public Transform die8;
    public Transform die9;
    public Transform die10;
    public Transform die11;
    public Transform die12;
    public Transform die13;
    public Transform die14;
    public Transform die15;
    public Transform die16;
    public Transform die17;
    public Transform die18;
    public Transform die19;
    public Transform die20;
    public Transform die21;
    public Transform die22;
    public Transform die23;
    public Transform die24;
    public Transform die25;
    public Transform die26;
    public Transform die27;
    public Transform die28;
    public Transform die29;
    public Transform die30;
    public Transform die31;
    public Transform die32;
    public Transform die33;
    public Transform die34;
    public Transform die35;
    public Transform die36;
    public Transform die37;
    public Transform die38;
    public Transform die39;
    public Transform die40;
    public Transform die41;
    public Transform die42;


    private void Start()
    {
        // load GameController script
        game = GameObject.FindGameObjectWithTag("GController").GetComponent<GameController>();

        if (game == null)
        {
            Debug.LogError("Unable to find the GameController script");
        }
    }


    void Update()
    {

        if (Time.time > nextFire && Input.GetKey("space") && (ammo > 0)){
            nextFire = Time.time + fireRate; // updates nextFire for next shot

            if (level > ammo) // downgrade if not available ammunition
            {
                level = Convert.ToInt32(ammo);
            }

            if (level == 1){
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 1 shot
                ammo--;
            }

            if (level == 2)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 2 shots
                Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                ammo = ammo - 2;
            }

            if (level == 3)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 3 shots
                Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                ammo = ammo - 3;

            }

            if (level == 4)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 4 shots
                Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                Instantiate(shot, shotSpawn4.position, shotSpawn4.rotation);
                ammo = ammo - 4;

            }

            if (level == 5)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 5 shots
                Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                Instantiate(shot, shotSpawn4.position, shotSpawn4.rotation);
                Instantiate(shot, shotSpawn5.position, shotSpawn5.rotation);
                ammo = ammo - 5;

            }

            if (level == 6)
            {
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // spawns 6 shots
                Instantiate(shot, shotSpawn2.position, shotSpawn2.rotation);
                Instantiate(shot, shotSpawn3.position, shotSpawn3.rotation);
                Instantiate(shot, shotSpawn4.position, shotSpawn4.rotation);
                Instantiate(shot, shotSpawn5.position, shotSpawn5.rotation);
                Instantiate(shot, shotSpawn6.position, shotSpawn6.rotation);
                ammo = ammo - 6;
            }

            game.UpdateAmmo(ammo);
        }

    }

    // Player Rotation
    void FixedUpdate(){
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.up * RotationSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(-Vector3.up * RotationSpeed * Time.deltaTime);
    }

    public void addAmmo(int n)
    {
        ammo = ammo + n;
    }

    public void increaseFireRate()
    {
        fireRate = fireRate * 1.50;
    }

    public void upgrade()
    {
        level = Math.Min(++level, 6);
    }

    public void downgrade()
    {
        level = 1;
    }

    public void circleOfdeath()
    {
        Instantiate(shot, die1.position, die1.rotation);
        Instantiate(shot, die2.position, die2.rotation);
        Instantiate(shot, die3.position, die3.rotation);
        Instantiate(shot, die4.position, die4.rotation);
        Instantiate(shot, die5.position, die5.rotation);
        Instantiate(shot, die6.position, die6.rotation);
        Instantiate(shot, die7.position, die7.rotation);
        Instantiate(shot, die8.position, die8.rotation);
        Instantiate(shot, die9.position, die9.rotation);
        Instantiate(shot, die10.position, die10.rotation);

        Instantiate(shot, die11.position, die11.rotation);
        Instantiate(shot, die12.position, die12.rotation);
        Instantiate(shot, die13.position, die13.rotation);
        Instantiate(shot, die14.position, die14.rotation);
        Instantiate(shot, die15.position, die15.rotation);
        Instantiate(shot, die16.position, die16.rotation);
        Instantiate(shot, die17.position, die17.rotation);
        Instantiate(shot, die18.position, die18.rotation);
        Instantiate(shot, die19.position, die19.rotation);
        Instantiate(shot, die20.position, die20.rotation);

        Instantiate(shot, die21.position, die21.rotation);
        Instantiate(shot, die22.position, die22.rotation);
        Instantiate(shot, die23.position, die23.rotation);
        Instantiate(shot, die24.position, die24.rotation);
        Instantiate(shot, die25.position, die25.rotation);
        Instantiate(shot, die26.position, die26.rotation);
        Instantiate(shot, die27.position, die27.rotation);
        Instantiate(shot, die28.position, die28.rotation);
        Instantiate(shot, die29.position, die29.rotation);
        Instantiate(shot, die30.position, die30.rotation);

        Instantiate(shot, die31.position, die31.rotation);
        Instantiate(shot, die32.position, die32.rotation);
        Instantiate(shot, die33.position, die33.rotation);
        Instantiate(shot, die34.position, die34.rotation);
        Instantiate(shot, die35.position, die35.rotation);
        Instantiate(shot, die36.position, die36.rotation);
        Instantiate(shot, die37.position, die37.rotation);
        Instantiate(shot, die38.position, die38.rotation);
        Instantiate(shot, die39.position, die39.rotation);
        Instantiate(shot, die40.position, die40.rotation);

        Instantiate(shot, die41.position, die41.rotation);
        Instantiate(shot, die42.position, die42.rotation);

    }

    public void idolRage()
    {
        Instantiate(idol, deadByIdol.position, deadByIdol.rotation);
    }
}