using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBehaviour : MonoBehaviour
{
    public int number = 3;
    public float holdTime = 1f;
    public string endText = "GO!";

    private Text countDownText;
    private WaitForSeconds wfsObj;

    private IEnumerator Start()
    {
        countDownText = GetComponent<Text>();
        wfsObj = new WaitForSeconds(holdTime);

        while (number > 0)
        {
            //countDownText = number.ToString();
            number--;
            yield return wfsObj;
        }

        countDownText.text = endText;
        yield return wfsObj;
        countDownText.text = null;
    }
}
