using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
	public int numberCount;
	public Text counterText;

    // Update is called once per frame
    void onTriggerEnter2D()
    {
        numberCount++;
		counterText.text = numberCount.ToString();
    }
}
