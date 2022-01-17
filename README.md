# Unity-Audio-Mixer-Volume-Control
using c# on Unity 3D

### Audio Mixer Code 
```
        // Set up when program start
        if (PlayerPrefs.GetFloat("BackGroundVolume") == -20f)
        {
            backgroudGroup.SetFloat("Master", -80f);
        }
        else
        {
            backgroudGroup.SetFloat("Master", PlayerPrefs.GetFloat("BackGroundVolume"));

        }

```

### Slider Code
```
    // volume save & change System Volume
    public void Save()
    {
        PlayerPrefs.SetFloat("BackGroundVolume", backGroundVolume.value);
        PlayerPrefs.SetFloat("EffectVolume", effectVolume.value);
        PlayerPrefs.SetFloat("NatureVolume", natureVolume.value);
        AudioManager.instance.SetSoundVolume();
        PlayerPrefs.Save();
    }
```