using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGShift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        //float width = ((BoxCollider2D)col).size.x;
        float width = 7f;
        Vector3 pos = col.transform.position;
        
        if (col.gameObject.tag=="BG1")
        {
            pos.x = pos.x + 41f;
            //pos.y = 1.73f;
            
            col.transform.position = pos;
        }
        if (col.gameObject.tag == "BG2")
        {
            pos.x = pos.x + 41f;//width * 2f;
            //pos.y = 1.73f;
            col.transform.position = pos;
           
        }
        
    }
}
