using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Basic platform")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Begin platform")
        {

            Destroy(gameObject);
        }
        

    }
}
