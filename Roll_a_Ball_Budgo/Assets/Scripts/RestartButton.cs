using Assets.Scripts.MVC.Canvass;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton
{
    public Button _restart;
    public Text _text;
    private CanvasManager _canvasManager;

    public RestartButton(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
        _restart = SearchInCanvas("Restart").GetComponent<Button>();
        _text = SearchInCanvas("Text").GetComponent<Text>();
        _restart.onClick.AddListener(RestartLevel);
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        _text.text = " ";
    }

    private GameObject SearchInCanvas(string teg)
    {
        for (int i = 0; i < _canvasManager.canvasManager.Count; i++)
        {
            if (String.Equals(_canvasManager.canvasManager[i].teg, teg))
            {
                var canvasInfo = _canvasManager.canvasManager[i]._gameObject.gameObject;
                return canvasInfo;
            }
        }
        return null;
    }
}
