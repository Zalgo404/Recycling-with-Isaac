using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Caindo : MonoBehaviour
{
    public GameObject sprite;
    public Score score;
    public ChangeSprite lixeira;
    Animator spriteanimator;
    public int a = 2;
    public float b = 0;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        spriteanimator = sprite.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.position -= transform.up * Time.deltaTime * 5;
        sprite.transform.Rotate(0f, 0f, 1f);
        if (counter == 10)
        {
            SceneManager.LoadScene("Final");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Lixo")
        {
            if (lixeira.jooj == 0 && (a == 2 || a == 3))
            {
                score.ScoreNum += 5;
            }
            else if (lixeira.jooj == 1 && (a == 4 || a == 5))
            {
                score.ScoreNum += 5;
            }
            else if (lixeira.jooj == 2 && (a == 0 || a == 1))
            {
                score.ScoreNum += 5;
            }
            else if (lixeira.jooj == 3 && (a == 8 || a == 9))
            {
                score.ScoreNum += 5;
            }
            else if (lixeira.jooj == 4 && (a == 6 || a == 7))
            {
                score.ScoreNum += 5;
            }
            else
            {
                score.ScoreNum -= 5;
            }
        }
        else
        {
            score.ScoreNum -= 10;
        }
            PlayerPrefs.SetInt("Player Score", score.ScoreNum);
        b = Random.Range(-8, 8);
        transform.position = new Vector2(b, 9.0f);
        a = Random.Range(0, 9);
        spriteanimator.SetInteger("Lixo", a);
        counter++;
    }
}