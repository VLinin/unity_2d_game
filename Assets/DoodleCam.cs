using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoodleCam : MonoBehaviour
{
    public Transform who;
    Vector3 position;

    void Start()
    {
        transform.position = who.position;
    }

    void Update()
    {
        position = who.position;
        position.z = -10f;
        position.x = 0.02f;
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
        if (who.position.y < (transform.position.y - 12))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
}
