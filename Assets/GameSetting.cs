using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        float volume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
