﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
	public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPause()
    {
    	Time.timeScale = 0.0f;
    	canvas.SetActive(true);
    }

    public void onResume()
    {
    	Time.timeScale = 1.0f;
    	canvas.SetActive(false);
    }
}
