using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boneController : MonoBehaviour
{
    GameObject heat;

    void Start()
    {
        this.heat = GameObject.Find("heat");
        Vector2 relativePos = heat.transform.position - this.transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, relativePos);

    }

    void Update()
    {
        transform.Translate(0.5f, 0, 0);

        if(transform.position.x < -11 | transform.position.x > 11 | transform.position.y > 13 | transform.position.y < -13 | boneGenerator.apt != 1)
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
