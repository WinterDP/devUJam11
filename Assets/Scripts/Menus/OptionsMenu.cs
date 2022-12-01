using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer mainAudioMixer;

    public void setVolume(float volume){
        mainAudioMixer.SetFloat("MainVolume", volume);
        
    }

    public void BackToMenu()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("MainMenu");
    }
}
