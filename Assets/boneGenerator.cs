using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boneGenerator : MonoBehaviour
{
    public GameObject bonePrefab;
    public GameObject longbonePrefab;
    public GameObject tatebonePrefab;
    float span = 1;
    float spanb = 0.7f;
    float delta = 0;
    int RL = 0;
    int RL3 = 0;
    float aSpan = 7;
    float aDelta = -15;
    int a = 0;
    public static int apt = 0;

    void Start()
    {
        delta = 0;
        a = 0;
        apt = 0;
        aDelta = -15;
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        this.aDelta += Time.deltaTime;

        if (this.aDelta > this.aSpan)
        {
            this.aDelta = 0;
            boneGenerator.apt = Random.Range(1, 4);
        }

        if (boneGenerator.apt == 1)
        {
            if (this.delta > this.span)
            {
                this.delta = 0;
                RL = Random.Range(0, 2);
                RL3 = Random.Range(0, 2);
                float py = Random.Range(-8, 7);
                float py3 = Random.Range(-5, 5);

                if (RL == 0)
                {
                    GameObject go = Instantiate(bonePrefab);
                    go.transform.position = new Vector3(10, py, 0);
                }
                else
                {
                    GameObject go = Instantiate(bonePrefab);
                    go.transform.position = new Vector3(-10, py, 0);
                }

                if (RL3 == 0)
                {
                    GameObject go = Instantiate(bonePrefab);
                    go.transform.position = new Vector3(py3, 10, 0);
                }
                else
                {
                    GameObject go = Instantiate(bonePrefab);
                    go.transform.position = new Vector3(py3, -10, 0);
                }
            }
        }
        else if (boneGenerator.apt == 2)
        {

            if (this.a < 1)
            {
                GameObject go = Instantiate(longbonePrefab);
                go.transform.position = new Vector3(8, -1.55f, 0);
                this.a += 1;
            }
        }
        else if (boneGenerator.apt == 3)
        {
            if (this.delta > this.spanb)
            {
                this.delta = 0;
                float px = Random.Range(-20, 20) / 10f;
                
                GameObject go = Instantiate(tatebonePrefab);
                go.transform.position = new Vector3(px, 10, 0);
                float px2 = Random.Range(-20, 20) / 10f;

                GameObject go2 = Instantiate(tatebonePrefab);
                go2.transform.position = new Vector3(px2, 10, 0);
            }
        }


        if (boneGenerator.apt != 2)this.a = 0;
        
    }
}
