using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree")
        {
            //Destroy(gameObject);
            LoadScene("Lose Screen"); // change this to whatever scene should be loaded if player loses

        }
        if (other.gameObject.tag == "test")
        {
            //Destroy(gameObject);
           LoadScene("Lose Screen"); // change this to whatever scene should be loaded if player loses

        }
        if (other.gameObject.tag == "Fire")
        {

            LoadScene("Lose Screen");

        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}