using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    private Image img;
    public FloatData dataObj;
    public GameObject gameOverOBJ;
    public GameObject replayButton;
    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        if (img.fillAmount == 0)
        {
            gameOverOBJ.SetActive(true);
            //use this to stop the player
            //player.SetActive(false);
            replayButton.SetActive(true);
        }
        img.fillAmount = dataObj.value;
    }
}
