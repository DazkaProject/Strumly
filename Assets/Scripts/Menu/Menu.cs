using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject main_panel;
    public GameObject ex_panel;
    public GameObject songs_panel;

    public Param param;

    private void Start()
    {
        main_panel.SetActive(true);
        ex_panel.SetActive(false);
        songs_panel.SetActive(false);
    }
    public void Songs()
    {
        main_panel.SetActive(false);
        ex_panel.SetActive(false);
        songs_panel.SetActive(true);
    }

    public void GoToEx()
    {
        main_panel.SetActive(false);
        ex_panel.SetActive(true);
        songs_panel.SetActive(false);
    }

    public void Back()
    {
        main_panel.SetActive(true);
        ex_panel.SetActive(false);
        songs_panel.SetActive(false);
    }

    public void loadEx1()
    {
        param.type = "ex1";
        SceneManager.LoadScene(1);
    }

    public void loadEx2()
    {
        param.type = "ex2";
        SceneManager.LoadScene(1);
    }

    public void loadLAcords()
    {
        param.type = "lAcords";
        SceneManager.LoadScene(1);
    }

    public void loadSongTab(GameObject obj)
    {
        param.song = obj;
        param.type = "STab";

        
        SceneManager.LoadScene(1);
    }

    public void loadSongBiy(GameObject obj)
    {
        param.song = obj;
        param.type = "SFight";
        
        
        SceneManager.LoadScene(1);
    }
}
