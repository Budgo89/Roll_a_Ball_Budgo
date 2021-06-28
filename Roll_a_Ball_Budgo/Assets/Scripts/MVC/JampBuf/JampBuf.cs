using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Ball;

public class JampBuf : MonoBehaviour, IJampBuf
{
    public event Action<int>  OnTriggerEnterChange;
    [SerializeField] private float _jamp = 2f;
    [SerializeField] private float _time = 5f;
    private GameObject _baf;
    private Ball _ball;
    private float _timer;
    private bool _bufOn = false;
    private Slider _slider;

    private void Awake()
    {
        // Это временные заглушки
        _ball = GameObject.Find("RollerBall").GetComponent<Ball>();
        _slider = GameObject.Find("/Canvas/Slider Jamp Buf").GetComponent<Slider>();
        _slider.gameObject.SetActive(false);
    }

    private void JampBufMVS()
    {
        if (_bufOn == false)
        {
            _bufOn = true;
            _ball.m_JumpPower = _jamp;
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine(JampBufRoutine());
        }
    }
    private IEnumerator JampBufRoutine()
    {
        yield return new WaitForSeconds(_time);
        _ball.m_JumpPower = 0f;
        gameObject.SetActive(false);
        _bufOn = false;
    }
    private void TimeBuf()
    {
        _timer = _time;
        _slider. maxValue = _time;
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
            JampBufMVS();
            TimeBuf();
        }
    }
}
