using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{

    private float firstNumber;
    private float secondNumber;
    private float answer;
    private int QuestionCounter;

    public GameObject QuestionCounterText;
    public GameObject Question;
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;

    // Update is called once per frame
    void Start()
    {
        Question.GetComponent<TMP_Text>().text = "Hello World";
        Answer1.GetComponent<TMP_Text>().text = "Hi";
    }
        

    float GetAnswer()
    {
        return answer;
    }
}
