using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecheck : MonoBehaviour
{
    GameObject player;
    Vector3 last;
    public int move = 1;

    void Start()
    {
        player = GameObject.Find("heat");
    }

    void Update()
    {
        if (last == player.transform.position)
        {
            this.move = 1;
        }
        else
        {
            this.move = 0;
        }

        last = player.transform.position;

    }
}
