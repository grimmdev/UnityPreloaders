using UnityEngine;
using System.Collections;

// ignore this script, just to load the other scenes
public class Menu : MonoBehaviour {

	public GUISkin gui;
	
	void OnGUI()
	{
		GUI.skin = gui;
		if(GUILayout.Button("Demo1")){
			Application.LoadLevel(0);
		}
		if(GUILayout.Button("Demo2")) {
			Application.LoadLevel(1);
		}
		if(GUILayout.Button("Demo3")){
			Application.LoadLevel(2);
		}
	}
}
