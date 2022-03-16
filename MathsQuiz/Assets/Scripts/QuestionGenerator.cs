using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    public int randomInt1;
    public int randomInt2;
    public int answer;
    public string question;
    public string choice1;
    public string choice2;
    public string choice3;
    public string choice4;


    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;
            GenerateQuestionADD();
            QuizManager.newQuestion = question;
            QuizManager.newA1 = choice1;
            QuizManager.newA2 = choice2;
            QuizManager.newA3 = choice3;
            QuizManager.newA4 = choice4;
            actualAnswer = "1";
        }
    }

    public static void GenerateQuestionADD()
    {
        randomInt1 = Random.Range(1, 10);
        randomInt2 = Random.Range(1, 10);
        answer = randomInt1 + randomInt2;
        question = randomInt1.ToString() + " + " + randomInt2.ToString();
        choice1 = answer.ToString();
        choice2 = (answer+1).ToString();
        choice3 = (answer-2).ToString();
        choice4 = (answer+4).ToString();
    }
    
}
