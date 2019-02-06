using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public int jumpHeight = 20;
    float horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 7f, rb.velocity.y);
    }

    
    public void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag=="Basic platform"&&(col.transform.position.y+1f)<rb.position.y)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up*jumpHeight, ForceMode2D.Impulse);
        }
        

    }
}
