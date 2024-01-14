using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScipt : MonoBehaviour
{
    public float pipeSpeed;
    private float deadZone = -22;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); //destroy cloud object once it crosses the window to left
        }
    }
}
