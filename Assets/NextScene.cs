using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", 2.5f);

    }

    void update() {
        
    }
    public string LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        return "";
    }
}
