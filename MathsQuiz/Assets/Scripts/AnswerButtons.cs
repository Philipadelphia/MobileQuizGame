using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{

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

    public void Answer1()
    {
        if (QuestionGenerator.actualAnswer == "1")
        {
            answer1BackGreen.SetActive(true);
        }
        else
        {
            answer1BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
    }
    public void Answer2()
    {
        if (QuestionGenerator.actualAnswer == "2")
        {
            answer2BackGreen.SetActive(true);
        }
        else
        {
            answer2BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
    }
    public void Answer3()
    {
        if (QuestionGenerator.actualAnswer == "3")
        {
            answer3BackGreen.SetActive(true);
        }
        else
        {
            answer3BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
    }
    public void Answer4()
    {
        if (QuestionGenerator.actualAnswer == "4")
        {
            answer4BackGreen.SetActive(true);
        }
        else
        {
            answer4BackRed.SetActive(true);
        }
        answer1.GetComponent<Button>().enabled = false;
        answer2.GetComponent<Button>().enabled = false;
        answer3.GetComponent<Button>().enabled = false;
        answer4.GetComponent<Button>().enabled = false;
    }
}
