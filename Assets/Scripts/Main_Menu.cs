using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour {
    public Color color;
  
    private void OnGUI()
    {
        //GUI.contentColor = new Color(255 / 255f, 130 / 218f, 171 / 255);
        GUI.backgroundColor = new Color(0 / 0f, 200 / 212f, 112 / 212);
        GUI.color = new Color(222 / 222, 222 / 222, 222 / 222);

        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) - 100, 400, 100));

        if (GUILayout.Button("Start", GUILayout.Width(400), GUILayout.Height(30)))

        {

            Application.LoadLevel("Difficult");

        }
        GUILayout.EndArea();

       
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) , 400, 100));
        if (GUILayout.Button("About",GUILayout.Width(400),GUILayout.Height(30)))
        {
            Application.LoadLevel("About");
        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) + 100, 400, 100));
        if (GUILayout.Button("Exit", GUILayout.Width(400), GUILayout.Height(30)))

        {
            Application.Quit();

        }
       GUILayout.EndArea();
    }
}
