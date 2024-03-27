using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject parents;
    public int spawnTime;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = (int)Random.Range(5, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if(time < spawnTime)
        {
            time = time + Time.deltaTime;
        }
        else
        {
            GameObject gobj = Instantiate(obstacle, transform.position, transform.rotation);
            gobj.transform.parent = parents.transform;
            time = 0f;
        }
            
    }
}
