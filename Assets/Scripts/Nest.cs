using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nest : MonoBehaviour
{
    // Start is called before the first frame update

    // all these eggs are for the nest.
    public Text actualEgg;
    public GameObject egg1;
    public GameObject egg2;
    public GameObject egg3;
    public GameObject egg4;
    public GameObject egg5;
    public GameObject egg6;
    public GameObject egg7;
    public GameObject egg8;
    public GameObject egg9;
    public GameObject egg10;
    public int numEggsPlayer = 0;
    public int maxEggs = 10; //change to 10 on final build
    public int numEggsAch = 0;
    int temp = 0;
    private int hit = 1;
    void Start()
    {
        egg1.SetActive(false);
        egg2.SetActive(false);
        egg3.SetActive(false);
        egg4.SetActive(false);
        egg5.SetActive(false);
        egg6.SetActive(false);
        egg7.SetActive(false);
        egg8.SetActive(false);
        egg9.SetActive(false);
        egg10.SetActive(false);

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Egg"))
        {
            hit--;
            if (hit > -1)
            {
                numEggsPlayer++;
                numEggsAch++;
            }
                
            //++temp;
        }
        if (other.gameObject.tag == ("Nest"))
        {
            temp = numEggsPlayer;
            for (int i = maxEggs; i > 0; i--)
            {

                //egg1.SetActive(true);

                if (temp == 1)
                {
                    egg1.SetActive(true);
                }
                else if (temp == 2)
                {
                    egg2.SetActive(true);
                    temp--;
                }
                else if (temp == 3)
                {
                    egg3.SetActive(true);
                    temp--;
                }
                else if (temp == 4)
                {
                    egg4.SetActive(true);
                    temp--;
                }
                else if (temp == 5)
                {
                    egg5.SetActive(true);
                    temp--;
                }
                else if (temp == 6)
                {
                    egg6.SetActive(true);
                    temp--;
                }
                else if (temp == 7)
                {
                    egg7.SetActive(true);
                    temp--;
                }
                else if (temp == 8)
                {
                    egg8.SetActive(true);
                    temp--;
                }
                else if (temp == 9)
                {
                    egg9.SetActive(true);
                    temp--;
                }
                else if (temp == 10)
                {
                    egg10.SetActive(true);
                    temp--;
                    LoadScene("Win Screen"); // change this to whatever the win scene is called.
                }

            }
            numEggsAch = 0;
        }
    }
    void Update()
    {
        hit = 1;
        actualEgg.text = "Eggs currently have " + numEggsAch;
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}