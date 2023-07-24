using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text scoreHud;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        Score++;
        Debug.Log($"The score is {Score}");
        scoreHud.text = $"Boulders Hit: {Score}";
    }
}
