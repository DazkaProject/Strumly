using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMain : MonoBehaviour
{
    GameObject param;

    void Start()
    {
        param = GameObject.FindWithTag("Param");
        if (param != null)
        {
            Debug.Log("�������� ��'��� � ����� 'param': " + param.name);
            // ��� �� ������ ��������� � ��������� ��'�����
        }
        else
        {
            Debug.LogWarning("��'��� � ����� 'param' �� ��������!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
