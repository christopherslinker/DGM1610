using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutineEventBehaviour : MonoBehaviour
{

    public UnityEvent startEvent;
    public int number = 0, maxNumber;
    public float holdTime = 1f;
    private WaitForSeconds wfsOBJ;

    IEnumerator Start()
    {
        wfsOBJ = new WaitForSeconds(holdTime);

        while (number < maxNumber)
        {
            //startEvent.Invoke();
            yield return wfsOBJ;
            number++;
        }
    }

}
