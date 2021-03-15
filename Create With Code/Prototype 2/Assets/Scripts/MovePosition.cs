using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class MovePosition : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private Vector3 direction = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        //this is bad using "new" keyword. It garbage collects
        //direction = new Vector3(1, 0, 0);
        //you won't need this line of code now that it's in the update method.
       // direction.Set(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //This is in class coding.
        horizontalInput = Input.GetAxis("Horizontal");
        direction.Set(horizontalInput * speed, 0, 0);
        transform.Translate(direction * Time.deltaTime);
    }
}
