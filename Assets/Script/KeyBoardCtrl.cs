using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class KeyBoardCtrl : MonoBehaviour {

	public string inputText = "text";
	private TouchScreenKeyboard keyboard;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		if (GUI.Button (new Rect (0, 10, 200, 32), inputText))
			keyboard = TouchScreenKeyboard.Open (inputText);

		if (keyboard != null)
			inputText = keyboard.text;
	}

	}
