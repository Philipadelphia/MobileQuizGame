using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{

    public static string newQuestion;
    public static string newA1;
    public static string newA2;
    public static string newA3;
    public static string newA4;

    public GameObject QuestionCounterText;
    public GameObject Question;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;
    public static bool updateQuestion = false;

    // Update is called once per frame
    void Update()
    {
        if (updateQuestion == false)
        {
            StartCoroutine(PushTextOnScreen());
            updateQuestion = true;
        }

    }
        

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        Question.GetComponent<TMP_Text>().text = newQuestion;
        QuestionCounterText.GetComponent<TMP_Text>().text = "Question: " + QuestionGenerator.questionNumber.ToString() + "/10";
        Answer1.GetComponent<TMP_Text>().text = newA1;
        Answer2.GetComponent<TMP_Text>().text = newA2;
        Answer3.GetComponent<TMP_Text>().text = newA3;
        Answer4.GetComponent<TMP_Text>().text = newA4;
    }
}
