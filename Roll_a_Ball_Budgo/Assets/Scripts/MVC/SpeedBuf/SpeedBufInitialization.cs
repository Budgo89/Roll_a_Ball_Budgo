using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.RollerBalls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedBufInitialization : IInitialization
{
    private readonly ISpeedBufFactory _speedBufFactory;
    private ISpeedBuf _speedBuf;
    private CanvasManager _canvasManager;
    private RollerBall _player;

    public SpeedBufInitialization(ISpeedBufFactory speedBufFactory, CanvasManager canvasManager, RollerBall player)
    {
        _speedBufFactory = speedBufFactory;
        _canvasManager = canvasManager;
        _player = player;
        for (int i = 0; i < _speedBufFactory.SpeedBufCount(); i++)
        {
            _speedBuf = _speedBufFactory.CreateSpeedBuf(i);
            _speedBuf.LinkToSliderBuf(SearchInCanvas("SpeedBufSlider").GetComponent<Slider>(), SearchInCanvas("SpeedDeBufSlider").GetComponent<Slider>(), _player);
        }        
        _speedBuf.FalseSlider();
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
