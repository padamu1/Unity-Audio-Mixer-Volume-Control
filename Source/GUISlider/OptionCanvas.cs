using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionCanvas : MonoBehaviour
{
    public Canvas optionCanvas;
    public CanvasGroup optionScreen;
    public CanvasGroup bigMapScreen;

    public Slider backGroundVolume;
    public Slider effectVolume;
    public Slider natureVolume;

    void Start()
    {
        optionScreen.alpha = 0;
        optionCanvas.enabled = false;
        optionScreen.interactable = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionScreen.alpha == 0)
            {
                backGroundVolume.value = PlayerPrefs.GetFloat("BackGroundVolume");
                effectVolume.value = PlayerPrefs.GetFloat("EffectVolume");
                natureVolume.value = PlayerPrefs.GetFloat("NatureVolume");
                optionScreen.alpha = 1;
                optionCanvas.enabled = true;
                optionScreen.interactable = true;
                MouseEvent.bindActive = false;
            }
            else
            {
                optionScreen.alpha = 0;
                optionCanvas.enabled = false;
                optionScreen.interactable = false;
                MouseEvent.bindActive = true;
            }
        }
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("BackGroundVolume", backGroundVolume.value);
        PlayerPrefs.SetFloat("EffectVolume", effectVolume.value);
        PlayerPrefs.SetFloat("NatureVolume", natureVolume.value);
        AudioManager.instance.SetSoundVolume();
        PlayerPrefs.Save();
    }
    
    public void MainOut()
    {
        SceneManager.LoadScene("Menu");
    }
}
