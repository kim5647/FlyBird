using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpid = 1;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Time.time * scrollSpid, 0);
    }
}
