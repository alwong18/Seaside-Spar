using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public List<GameObject> targets;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 100;
        scoreText.text = "score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}