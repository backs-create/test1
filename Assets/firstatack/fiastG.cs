using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fiastG : MonoBehaviour
{
    float timer = 0;
    float cdelta = 0;
    int ap = 0;
    public GameObject tuinbonePrefab;
    public GameObject redPrefab;
    public GameObject orangePrefab;
    public GameObject burePrefab;

    private void Start()
    {
        timer = 0;
        cdelta = 0;
        ap = 0;

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (this.timer < 4 && this.timer > 0.05f)
        {
            this.cdelta += Time.deltaTime;
            if (this.cdelta > 0.1f)
            {
                this.cdelta = 0;
                GameObject go = Instantiate(tuinbonePrefab);
                GameObject go2 = Instantiate(tuinbonePrefab);
                if (this.timer < 1)
                {
                    go.transform.position = new Vector3(-3f + this.timer * 3f, 10, 0);
                }
                else if(this.timer >= 1 && this.timer < 3)
                {
                    go.transform.position = new Vector3(((this.timer - 1)  * -2f), 10, 0);
                }
                else
                {
                    go.transform.position = new Vector3(-4 + ((this.timer - 3) * 3), 10, 0);
                }

                if (this.timer < 1)
                {
                    go2.transform.position = new Vector3(11.5f ,2 + -3f + this.timer * 3f, 0);
                    go2.transform.Rotate(0, 0, -90);
                }
                else if (this.timer >= 1 && this.timer < 3)
                {
                    go2.transform.position = new Vector3(11.5f ,2 + (this.timer - 1) * -2f, 0);
                    go2.transform.Rotate(0, 0, -90);
                }
                else
                {
                    go2.transform.position = new Vector3(11.5f ,2 + -4 + ((this.timer - 3) * 3), 0);
                    go2.transform.Rotate(0, 0, -90);
                }
            }
        }
        else if(this.timer >= 4 && this.timer < 9)
        {
            this.cdelta += Time.deltaTime;
            if(cdelta > 0.5f)
            {
                cdelta = 0;
                Quaternion downRotation = Quaternion.Euler(0, 0, 270f);
                GameObject go = Instantiate(redPrefab, new Vector3(0, 5, 0), downRotation);

            }
        }
        else if(this.timer >= 12 && this.timer <= 20)
        {
            this.cdelta += Time.deltaTime;
            if(cdelta > 0.5f)
            {
                cdelta = 0;
                if(ap == 1 | ap == 3 | ap == 4 | ap ==8 | ap == 9 | ap == 13)
                {
                    GameObject go = Instantiate(burePrefab);
                    go.transform.position = new Vector3(11, -1.55f, 0);
                    go.transform.Rotate(0, 0, -90);
                }
                else
                {
                    GameObject go = Instantiate(orangePrefab);
                    go.transform.position = new Vector3(-11, -1.55f, 0);
                    go.transform.Rotate(0, 0, 90);
                }

                ap += 1;
            }
        }

    }
}
