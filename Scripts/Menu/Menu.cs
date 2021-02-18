using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject settings;
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "GameScene")
        {
            Loading.Switch("Menu");
        }
    }
    public void LoadGame()// сохранение в игре
    {
    
    }
    public void Settings()
    {
        settings.SetActive(!settings.activeSelf);
    }
    public void ExitGame()
    {
        Application.Quit(1);
    }
    public void SetMusic(float value)
    {
        Global.music = value;
    }
    public void SetSound(float value)
    {
        Global.sound = value;
    }
}
