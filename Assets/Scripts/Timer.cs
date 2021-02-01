using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{

    public float timeFloat = 999f;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeFloat -= Time.deltaTime;

        if(timeFloat < 0)
        {
            LoadScene("Lose Screen");
        }
        timeText.text = "Time Left: " + (int) timeFloat;
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
