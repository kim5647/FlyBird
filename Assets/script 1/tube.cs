using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tube1 : MonoBehaviour
{
    bool washit = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!washit)
        {
            GameObject.FindWithTag("mapgen").GetComponent<mapgen>().addroom();
            washit = true;
        }
    }
}
