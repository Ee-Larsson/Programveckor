using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer mainMixer;

    public void SetVolume(float volume)
    {
        // Adjust "volume" parameter in the AudioMixer
        mainMixer.SetFloat("volume", volume);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    public void Mainmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start Menu");
    }
}
