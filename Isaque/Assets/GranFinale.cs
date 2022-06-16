using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GranFinale : MonoBehaviour
{
    public GameObject perso;
    Animator animo;
    public Text ScoreText;
    public int ScoreNumber;
    void Start()
    {
        ScoreNumber = PlayerPrefs.GetInt("Player Score");
        ScoreText.text = "" + ScoreNumber;
        animo = perso.GetComponent<Animator>();
        animo.SetInteger("Pontuacao", ScoreNumber);
    }
}
