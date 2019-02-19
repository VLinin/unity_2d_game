using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene2 : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadScene", 2.5f);

    }

    void update()
    {

    }
    public string LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Doodle");
        return "";
    }
}
