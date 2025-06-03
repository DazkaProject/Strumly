using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayMain : MonoBehaviour
{
    
    public Metronome met;
    public GameObject ac;
    public GameObject tabs;
    public GameObject biy;

    public Image TabsIm;
    public Image BiyIm;
    public TMP_Text Acord;
    public TMP_Text NextAcord;
    public GuitarLads gl;

    Animator animator;
    Param param;
    Song song;

    void Start()
    {
        animator = GetComponent<Animator>();
        param = GameObject.FindWithTag("Param").GetComponent<Param>();
        if (param != null)
        {
            Debug.Log("«найдено об'Їкт з тегом 'param'");
            switch (param.type)
            {
                case "lAcords":
                    met.bpm = 60.0f;
                    ac.SetActive(true);
                    animator.SetInteger("i", 1);
                    break;
                case "ex1":
                    met.bpm = 60.0f;
                    met.nExc = 1;
                    animator.SetInteger("i", 2);
                    Debug.Log("¬иконано");
                    break;
                case "ex2":
                    met.bpm = 60.0f;
                    met.nExc = 2;
                    animator.SetInteger("i", 1);
                    break;
                case "STab":
                    animator.SetInteger("i", 1);
                    Instantiate(param.song);
                    SongLoad(true);
                    tabs.SetActive(true);
                    break;
                case "SFight":
                    animator.SetInteger("i", 0);
                    Instantiate(param.song);
                    SongLoad(false);
                    biy.SetActive(true);
                    break;
            }
            param = null;
            Destroy(GameObject.FindWithTag("Param"));
        }
        else
        {
            Debug.LogWarning("ќб'Їкт з тегом 'param' не знайдено!");
        }
    }

    void SongLoad(bool t)
    {
        song = GameObject.FindWithTag("Song").GetComponent<Song>();

        song.metronome = met;
        song.gl = gl;

        if (t)
        {
            song.TabsIm = TabsIm;
        }
        else
        {
            song.BiyIm = BiyIm;
            song.Acord = Acord;
            song.NextAcord = NextAcord;
        }
        song.Go();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
