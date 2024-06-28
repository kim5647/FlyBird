using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public GameObject[] objectsToSetActive;

    mapgen G;
    
    public TMP_Text Text;
    void Start()
    {
        G = GameObject.FindGameObjectWithTag("mapgen").GetComponent<mapgen>();
    }
    void Update()
    {
        Text.text = G.i.ToString();
    }
    public void pause()
    {
        Time.timeScale = 0;
    }

    public void start()
    {
        Time.timeScale = 1;
    }

    public void back()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    //bool prov1; 
    //bool prov2;
    //public void Prover()
    //{
    //    GameObject p1 = GameObject.FindGameObjectWithTag("Proverka1");
    //    GameObject p2 = GameObject.FindGameObjectWithTag("Proverka");

    //}

}
