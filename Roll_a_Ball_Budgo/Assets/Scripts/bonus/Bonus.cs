using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Ball;

public class Bonus : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jamp = 2f;
    [SerializeField] private float time = 5f;
    [SerializeField] private GameObject ball;
    
    
    private Ball _ball;
    protected float _speedBes;
    private float _timer;
    protected bool _bufOn = false;
    private void Awake()
    {
        _ball = ball.gameObject.GetComponent<Ball>();
        _speedBes = _ball.m_MovePower;
    }

    protected void SpeedBuf()
    {
        if (_bufOn == false)
        {
            _bufOn = true;
            _ball.m_MovePower = speed;
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine("SpeedBufRoutine");
        }

        
    }

    protected void JampBuf()
    {
        if (_bufOn == false)
        {
            _bufOn = true;
            _ball.m_JumpPower = jamp;
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine("JampBufRoutine");
        }

    }
    private IEnumerator SpeedBufRoutine()
    {
        yield return new WaitForSeconds(time);
        _ball.m_MovePower = _speedBes;
        gameObject.SetActive(false);
        _bufOn = false;
    }

    private IEnumerator JampBufRoutine()
    {
        yield return new WaitForSeconds(time);
        _ball.m_JumpPower = 0f;
        gameObject.SetActive(false);
        _bufOn = false;
    }

    protected void TimeBuf(Slider slider)
    {
        
            _timer = time;
            slider.maxValue = time;
            slider.value = _timer;
            slider.gameObject.SetActive(true);
            StartCoroutine(TimeBufRoutine(slider));

    }

    private IEnumerator TimeBufRoutine(Slider slider)
    {
        while (_timer >= 0)
        {
            _timer -= Time.deltaTime;
            slider.value = _timer;
            yield return null;    
        }
        slider.gameObject.SetActive(false);
    }
}
