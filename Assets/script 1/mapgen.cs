using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapgen : MonoBehaviour
{
    [SerializeField]GameObject[] tubes;
    Vector3 israel_boom;
    int x = 0;
    public int i = -2;
    private void Start()
    {
        Application.targetFrameRate = 300;
        addroom();
        addroom();
    }
    public void addroom()
    {
        x += 20;
        Instantiate(tubes[UnityEngine.Random.Range(0, 8)]).transform.localPosition = new Vector2(x, 0);
        i++;
    }
}
