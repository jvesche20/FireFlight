using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{

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



    // Start is called before5the first frame update
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

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Egg")
        {
            numEggs1++;
        }
        if (other.gameObject.tag == "Nest")
        {
            numEggs1 = 0;
        }
    }
    void Update()
    {
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
    }


}