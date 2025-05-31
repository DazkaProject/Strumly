using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{
    public Material outlineMaterial; // Призначте сюди матеріал з обводкою
    private Material originalMaterial;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            originalMaterial = objectRenderer.material; // Отримуємо копію оригінального матеріалу
        }
        else
        {
            Debug.LogError("Об'єкт не має компонента Renderer!");
            enabled = false;
        }
    }

    void OnMouseEnter()
    {
        if (objectRenderer != null && outlineMaterial != null)
        {
            objectRenderer.material = outlineMaterial;
        }
    }

    void OnMouseExit()
    {
        if (objectRenderer != null && originalMaterial != null)
        {
            objectRenderer.material = originalMaterial;
        }
    }

    void OnMouseUpAsButton()
    {
        // Цей метод викликається при відпусканні будь-якої кнопки миші над об'єктом
        if (Input.GetMouseButtonUp(0)) // 0 - це ліва кнопка миші
        {
            Debug.Log("Спроба вийти з гри лівою кнопкою миші."); // Доданий лог

#if UNITY_EDITOR
            Debug.Log("Вихід з редактора.");
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Debug.Log("Вихід з build'у.");
            Application.Quit();
#endif
            Debug.Log("Вихід з гри (після спроби)."); // Ще один лог
        }
    }
}
