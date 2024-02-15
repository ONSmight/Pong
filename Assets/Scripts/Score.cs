using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    GameObject game;

    string button;
    private void Start()
    {
        game = GameObject.Find("Ball");
       // Time.timeScale = 0;
       // button = "Start";
    }
    static int p1s = -1, p2s = -1;
    public GUISkin skin;

    public void score(string wallname)
    {
        if (wallname == "rightwall")
        {
            p1s += 1;
        }
        else
        {
            p2s += 1;
        }
    }

    private void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(Screen.width / 2 - 200, 25, 100, 100), "" + p1s);
        GUI.Label(new Rect(Screen.width / 2 + 150, 25, 100, 100), "" + p2s);
        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 35, 121, 53), "Reset"))
        {
           // Time.timeScale = 1;
            button = "Reset";
            p1s = 0;
            p2s = 0;
            game.GetComponent<Ball>().Respawn(1f);
           // Debug.Log("qaz");
        }
       /* if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, 35, 121, 53), button) && Time.timeScale == 1f)
        {
            p1s = 0;
            p2s = 0;
            game.GetComponent<Ball>().Respawn(1f);
            Debug.Log("asd");
        }*/
    }
}
