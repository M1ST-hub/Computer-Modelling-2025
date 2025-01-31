using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    private static AudioManager instance;
    
    public static AudioManager Instance {  get { return instance; } }

    public AudioMixer masterMixer;
    

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        masterMixer.SetFloat("MasterVol", PreferancesManager.GetMasterVolume());
        masterMixer.SetFloat("MasterVol", PreferancesManager.GetMusicVolume());
        
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }
}
