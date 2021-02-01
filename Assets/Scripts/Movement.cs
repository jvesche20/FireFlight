﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Vector3 minBounds;
    public Vector3 maxBounds;

    public float speed = 1f;
    public float rotationSpeed = 100f;
    public KeyCode left;
    public KeyCode right;
    public KeyCode up; // speed up
    public KeyCode down; // speed down
    public KeyCode space; // go up 
    public float yUp = 0.1f; // how fast the object will go up when space is pressed
    public float gravity = .01f; // how fast the obect falls
    float yPosGoDown;
    float xMovement;
    float zMovement;
    float yMovement;

    float xRotation;
    float yRotation;
    float zRotation;
    int count = 0;
    private float increase = .1f;

    private Vector3 userDirection = new Vector3(0, 0, 2); // change the y value to change the direction the obj starts to move at. 
    //-----------------------------------------------------------------------------------------
    // Eggs
    // make it so that the number of eggs slows you down. 
    public Text mytext; // number of points the player has 
    // public Text mytext2; // this is for the number of eggs that player has...............Used in nest.cs dont need anymore.
    public int points = 0;
    public int numEggsPlayer = 0;
    public int numEggsGame = 10; // number of eggs we have in the game.
    private float slowPlayer; // this is the max that you can go with x eggs
    //-------------------------------------------------------------------------------------
    // back
    public GameObject eggBack1;
    public GameObject eggBack2;
    public GameObject eggBack3;
    public GameObject eggBack4;
    public GameObject eggBack5;
    public GameObject eggBack6;
    public GameObject eggBack7;
    public GameObject eggBack8;
    public GameObject eggBack9;
    public GameObject eggBack10;

    public int numEggs1 = 0;
    public int maxEggs1 = 10;
    public int temp;
    // 10 or 15 eggs
    private int hit = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Egg")
        {
            hit--;

            Destroy(other.gameObject);
            if(hit > -1)
            {
                points++;
                numEggsPlayer++;
                numEggs1++;
            }
            


        }
        if (other.gameObject.tag == "Nest")
        {
            numEggs1 = 0;
            slowPlayer = 10f;

        }
    }
    void Start()
    {
        eggBack1.SetActive(false);
        eggBack2.SetActive(false);
        eggBack3.SetActive(false);
        eggBack4.SetActive(false);
        eggBack5.SetActive(false);
        eggBack6.SetActive(false);
        eggBack7.SetActive(false);
        eggBack8.SetActive(false);
        eggBack9.SetActive(false);
        eggBack10.SetActive(false);
    }
    void Update()
    {
        hit = 1;
        temp = numEggs1;
        for (int i = maxEggs1; i > 0; i--)
        {

            //egg1.SetActive(true);
            if (numEggs1 == 0)
            {
                eggBack1.SetActive(false);
                eggBack2.SetActive(false);
                eggBack3.SetActive(false);
                eggBack4.SetActive(false);
                eggBack5.SetActive(false);
                eggBack6.SetActive(false);
                eggBack7.SetActive(false);
                eggBack8.SetActive(false);
                eggBack9.SetActive(false);
                eggBack10.SetActive(false);
            }
            if (temp == 1)
            {
                eggBack1.SetActive(true);
            }
            else if (temp == 2)
            {
                eggBack2.SetActive(true);
                temp--;
            }
            else if (temp == 3)
            {
                eggBack3.SetActive(true);
                temp--;
            }
            else if (temp == 4)
            {
                eggBack4.SetActive(true);
                temp--;
            }
            else if (temp == 5)
            {
                eggBack5.SetActive(true);
                temp--;
            }
            else if (temp == 6)
            {
                eggBack6.SetActive(true);
                temp--;
            }
            else if (temp == 7)
            {
                eggBack7.SetActive(true);
                temp--;
            }
            else if (temp == 8)
            {
                eggBack8.SetActive(true);
                temp--;
            }
            else if (temp == 9)
            {
                eggBack9.SetActive(true);
                temp--;
            }
            else if (temp == 10)
            {
                eggBack10.SetActive(true);
                temp--;

            }

        }
        if (numEggsPlayer == 0)
        {
            slowPlayer = 10f;
        }
        else if (numEggsPlayer == numEggsGame) // makes it so that if theres a max eggs speed is 1.
        {
            slowPlayer = 3f;
        }
        else
        {
            slowPlayer = 10f - (numEggsPlayer + .5f);
        }

        mytext.text = "Points: " + points; // update the count
        //mytext2.text = "Number of eggs: " + numEggsPlayer; // update the count............ dont need. used in nest.cs

        transform.Translate(userDirection * speed * Time.deltaTime);
        xMovement = 0;
        zMovement = 0;

        if (Input.GetKey(left) && (Input.GetKey(right)))
        {
            xMovement = 0;
        }
        else if (Input.GetKey(left) && (Input.GetKey(up)))
        {
            yRotation -= rotationSpeed * Time.deltaTime;
            if (speed > slowPlayer)
            {
                speed = slowPlayer;
            }
            else
            {
                speed = speed + increase;
            }

        }
        else if (Input.GetKey(space) && (Input.GetKey(left)))
        {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + yUp, this.transform.position.z);
            yRotation -= rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(space) && (Input.GetKey(right)))
        {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + yUp, this.transform.position.z);
            yRotation += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(space) && (Input.GetKey(down)))
        {
            if (speed < 0.1)
            {
                speed = 0;
            }
            else
            {
                speed = speed - increase;
            }
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + yUp, this.transform.position.z);
        }
        else if (Input.GetKey(space) && (Input.GetKey(up)))
        {
            if (speed > slowPlayer)
            {
                speed = slowPlayer;
            }
            else
            {
                speed = speed + increase;
            }
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + yUp, this.transform.position.z);

        }
        else if (Input.GetKey(right) && (Input.GetKey(up)))
        {
            yRotation += rotationSpeed * Time.deltaTime;
            if (speed > slowPlayer)
            {
                speed = slowPlayer;
            }
            else
            {
                speed = speed + increase;
            }

        }
        else if (Input.GetKey(left) && (Input.GetKey(down)))
        {
            yRotation -= rotationSpeed * Time.deltaTime;
            if (speed < 0.1)
            {
                speed = 0;
            }
            else
            {
                speed = speed - increase;
            }

        }
        else if (Input.GetKey(right) && (Input.GetKey(down)))
        {
            yRotation += rotationSpeed * Time.deltaTime;
            if (speed < 0.1)
            {
                speed = 0;
            }
            else
            {
                speed = speed - increase;
            }

        }
        else if (Input.GetKey(right))
        {
            yRotation += rotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(left))
        {
            yRotation -= rotationSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(up))
        {
            if (speed > slowPlayer)
            {
                speed = slowPlayer;
            }
            else
            {
                speed = speed + increase;
            }
        }
        else if (Input.GetKey(down))
        {
            if (speed < 0.1)
            {
                speed = 0;
            }
            else
            {
                speed = speed - increase;
            }

        }
        else if (Input.GetKey(space))
        {
            transform.position = new Vector3(this.transform.position.x, this.transform.position.y + yUp, this.transform.position.z);

        }

        yPosGoDown = transform.position.y;
        if (yPosGoDown > 40f && !(Input.GetKey(down)))
        {
            gravity = 1f;
        }
        else
        {
            gravity = .05f;
        }
        transform.rotation = Quaternion.Euler(xRotation, yRotation, zRotation);
        transform.position = new Vector3(this.transform.position.x + xMovement, this.transform.position.y - gravity, this.transform.position.z + zMovement);


        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x),
            Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y),
            Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z));
    }
}