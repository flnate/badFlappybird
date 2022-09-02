using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class playerController : MonoBehaviour
{

    public float velocity = 1;
    private Rigidbody2D rb;
    public float timer;
    public float timeUntilpress;
    


    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = Time.time;
        timeUntilpress = 0.2f;

        

       

    } 

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeUntilpress) 
        {
            if (Input.GetKeyDown("space"))
            {
                rb.velocity = Vector2.up * velocity;
                timer = 0;
            }



        }
        
    }

    
}
