using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Ball;

public class SpeedBuf : MonoBehaviour, ISpeedBuf
{
    public event Action<int>  OnTriggerEnterChange;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float time = 5f;
    
    private Ball _ball;
    private float _speedBas;
    private float _timer;
    protected bool _bufOn = false;
    private Slider _slider;
    private Slider _sliderBuf;
    private Slider _sliderDeBuf;

    public void LinkToSliderBuf(Slider sliderBuf, Slider sliderDeBuf, GameObject ball)
    {
        _sliderBuf = sliderBuf;
        _sliderDeBuf = sliderDeBuf;
        _ball = ball.GetComponent<Ball>();
        _speedBas = _ball.m_MovePower;
    }

    public void FalseSlider()
    {
        _sliderBuf.gameObject.SetActive(false);
        _sliderDeBuf.gameObject.SetActive(false);
    }
    
    private void SpeedBufMVS()
    {
        if (_bufOn == false)
        {
            _bufOn = true;
            if (speed > _ball.m_MovePower) _slider = _sliderBuf;
            else _slider = _sliderDeBuf;
            _ball.m_MovePower = speed;
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine(SpeedBufRoutine());        
        }
    }
    private IEnumerator SpeedBufRoutine()
    {
        yield return new WaitForSeconds(time);
        _ball.m_MovePower = _speedBas;
        gameObject.SetActive(false);
        _bufOn = false;
    }

    private void TimeBuf()
    {
        _timer = time;
        _slider.maxValue = time;
        _slider.value = _timer;
        _slider.gameObject.SetActive(true);
        StartCoroutine(TimeBufRoutine());
    }

    private IEnumerator TimeBufRoutine()
    {
        while (_timer >= 0)
        {
            _timer -= Time.deltaTime;
            _slider.value = _timer;
            yield return null;    
        }
        _slider.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_bufOn == false)
        {
            SpeedBufMVS();
            TimeBuf();
        }
    }

}
