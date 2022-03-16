using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{

    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public static int questionNumber;

    public static int randomInt1;
    public static int randomInt2;
    public static int answer;
    public static string question;
    public static string choice1;
    public static string choice2;
    public static string choice3;
    public static string choice4;
    public static int correctAnswer;


    void Update()
    {
        if (displayingQuestion == false && questionNumber < 10)
        {
            displayingQuestion = true;
            questionNumber += 1;
            correctAnswer = Random.Range(1, 5);

            if (correctAnswer == 1) {
                GenerateQuestionADD();
                QuizManager.newQuestion = question;
                QuizManager.newA1 = choice1;
                QuizManager.newA2 = choice2;
                QuizManager.newA3 = choice3;
                QuizManager.newA4 = choice4;
                actualAnswer = "1";
            }
            else if (correctAnswer == 2)
            {
                GenerateQuestionADD();
                QuizManager.newQuestion = question;
                QuizManager.newA1 = choice2;
                QuizManager.newA2 = choice1;
                QuizManager.newA3 = choice3;
                QuizManager.newA4 = choice4;
                actualAnswer = "2";
            }
            else if (correctAnswer == 3)
            {
                GenerateQuestionADD();
                QuizManager.newQuestion = question;
                QuizManager.newA1 = choice3;
                QuizManager.newA2 = choice2;
                QuizManager.newA3 = choice1;
                QuizManager.newA4 = choice4;
                actualAnswer = "3";
            }
            else if (correctAnswer == 4)
            {
                GenerateQuestionADD();
                QuizManager.newQuestion = question;
                QuizManager.newA1 = choice4;
                QuizManager.newA2 = choice2;
                QuizManager.newA3 = choice3;
                QuizManager.newA4 = choice1;
                actualAnswer = "4";
            }

            QuizManager.updateQuestion = false;
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
