﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    // Start is called before the first frame update

    public int numEggs = 0;
    public GameObject arrow;

    void Start()
    {
        arrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (numEggs != 0)
        {
            arrow.SetActive(true);

        }
        else
        {
            arrow.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Egg")
        {
            numEggs++;
        }
        if (other.gameObject.tag == "Nest")
        {
            numEggs = 0;
        }
    }
}