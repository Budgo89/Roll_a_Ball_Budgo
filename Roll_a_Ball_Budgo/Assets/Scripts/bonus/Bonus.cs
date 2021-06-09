using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Ball;

public class Bonus : MonoBehaviour
{
    [SerializeField] protected float speed = 10f;
    [SerializeField] protected float jamp = 2f;
    [SerializeField] private float time = 5f;
    [SerializeField] private GameObject ball;
    
    private Ball _ball;
    protected float _speedBes;

    private void Awake()
    {
        _ball = ball.gameObject.GetComponent<Ball>();
        _speedBes = _ball.m_MovePower;
    }

    public void speedBuf()
    {
        _ball.m_MovePower = speed;
        gameObject.GetComponent<Renderer>().enabled = false;
        StartCoroutine("SpeedBufRoutine");
        
    }

    public void JampBuf()
    {
        _ball.m_JumpPower = jamp;
        gameObject.GetComponent<Renderer>().enabled = false;
        StartCoroutine("JampBufRoutine");
    }
    private IEnumerator SpeedBufRoutine()
    {
        yield return new WaitForSeconds(time);
        _ball.m_MovePower = _speedBes;
        gameObject.SetActive(false);
    }

    private IEnumerator JampBufRoutine()
    {
        yield return new WaitForSeconds(time);
        _ball.m_JumpPower = 0f;
        gameObject.SetActive(false);
    }
}
