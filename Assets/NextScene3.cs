using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene3 : MonoBehaviour
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
        UnityEngine.SceneManagement.SceneManager.LoadScene("boss");
        return "";
    }
}
