using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.5f;
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else{
            Debug.Log("there is no music player");
        }
    }
    public void SaveAndExit(){
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }
    public void SetDefault(){
        volumeSlider.value = defaultVolume;
    }
}
