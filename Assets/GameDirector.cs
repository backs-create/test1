using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject hp;
    GameObject TimerText;
    float time = 0.0f;
    public static float ftime;

    void Start()
    {
        this.hp = GameObject.Find("hpa");
        this.TimerText = GameObject.Find("time");
    }

    void Update()
    {
        if (this.hp.GetComponent<Image>().fillAmount > 0)
        {
            this.time += Time.deltaTime;
            this.TimerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
            ftime = this.time;
        }
        else
        {
            SceneManager.LoadScene("gameover");
        }
    }

    public void DecreaseHps()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.01f;
    }

    public void redDecreaseHps()
    {
        if (this.hp.GetComponent<Image>().fillAmount != 0.01f)
        {
            this.hp.GetComponent<Image>().fillAmount = 0.01f;
        }
        else
        {
            this.hp.GetComponent<Image>().fillAmount -= 1;
        }
    }

    public void obDecreaseHps()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.03f;
    }

}
