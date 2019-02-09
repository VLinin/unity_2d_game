using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamen : MonoBehaviour
{
    public GameObject ob;
    public Transform who;
    Vector3 position;
    Vector3 positionSpawn;
    // Start is called before the first frame update
    void Start()
    {
        position = who.position;
        position.y = position.y + 6;
        transform.position = position;
        ObstacleMaker();
    }

    // Update is called once per frame
    void Update()
    {
        position = who.position;
        position.y = position.y+6;
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
    }

    void ObstacleMaker()
    {
        positionSpawn = transform.position;
        positionSpawn.x = positionSpawn.x + Random.Range(-12, 12);
        positionSpawn.z = 0;

        GameObject clone = (GameObject)Instantiate(ob, positionSpawn, Quaternion.identity);

        clone.AddComponent<PolygonCollider2D>();
        clone.AddComponent<Rigidbody2D>();
        clone.AddComponent<destroyPlatform>();
        clone.name = "kamen";
       

        Invoke("ObstacleMaker", Random.Range(5f,13f));
    }

   
}
