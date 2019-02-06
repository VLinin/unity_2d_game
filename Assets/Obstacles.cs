using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject[] ob;
    public Transform campos;
    int type;
    float xx;
    int tekRes = 0;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleMaker();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
    }

    void ObstacleMaker()
    {
        tekRes = 0;
        type = Random.Range(0, ob.Length);
        GameObject clone = (GameObject)Instantiate(ob[type], transform.position,Quaternion.identity);
        
        clone.AddComponent<PolygonCollider2D>();
        clone.GetComponent<PolygonCollider2D>().isTrigger=true;
        Destroy(clone, 6);
        switch (type)
        {
            case 0:
                clone.name = "Type0";
                break;
            case 1:
                clone.name = "Type1";
                break;
            case 2:
                clone.name = "Type2";
                break;
            case 3:
                clone.name = "Type3";
                break;
            case 4:
                clone.name = "Type4";
                break;
        }
        Debug.Log(PlayerPrefs.GetFloat("res"));
        if (PlayerPrefs.GetFloat("res") > 250)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Doodle");
        }
            if (PlayerPrefs.GetFloat("res") > 150 && tekRes == 0)
        {
            xx = Random.Range(1, 1.25f);
           
            tekRes = 1;
            PlayerPrefs.SetInt("speed", 13);
        }
        if (PlayerPrefs.GetFloat("res") > 100 && tekRes == 0)
        {
            xx = Random.Range(1, 3);
            PlayerPrefs.SetInt("speed", 12);
          
            tekRes = 1;
        }
        if (PlayerPrefs.GetFloat("res") > 50 && tekRes == 0)
        {
            xx = Random.Range(1, 4);
            
            tekRes = 1;
            PlayerPrefs.SetInt("speed", 11);
        }
        if(tekRes==0)
        {
            xx = Random.Range(1, 5);
            
        }
        
        Invoke("ObstacleMaker", xx);
    }

    
}
