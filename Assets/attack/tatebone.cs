using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tatebone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.5f, 0,Space.World);
        if(transform.position.y < -7 | boneGenerator.apt != 3)
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
