using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
   [SerializeField] private Button _restart;
   [SerializeField] private Text _text;

    private void Awake()
    {
        _restart.onClick.AddListener(RestartLevel);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        _text.text = " ";
    }
}
