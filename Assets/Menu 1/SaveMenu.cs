using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveMenu : MonoBehaviour
{
    public GameObject buttenON;
    public GameObject buttenOFF;
    bool Prov1;
    bool Prov2;

    private void Start()
    {
        if(PlayerPrefs.GetInt("Prov1", 1) == 0)
        {
            Prov1 = true;
        }
        else
        {
            Prov1 = false;
        }
        if(PlayerPrefs.GetInt("Prov2", 1) == 0)
        {
            Prov2 = true;
        }
        else 
        {
            Prov2 = false;
        }
        if(PlayerPrefs.GetInt("Prov1", 1) == 0)
        {
            GetOFF();
        }
        if (Prov1 == false && Prov2 == false)
        {
            Prov1 = false;
            Prov2 = true;
        }
    }
    public void musicON()
    {
        GameObject musicPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        if (musicPlayer != null)
        {
            AudioSource audioSource = musicPlayer.GetComponent<AudioSource>();
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        Prov1 = false;
        Prov2 = true;
        SaveData();
    }

    private void GetOFF()
    {
        GameObject musicPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        AudioSource audioSource = musicPlayer.GetComponent<AudioSource>();
        audioSource.Stop();
    }

    public void musicOFF()
    {
        GameObject musicPlayer = GameObject.FindGameObjectWithTag("MusicPlayer");
        if (musicPlayer != null)
        {
            AudioSource audioSource = musicPlayer.GetComponent<AudioSource>();
            if (audioSource != null && audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }
        Prov1 = true;
        Prov2 = false;
        SaveData();
    }
    public void Prover()
    {
        buttenOFF.SetActive(Prov1); 
        buttenON.SetActive(Prov2);
        
        
        SaveData();
    }

    private void SaveData()
    {
        if(Prov1 == true)
        {
            PlayerPrefs.SetInt("Prov1", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Prov1", 1);
        }
        if(Prov2 == true)
        {
            PlayerPrefs.SetInt("Prov2", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Prov2", 1);
        }
        PlayerPrefs.Save();
    }
}
