using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitPoint : MonoBehaviour, IExitPoint
{
    private Text _text;

    public void LinkToText(Text text)
    {
        _text = text;
    }
    public void ExitPointOff()
    {
        this.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        _text.text = "Уровень завершён";
    }
}
