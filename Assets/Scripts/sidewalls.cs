using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidewalls : MonoBehaviour
{

    private void Start()
    {
        gameObject.GetComponent<AudioSource>().PlayDelayed(1000000000000f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject game;
        game = GameObject.Find("_GM");
        
        if (collision.gameObject.name == "Ball")
        {
            gameObject.GetComponent<AudioSource>().Play();
            string name = gameObject.name;
            game.GetComponent<Score>().score(wallname: name);
            collision.gameObject.GetComponent<Ball>().Respawn();
        }
    }
}
