using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class start : MonoBehaviour
{    // Update is called once per frame
    GameObject high;
    public float hs;

    void Start()
    {
        this.high = GameObject.Find("highscore");
        hs = PlayerPrefs.GetFloat("highscore", 0);
        this.high.GetComponent<TextMeshProUGUI>().text = "highscore " + hs.ToString("F1") + "s";
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) | Input.GetKeyDown(KeyCode.Return) | Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
