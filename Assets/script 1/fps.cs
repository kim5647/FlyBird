using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fps : MonoBehaviour
{
    public TMP_Text fpsText;
    // Переменная для хранения текущего времени между обновлениями кадра
    public float deltaTime;

    void Update()
    {
        // Рассчитываем deltaTime, усредняя его за несколько обновлений
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        // Рассчитываем FPS
        float fps = 1.0f / deltaTime;

        // Отображаем FPS в объекте Text
        fpsText.text = Mathf.Ceil(fps).ToString();
    }
}
