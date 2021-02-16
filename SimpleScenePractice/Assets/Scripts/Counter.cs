using System;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int CoinValue = 3;
    public IntData numberCount;
    public Text counterText;

    private void Start()
    {
        counterText.text = numberCount.value.ToString();
    }

    void OnTriggerEnter2D()
    {
        numberCount.value += CoinValue;
        counterText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }
}