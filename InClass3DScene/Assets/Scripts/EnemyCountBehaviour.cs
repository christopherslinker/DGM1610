using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCountBehaviour : MonoBehaviour
{
    public IntData enemyCountData;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2.0f);
        print(enemyCountData.value);
    }
    
}
