using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granica : MonoBehaviour
{
    Transform player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = new Vector2(player.position.x, transform.position.y);
    }
}
