using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Diff : MonoBehaviour
{
    public Text Highscore;
    public static int max_count;
    public static string difficult;
    public static float seconds=35;
    public static int multiplier;
    public static int multiplier_counts;
    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) - 100, 400, 100));

        // GUILayout.Space(50);
        if (GUILayout.Button("Easy"))
        {
            difficult = "Easy";
            max_count = 5;
            Application.LoadLevel("Number");
            //seconds = 30;
            multiplier = 1;
            multiplier_counts = 500;
            seconds = 60;

        }
        GUILayout.EndArea();
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) - 60, 400, 100));
        if (GUILayout.Button("Average"))
        {
            max_count = 7;
            difficult = "Average";

            Application.LoadLevel("Number");
            multiplier = 2;
            multiplier_counts = 1000;
            seconds = 45;

        }
        GUILayout.EndArea();
        GUILayout.Space(50);
        GUILayout.BeginArea(new Rect(((Screen.width / 2) - 200), (Screen.height / 2) - 20, 400, 100));
        if (GUILayout.Button("Hard"))
        {
            max_count = 10;
            difficult = "Hard";
            Application.LoadLevel("Number");
            multiplier = 3;
            multiplier_counts = 1500;
            seconds = 30;
        }
        GUILayout.EndArea();
    }
    private void Start()
    {
        Highscore.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
    }
}