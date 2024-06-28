using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fps : MonoBehaviour
{
    public TMP_Text fpsText;
    // ���������� ��� �������� �������� ������� ����� ������������ �����
    public float deltaTime;

    void Update()
    {
        // ������������ deltaTime, �������� ��� �� ��������� ����������
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        // ������������ FPS
        float fps = 1.0f / deltaTime;

        // ���������� FPS � ������� Text
        fpsText.text = Mathf.Ceil(fps).ToString();
    }
}
