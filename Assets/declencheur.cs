using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declencheur : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log("Score " + score);
    }
}
