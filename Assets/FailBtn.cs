using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailBtn : MonoBehaviour
{
    public void onClickButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
