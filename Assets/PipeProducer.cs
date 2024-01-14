using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeProducer : MonoBehaviour
{
    public GameObject pipe;
    private float spwanRate = 1.9f;
    private float timer=0;
    private float pipeHieght = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
        {
            timer+=Time.deltaTime;
        }
        else
        {
            spawnPipe();   
            timer = 0;
        }
        
    }
    public void spawnPipe()
    {
        float lowestPoint = transform.position.y - pipeHieght;
        float highestPoint = transform.position.y + pipeHieght;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
        //Instantiate will help in producing the game objects constantly
    }
}
