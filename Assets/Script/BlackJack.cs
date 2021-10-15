using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackJack : MonoBehaviour
{
    [SerializeField] Text judgement;
    [SerializeField] Text score;
    [SerializeField] Text life;

    [SerializeField] GameObject pCard;
    [SerializeField] Text pNumber;
    [SerializeField] GameObject eCard;
    [SerializeField] Text eNumber;

    int nowScore = 0;
    int nowLife = 3;


    // Start is called before the first frame update
    void Start()
    {
        DealCards();
    }

    // Update is called once per frame
    void Update()
    {
        if (nowLife == 0)
        {
            judgement.text = "GAMEOVER";
        }
    }
    public void DealCards()
    {
        int pScore = 0;
        int eScore = 0;
        
        pScore = Random.Range(1, 14);
        pNumber.text = pScore.ToString();
        eScore = Random.Range(1, 14);
        eNumber.text = eScore.ToString();
        if (pScore > eScore)
        {
            nowScore++;
            score.text = "Score:" + nowScore.ToString();
            judgement.text = "WIN";
        }
        else if (pScore < eScore)
        {
            judgement.text = "LOSE";
            nowLife--;
            life.text = "Life:" + nowLife;
        }
        else 
        {
            judgement.text = "DRAW";
        }
    }
    public void Again()
    {
        DealCards();
    }
}
