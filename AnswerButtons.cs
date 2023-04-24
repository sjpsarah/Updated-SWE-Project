using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AnswerButtons : MonoBehaviour
{

    public GameObject answerAbackBlue; //waiting to answer
    public GameObject answerAbackGreen; //correct answer
    public GameObject answerAbackRed; //wrong answer

    public GameObject answerBbackBlue; //waiting to answer
    public GameObject answerBbackGreen; //correct answer
    public GameObject answerBbackRed; //wrong answer

    public GameObject answerCbackBlue; //waiting to answer
    public GameObject answerCbackGreen; //correct answer
    public GameObject answerCbackRed; //wrong answer

    public GameObject answerDbackBlue; //waiting to answer
    public GameObject answerDbackGreen; //correct answer
    public GameObject answerDbackRed; //wrong answer

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public AudioSource correctFX;

    public GameObject currentScore;
    public int scoreValue = 0;
    public int bestScore;
    public GameObject bestDisplay;

    public GameObject visual001, visual002, visual003, visual004;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    void Update()
    {
        currentScore.GetComponent<Text>().text = "SCORE: " + scoreValue;
        
    }


    public void AnswerA()
    {
        if (QuestionGenerator.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            led.sendGreen();
            scoreValue = scoreValue + 1;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            led.sendRed();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerator.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            led.sendGreen();
            scoreValue = scoreValue + 1;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            led.sendRed();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerator.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            led.sendGreen();
            scoreValue = scoreValue + 1;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            led.sendRed();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerator.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();
            led.sendGreen();
            scoreValue = scoreValue + 1;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            led.sendRed();
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<Text>().text = "BEST: " + scoreValue;
        }
        yield return new WaitForSeconds(2);
        visual001.SetActive(false);
        visual002.SetActive(false);
        visual003.SetActive(false);
        visual004.SetActive(false);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);
        led.sendBlue();

        QuestionGenerator.displayingQuestion = false;
    }
}
