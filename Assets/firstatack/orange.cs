using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orange : MonoBehaviour
{
    GameObject player;
    int move;

    void Start()
    {
        player = GameObject.Find("movecheck");
    }

    void Update()
    {
        transform.Translate(0, -0.4f, 0);
        move = player.GetComponent<movecheck>().move;
        if (this.transform.position.x > 11) Destroy(gameObject);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (move == 1 && other.gameObject.tag == "heat")
        {

            //Debug.Log("hit");
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().obDecreaseHps();

            //Destroy(gameObject);
        }

    }
}
