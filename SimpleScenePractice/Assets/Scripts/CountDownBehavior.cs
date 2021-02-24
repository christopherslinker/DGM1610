using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBehavior : MonoBehaviour
{
    public float holdTime = 1f;
    public int number;
    public Text countDownText;
    IEnumerator Start()
    {
        wfsOBJ = new WaitForSeconds(holdTime);
        
        while (number > 0)
        {
            wfsOBJ = new WaitForSeconds(holdTime);
            countDownText.text = number.ToString();
            number--;
        }

        countDownText.text = "GO!";

        yield return wfsOBJ;

        countDownText.text = null;
    }
    
