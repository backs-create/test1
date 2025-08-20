using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heatController : MonoBehaviour
{
    public AudioClip damageSE;
    public AudioClip redSE;
    AudioSource aud;
    GameObject player;
    Vector3 last;
    GameObject pl;
    int move;

    void Start()
    {
        Application.targetFrameRate = 30;
        this.aud = GetComponent<AudioSource>();
        player = GameObject.Find("heat");
        pl = GameObject.Find("movecheck");

    }

    void Update()
    {
        Vector2 tmp = GameObject.Find("heat").transform.position;
        float x = tmp.x;
        float y = tmp.y;

        if (x > -2)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.transform.Translate(-0.1f, 0, 0);
            }
        }

        if (x < 2)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                this.transform.Translate(0.1f, 0, 0);
            }
        }

        if (y < 0.5)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.transform.Translate(0, 0.1f, 0);
            }
        }

        if (y > -3.5)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                this.transform.Translate(0, -0.1f, 0);
            }
        }

        move = pl.GetComponent<movecheck>().move;
        
        //Debug.Log(move.ToString());
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "orange" && move == 0)
        {

        }
        else if (other.gameObject.tag == "bure" && move == 1)
        {

        }
        else if(other.gameObject.tag == "red")
        {
            this.aud.Stop();
            this.aud.PlayOneShot(this.redSE);
        }
        else
        {
            this.aud.Stop();
            this.aud.PlayOneShot(this.damageSE);
        }
    }
}
