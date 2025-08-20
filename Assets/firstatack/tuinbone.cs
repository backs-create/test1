using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuinbone : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -0.3f, 0);
        if(transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "heat")
        {
            //Debug.Log("hit");
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHps();

            //Destroy(gameObject);
        }
    }

}
