using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudProducer : MonoBehaviour
{
    public GameObject cloud;
    private float spwanRate = 2;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer= 0;
        }
    }
    public void spawnCloud()
    {
        Instantiate(cloud, new Vector3(transform.position.x, transform.position.y,0), transform.rotation);
    }
}
