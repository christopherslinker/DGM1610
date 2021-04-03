using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    public FloatData dataObj;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        img.fillAmount = dataObj.value;
    }
}
