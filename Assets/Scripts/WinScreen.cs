using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinScreen : MonoBehaviour
{
    bool winTrue = false;
    int numEggs = 0;
  

    // Update is called once per frame
    void Update()
    {
        if(numEggs == 10)
        {
            winTrue = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Nest")
        {
            //Destroy(gameObject);
            if (winTrue)
            {
                LoadScene("Win Screen 1"); // change this to whatever scene should be loaded if player loses
            }
            

        }
        if(other.gameObject.tag == "Egg")
        {
            numEggs++;
        }
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
