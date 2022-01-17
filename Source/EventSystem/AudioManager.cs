using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance = null;

    public AudioMixer effectGroup;
    public AudioMixer backgroudGroup;
    public AudioMixer natureGroup;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }
    void Start()
    {
        if (PlayerPrefs.HasKey("BackGroundVolume") == false)
        {
            PlayerPrefs.SetFloat("BackGroundVolume", 0f);
            PlayerPrefs.SetFloat("EffectVolume", 0f);
            PlayerPrefs.SetFloat("NatureVolume", 0f);
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetFloat("BackGroundVolume") == -20f)
        {
            backgroudGroup.SetFloat("Master", -80f);
        }
        else
        {
            backgroudGroup.SetFloat("Master", PlayerPrefs.GetFloat("BackGroundVolume"));

        }
        if (PlayerPrefs.GetFloat("EffectVolume") == -20f)
        {
            effectGroup.SetFloat("Master", -80f);
        }
        else
        {
            effectGroup.SetFloat("Master", PlayerPrefs.GetFloat("EffectVolume"));
        }

        if (PlayerPrefs.GetFloat("NatureVolume") == -20f)
        {
            natureGroup.SetFloat("Master", -80f);
        }
        else
        {
            natureGroup.SetFloat("Master", PlayerPrefs.GetFloat("NatureVolume"));
        }
    }
    public void SetSoundVolume()
    {
        if (PlayerPrefs.GetFloat("BackGroundVolume") == -20f)
        {
            backgroudGroup.SetFloat("Master", -80f);
        }
        else
        {
            backgroudGroup.SetFloat("Master", PlayerPrefs.GetFloat("BackGroundVolume"));

        }
        if (PlayerPrefs.GetFloat("EffectVolume") == -20f)
        {
            effectGroup.SetFloat("Master", -80f);
        }
        else
        {
            effectGroup.SetFloat("Master", PlayerPrefs.GetFloat("EffectVolume"));
        }

        if (PlayerPrefs.GetFloat("NatureVolume") == -20f)
        {
            natureGroup.SetFloat("Master", -80f);
        }
        else
        {
            natureGroup.SetFloat("Master", PlayerPrefs.GetFloat("NatureVolume"));
        }
    }
}
