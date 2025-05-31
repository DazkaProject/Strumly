using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnHover : MonoBehaviour
{
    public Material outlineMaterial; // ��������� ���� ������� � ��������
    private Material originalMaterial;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            originalMaterial = objectRenderer.material; // �������� ���� ������������ ��������
        }
        else
        {
            Debug.LogError("��'��� �� �� ���������� Renderer!");
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
        // ��� ����� ����������� ��� ��������� ����-��� ������ ���� ��� ��'�����
        if (Input.GetMouseButtonUp(0)) // 0 - �� ��� ������ ����
        {
            Debug.Log("������ ����� � ��� ���� ������� ����."); // ������� ���

#if UNITY_EDITOR
            Debug.Log("����� � ���������.");
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Debug.Log("����� � build'�.");
            Application.Quit();
#endif
            Debug.Log("����� � ��� (���� ������)."); // �� ���� ���
        }
    }
}
