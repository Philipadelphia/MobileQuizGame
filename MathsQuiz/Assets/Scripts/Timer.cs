using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public static float timeStart;
    public GameObject timeText;
    public static bool startTimer = true;

    // Start is called before the first frame update
    void Start()
    {
        timeText.GetComponent<TMP_Text>().text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        {
            timeStart += Time.deltaTime;
            timeText.GetComponent<TMP_Text>().text = timeStart.ToString("F2");
        }
    }
}
