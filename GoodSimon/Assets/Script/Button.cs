﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

	public int nbrButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void OnMouseDown()
	{
		GameObject.Find("GameBoard").GetComponent<Player>().SetButton(nbrButton);
	}
}
