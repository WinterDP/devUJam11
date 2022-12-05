using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.AI;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    [SerializeField] private Slider slider;	  //Referenciando slider da cena e CM VCam 1

    public static float mainVolume = 1;

	// Carrega a cena de id 1
    public void PlayGame()
    {
        
        AudioManager.instance.StopSound("Menu");
        if(PlayerData.instance.IsPaused)
            PlayerData.instance.IsPaused = !PlayerData.instance.IsPaused;
        

    }

    public void SettingsMenu()
    {
        Debug.Log("Load Settings");
        SceneManager.LoadScene("MenuConfig");
    }
	
    public void Main()
    {
        Debug.Log("Load Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }

    public void SetMasterVolume(){
        if (slider != null)
        {
            Debug.Log(slider.value);
            mainVolume = slider.value;
            AudioListener.volume = mainVolume;
        }        
    }



    private void Start()
    {
        AudioManager.instance.PlaySound("Main_Music");
        
        AudioListener.volume = mainVolume;
        if (slider != null){
            slider.value = mainVolume;
            slider.onValueChanged.AddListener(delegate { SetMasterVolume(); }); 
        }
        
    }

}
