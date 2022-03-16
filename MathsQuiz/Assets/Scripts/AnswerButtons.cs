using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{

    public GameObject questionMenu;
    public GameObject scoreMenu;

    public GameObject answer1BackGreen;
    public GameObject answer1BackRed;

    public GameObject answer2BackGreen;
    public GameObject answer2BackRed;

    public GameObject answer3BackGreen;
    public GameObject answer3BackRed;

    public GameObject answer4BackGreen;
    public GameObject answer4BackRed;

    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;

    public int scoreValue = 0;

    public void Answer1()
    {
        if (QuestionGenerator.actualAnswer == "1")
        {
            answer1BackGreen.SetActive(true);
            scoreValue += 10;
        }
        else
        {
            answer1BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void Answer2()
    {
        if (QuestionGenerator.actualAnswer == "2")
        {
            answer2BackGreen.SetActive(true);
            scoreValue += 10;
        }
        else
        {
            answer2BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void Answer3()
    {
        if (QuestionGenerator.actualAnswer == "3")
        {
            answer3BackGreen.SetActive(true);
            scoreValue += 10;
        }
        else
        {
            answer3BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void Answer4()
    {
        if (QuestionGenerator.actualAnswer == "4")
        {
            answer4BackGreen.SetActive(true);
            scoreValue += 10;
        }
        else
        {
            answer4BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(2f);

        answer1.GetComponent<Button>().enabled = true;
        answer1BackGreen.SetActive(false);
        answer1BackRed.SetActive(false);

        answer2.GetComponent<Button>().enabled = true;
        answer2BackGreen.SetActive(false);
        answer2BackRed.SetActive(false);

        answer3.GetComponent<Button>().enabled = true;
        answer3BackGreen.SetActive(false);
        answer3BackRed.SetActive(false);

        answer4.GetComponent<Button>().enabled = true;
        answer4BackGreen.SetActive(false);
        answer4BackRed.SetActive(false);

        QuestionGenerator.displayingQuestion = false;

        if (QuestionGenerator.questionNumber == 10)
        {
            questionMenu.SetActive(false);
            scoreMenu.SetActive(true);
        }
    }
}
