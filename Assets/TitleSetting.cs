using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleSetting : MonoBehaviour
{
    public Slider VolumeSlider;
    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        float volume = PlayerPrefs.GetFloat("Volume");
        VolumeSlider.value = volume;
        AudioSource.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeVolume()
    {
        float volume = VolumeSlider.value;
        AudioSource.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
