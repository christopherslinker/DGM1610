/*using UnityEngine;
using System.Collections;

public class AxisExample : MonoBehaviour
{
    public float range;
        public UI.Text textOutput;
     THIS LINE OF CODE MAKES IT NOT WORK?
     
    
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: "+h.ToString("F2");  
    }
}

THE CODE FOR SOME REASON WILL NOT WORK. THE TEXT OUTPUT FUNCTION IS OBSOLETE OR DOESN'T WORK?
*/