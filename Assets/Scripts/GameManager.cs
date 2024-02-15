using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Camera maincam;
    public BoxCollider2D topwall;
    public BoxCollider2D bottomwall;
    public BoxCollider2D rightwall;
    public BoxCollider2D leftwall;
    public Transform player1;
    public Transform player2;

    private void Start()
    {
        float p1 = maincam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x;
        player1.position = new Vector3(p1, transform.position.y, transform.position.z);
        float p2 = maincam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x;
        player2.position = new Vector3(p2, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        topwall.size = new Vector2(maincam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        Vector2 topwally = new Vector2(0f, maincam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);
        topwall.transform.position = topwally;

        bottomwall.size = new Vector2(maincam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        Vector2 botwally = new Vector2(0f, maincam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);
        bottomwall.transform.position = botwally;

        rightwall.size = new Vector2(1f, maincam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        Vector2 rightwally = new Vector2(maincam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);
        rightwall.transform.position = rightwally;

        leftwall.size = new Vector2(1f, maincam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        Vector2 leftwally = new Vector2(maincam.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);
        leftwall.transform.position = leftwally;

        Vector3 p1 = player1.position;
        p1.x = maincam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x;
        player1.position = p1;
        Vector3 p2 = player2.position;
        p2.x = maincam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x;
        player2.position = p2;
    }
}
