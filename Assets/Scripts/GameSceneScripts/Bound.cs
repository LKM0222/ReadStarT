using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour
{

    public BoxCollider2D bound;
    private CameraFollow theCamera;

    // Start is called before the first frame update
    void Start()
    {
        bound = GetComponent<BoxCollider2D>();
        theCamera = FindObjectOfType<CameraFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
