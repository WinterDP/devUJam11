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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Load game");
        AudioManager.instance.StopSound("Menu");
        
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
        /*
        //AudioListener.volume = mainVolume;
        if (slider != null){
            slider.value = mainVolume;
            slider.onValueChanged.AddListener(delegate { SetMasterVolume(); }); 
        }
            

        
        if (!(AudioManager.instance.IsPlaying("Menu")) && SceneManager.GetActiveScene().name == "MainMenu")
        {
            AudioManager.instance.PlaySound("Menu");
        }
        */
        Cursor.visible = true;
        
    }

}
