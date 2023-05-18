using UnityEngine;
using UnityEngine.UI;

public class Settings : Menu
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Button exitButton;

    public override void Initialize()
    {
        volumeSlider.onValueChanged.AddListener(SetVolume);
        volumeSlider.value = audioSource.volume;
        exitButton.onClick.AddListener(ExitSettings);
    }

    private void SetVolume(float value)
    {
        audioSource.volume = value;
    }

    private void ExitSettings()
    {
        menuManager.Back();
    }
}