using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class sucor : MonoBehaviour
{
    GameObject TimeText;
    GameObject scoreText;
    public float score_num = 0;

    void Start()
    {
        score_num = PlayerPrefs.GetFloat("highscore", 0);

        if (GameDirector.ftime > score_num)
        {
            score_num = GameDirector.ftime;
        }
        this.scoreText = GameObject.Find("highscore");
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "high score " + score_num.ToString("F1") + "s";

        this.TimeText = GameObject.Find("sucor");
        this.TimeText.GetComponent<TextMeshProUGUI>().text = "Your Score is " + GameDirector.ftime.ToString("F1") + "s";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) | Input.GetKeyDown(KeyCode.Return) | Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetFloat("highscore", score_num);
        PlayerPrefs.Save();
    }
}
