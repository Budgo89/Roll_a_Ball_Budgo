using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.ControlPoint;
using Assets.Scripts.MVC.ExitPoints;
using Assets.Scripts.MVC.RollerBalls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Data _data;
    private Controllers _controllers;
    private CameraMainRotatison _cameraMainRotatison;
    private CanvasManager _canvasManager;

    private void Start()
    {
        _canvasManager = new CanvasManager();
        _controllers = new Controllers();
        new GameInitialization(_controllers, _data, _canvasManager);
        var exitPointFactory = new ExitPointFactory(_data.ExitPoint);
        var rollerBallFactory = new RollerBallFactory(_data.RollerBall);
        var speedBufFactory = new SpeedBufFactory(_data.SpeedBuf);
        var rollerBallInitialization = new RollerBallInitialization(rollerBallFactory);
        var controlPointsFactory = new ControlPointsFactory(_data.ControlPoints);
        var jampBufFactory = new JampBufFactory(_data.JampBuf);
        _cameraMainRotatison = new CameraMainRotatison(rollerBallInitialization._rollerBall, _data.MainCamera);
        var speedBufInitialization = new SpeedBufInitialization(speedBufFactory, _canvasManager, rollerBallInitialization._rollerBall);
        var jampBufInitialization = new JampBufInitialization(jampBufFactory, _canvasManager, rollerBallInitialization._rollerBall);
        _controllers.Add(speedBufInitialization);
        
        var exitPointInitialization = new ExitPointInitialization(exitPointFactory, _canvasManager);        
        _controllers.Add(exitPointInitialization);
        var victory = new Victory(exitPointInitialization._exitPoint, 3);
        var controlPointsInitialization = new ControlPointsInitialization(controlPointsFactory, victory, _canvasManager);
        _controllers.Add(controlPointsInitialization);
        _controllers.Add(rollerBallInitialization);
        _controllers.Add(jampBufInitialization);
        _controllers.Initialization();

    }

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _controllers.Execute(deltaTime);
        _cameraMainRotatison.Execute(deltaTime);
    }

    private void LateUpdate()
    {
        var deltaTime = Time.deltaTime;
        _controllers.LateExecute(deltaTime);
    }

    private void OnDestroy()
    {
        _controllers.Cleanup();
    }
}
