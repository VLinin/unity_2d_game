using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tREX : MonoBehaviour
{
    public int jumpHeight = 250;
    public bool falling = false;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerPrefs.SetInt("speed", 10);
        PlayerPrefs.SetFloat("res", 0);
       
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
        if ((Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.UpArrow)) && falling==false)
        {
            rb.AddForce(Vector2.up * jumpHeight);
            falling = true;
        }
        
        PlayerPrefs.SetFloat("res", PlayerPrefs.GetFloat("res")+0.1f);
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Land")
        {
            falling = false;
        }
    }
}
