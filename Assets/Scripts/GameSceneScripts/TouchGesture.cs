using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGesture : MonoBehaviour
{
    private const float SwipeDis = 10;
    private Vector2 StartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartPos = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 p = (Vector2)Input.mousePosition - StartPos;

            if (Mathf.Abs(p.x) < SwipeDis && Mathf.Abs(p.y) < SwipeDis)
                GetClick();
            else
            {
                if (Mathf.Abs(p.x) > Mathf.Abs(p.y))
                    GetSwipe(StartPos, new Vector2(Mathf.Sign(p.x), 0));
                else if (Mathf.Abs(p.x) < Mathf.Abs(p.y))
                    GetSwipe(StartPos, new Vector2(0, Mathf.Sign(p.y)));
            }
        }
    }

    public virtual void GetClick() { }
    public virtual void GetSwipe(Vector2 StartPos, Vector2 dir) { }
}
