using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Pontua��o: " + ScoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        MyscoreText.text = "Pontua��o: " + ScoreNum;
    }
}
