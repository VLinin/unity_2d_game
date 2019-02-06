using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over : MonoBehaviour
{
    public bool over;
    public GUIStyle style2;
    public Texture img;
    // Start is called before the first frame update
    void Start()
    {
        over = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.name)
        {
            case "Type0":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t0 /n");
                break;
            case "Type1":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t1 /n");
                break;
            case "Type2":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t2 /n");
                break;
            case "Type3":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t3 /n");
                break;
            case "Type4":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t4 /n");
                break;
            case "Type5":
                Time.timeScale = 0;
                over = true;
                Debug.Log("/n t5 /n");
                break;
        }
        //if (collider.name == "Quad1")
        //{
           // Time.timeScale = 0;
         //   over = true;
       // }
    }

    void OnGUI()
    {
        if (over)
        {
            GUI.Label(new Rect(Screen.width*0.3f,Screen.height*0.45f, Screen.width * 0.75f, Screen.height * 0.25f),"Game Over !", style2);
            if(GUI.Button(new Rect(Screen.width * 0.48f, Screen.height * 0.55f, 50, 50f), img))
            {
                
                UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
                Time.timeScale = 1;
            }
        }
    }
}
