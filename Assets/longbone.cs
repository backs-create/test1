using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longbone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        

        if(transform.position.x > 0)
        {
            transform.Translate(-0.2f, 0, 0, Space.World);
        }
        else
        {
            transform.Rotate(0, 0, 5);
        }

        if(boneGenerator.apt != 2)
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
