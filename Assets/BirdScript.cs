using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicManager logicScript;
    public bool isBirdAlive;
    public AudioClip jumpSound;
    public AudioClip collide;
    // Start is called before the first frame update
    void Start()
    {
        isBirdAlive = true;
        gameObject.name = "Chirpy";
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        if (logicScript != null)
        {
            Debug.Log("LogicManager found : " + logicScript.gameObject.name);
        }
        else
        {
            Debug.LogError("LogicManager not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isBirdAlive)
        {
            AudioSource.PlayClipAtPoint(jumpSound, transform.position);
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(collide, transform.position);
        Debug.Log("********Collison occurred*********");
        isBirdAlive = false;
        logicScript.gameOver();
        
    }
}
