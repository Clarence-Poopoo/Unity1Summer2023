using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    Vector3 startPos;
    Rigidbody rb;
    [SerializeField]
    TMP_Text scoreTxt;
    int score;
    int highScore = 0;
    [SerializeField]
    GameObject gameOverHud;
    public TimerScript clock;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        gameOverHud.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
        {
            clock.isGameOver = true;
            gameOverHud.SetActive(true);
            Cursor.visible = true;

            //Highscore stuff
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("highScore", highScore);
            }

            if(clock.second > 9)
            {
                gameOverHud.GetComponent<TMP_Text>().text = $"Game Over \n HighScore: {PlayerPrefs.GetInt("highScore")} \nYour Time: {clock.minute}:{clock.second} ";
            }
            else
            {
                gameOverHud.GetComponent<TMP_Text>().text = $"Game Over \n  HighScore: {PlayerPrefs.GetInt("highScore")} \nYour Time: {clock.minute}:0{clock.second} ";
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Paddle")
        {
            score++;
            scoreTxt.text = $"Score: {score}";
        }
    }

    public void RestartGame()
    {
        gameOverHud.SetActive(false);
        transform.position = startPos;
        rb.velocity = Vector3.zero;
        score = 0;
        clock.timeStart = 0;
        clock.isGameOver = false;
        scoreTxt.text = $"Score: {score}";
        Cursor.visible = false;
    }
}
