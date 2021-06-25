using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitPoint : MonoBehaviour
{
    [SerializeField] private Text _text;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        _text.text = "Уровень завершён";
        // Debug.Log("Уровень завершён");
    }
}
