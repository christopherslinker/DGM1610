using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class CountDownBehavior : MonoBehaviour
{
    public int number = 3;
    public float holdTime = 1f;
    public Text countDownText;

    private WaitForSeconds wfsOBJ;

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
}
    
    
