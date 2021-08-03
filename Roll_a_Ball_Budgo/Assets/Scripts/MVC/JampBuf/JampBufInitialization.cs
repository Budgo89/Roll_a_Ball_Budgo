using Assets.Scripts.MVC.Canvass;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal sealed class JampBufInitialization : IInitialization
{
    private readonly IJampBufFactory _jampBufFactory;
    private IJampBuf _jampBuf;
    private CanvasManager _canvasManager;
    private GameObject _player;

    public JampBufInitialization(IJampBufFactory jampBufFactory, CanvasManager canvasManager, GameObject player)
    {
        _jampBufFactory = jampBufFactory;
        _canvasManager = canvasManager;
        _player = player;
        _jampBuf = _jampBufFactory.CreateJampBuf();
        _jampBuf.LinkToSlider(SearchInCanvas("JampBufSlider").GetComponent<Slider>(), _player);
    }
    public void Initialization()
    {
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
