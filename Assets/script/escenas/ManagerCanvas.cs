using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerCanvas : MonoBehaviour
{
    // Ajuste Volumen
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Slider sliderSet;
    // Panel
    public GameObject Panel;
    // Toggle
    public Toggle audioToggle;

    private void Start()
    {
        // Recupera el valor del volumen guardado en PlayerPrefs
        float savedVolume = PlayerPrefs.GetFloat("SavedVolume", 1.0f);
        audioSource.volume = savedVolume;
        volumeSlider.value = savedVolume;

        // Recupera el estado del audio guardado en PlayerPrefs
        bool savedAudioEnabled = PlayerPrefs.GetInt("SavedAudioEnabled", 1) == 1;
        audioSource.enabled = savedAudioEnabled;
        audioToggle.isOn = savedAudioEnabled;
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
        // Guarda el volumen actual en PlayerPrefs
        PlayerPrefs.SetFloat("SavedVolume", volume);
    }

    public void Niveles(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ActivatePanel()
    {
        Panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void DeactivatePanel()
    {
        Panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ToggleAudio(bool isOn)
    {
        // Activar o desactivar el AudioT según el estado del Toggle
        audioSource.enabled = isOn;
        // Guarda el estado del audio en PlayerPrefs
        PlayerPrefs.SetInt("SavedAudioEnabled", isOn ? 1 : 0);
    }
  }