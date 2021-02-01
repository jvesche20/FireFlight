using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fireCollider : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
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