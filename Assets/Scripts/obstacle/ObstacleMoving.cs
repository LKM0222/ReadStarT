using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    public float speed;
    public bool trueIsleft = true;
    // Update is called once per frame
    void Update()
    {
        if (trueIsleft)
            this.transform.position =
                new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
        else
            this.transform.position =
                new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
