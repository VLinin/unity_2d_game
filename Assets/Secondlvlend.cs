using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secondlvlend : MonoBehaviour
{
    public bool over;
    public GUIStyle style2;
    public Texture img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Stage3");

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
