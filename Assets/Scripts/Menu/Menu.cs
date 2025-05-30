using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject main_panel;
    public GameObject ex_panel;
    public GameObject songs_panel;
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
}
