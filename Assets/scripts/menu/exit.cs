﻿using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour 
{ 
    public void OnMouseEnter()
    {
        transform.localScale *= 0.9F;
    }
    public void OnMouseExit()
    {
        transform.localScale /= 0.9F;
    }
	
	 public void OnMouseUp()
    {
        Application.Quit();

    }
}