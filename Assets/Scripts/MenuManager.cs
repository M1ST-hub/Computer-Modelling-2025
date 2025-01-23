using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;



public class MenuManager : MonoBehaviour
{
    public Slider musicSlider, masterSlider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(musicSlider != null) 
        musicSlider.value = PreferancesManager.GetMusicVolume();

        if(masterSlider != null)
        masterSlider.value = PreferancesManager.GetMasterVolume();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
