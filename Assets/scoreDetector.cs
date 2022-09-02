using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2d(Collider2D col)
    {
        //Update UI
        ScoreCounterUI.instance.AddPoint();
        Debug.Log("Collided");
    }
}
