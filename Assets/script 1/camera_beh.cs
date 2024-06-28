using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_beh : MonoBehaviour
{
    [SerializeField] Transform player;
    void LateUpdate()
    {
        Vector3 newPos = transform.position;
        newPos.x = player.position.x;
        transform.position = newPos;
    }
}
