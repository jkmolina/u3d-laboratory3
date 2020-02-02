using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore++;
        Destroy(gameObject);
    }
}
