using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePipes : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-movespeed, 0);
        if (this.transform.position.x < -15f)
        {
            Destroy(this.gameObject);
        }
    }


}
