using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public int jumpHeight = 20;
    float horizontal;
    public bool over;
    public GUIStyle style2;
    public Texture img;

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
        
        if(( col.gameObject.tag=="Basic platform" || col.gameObject.tag == "Begin platform" )&& (col.transform.position.y)<rb.position.y)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up*jumpHeight, ForceMode2D.Impulse);
        }
        if (col.gameObject.name == "kamen")
        {
            Time.timeScale = 0;
            over = true;
        }

    }
    void OnGUI()
    {
        if (over)
        {
            GUI.Label(new Rect(Screen.width * 0.3f, Screen.height * 0.45f, Screen.width * 0.75f, Screen.height * 0.25f), "Game Over !", style2);
            if (GUI.Button(new Rect(Screen.width * 0.48f, Screen.height * 0.55f, 50, 50f), img))
            {

                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1;
            }
        }
    }
}
