using Assets.Scripts.MVC;
using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.Controllers;
using Assets.Scripts.MVC.ControlPoint;
using Assets.Scripts.MVC.ExitPoints;
using Assets.Scripts.MVC.MiniMapsCamera;
using Assets.Scripts.MVC.RollerBalls;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Data _data;
    [SerializeField] private InputData _inputData;
    private Controllers _controllers;
    private CameraMainRotatison _cameraMainRotatison;
    private CanvasManager _canvasManager;
    private ListExecuteObject _interactiveObject;
    private InputController _inputController;

    private void Start()
    {
        _canvasManager = new CanvasManager();
        _controllers = new Controllers();
        _interactiveObject = new ListExecuteObject();
        new GameInitialization(_controllers, _data, _canvasManager);
        var exitPointFactory = new ExitPointFactory(_data.ExitPoint);
        var rollerBallFactory = new RollerBallFactory(_data.RollerBall);
        var speedBufFactory = new SpeedBufFactory(_data.SpeedBuf);
        var rollerBallInitialization = new RollerBallInitialization(rollerBallFactory);
        var controlPointsFactory = new ControlPointsFactory(_data.ControlPoints);
        var jampBufFactory = new JampBufFactory(_data.JampBuf);
        var miniMapCameraFactory = new MiniMapCameraFactory(_data.MiniMapCamera);
        _cameraMainRotatison = new CameraMainRotatison(rollerBallInitialization._rollerBall, _data.MainCamera);
        var speedBufInitialization = new SpeedBufInitialization(speedBufFactory, _canvasManager, rollerBallInitialization._rollerBall);
        var jampBufInitialization = new JampBufInitialization(jampBufFactory, _canvasManager, rollerBallInitialization._rollerBall);
        _controllers.Add(speedBufInitialization);        
        var exitPointInitialization = new ExitPointInitialization(exitPointFactory, _canvasManager);        
        _controllers.Add(exitPointInitialization);
        var victory = new Victory(exitPointInitialization._exitPoint, 3);
        var controlPointsInitialization = new ControlPointsInitialization(controlPointsFactory, victory, _canvasManager);
        var miniMapCameraInitialization = new MiniMapCameraInitialization(miniMapCameraFactory);
        _controllers.Add(controlPointsInitialization);
        _controllers.Add(rollerBallInitialization);
        _controllers.Add(jampBufInitialization);
        _controllers.Add(miniMapCameraInitialization);
        var miniMap = new MiniMap(rollerBallInitialization._rollerBall, miniMapCameraInitialization._miniMapCamera);
        _controllers.Add(miniMap);
        _controllers.Initialization();

        var restart = new RestartButton(_canvasManager);


        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            _inputController = new InputController(rollerBallInitialization._rollerBall, _inputData);
            _interactiveObject.AddExecuteObject(_inputController);
        }
    }

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _controllers.Execute(deltaTime);
        _cameraMainRotatison.Execute(deltaTime);

        for (var i = 0; i < _interactiveObject.Length; i++)
        {
            var interactiveObject = _interactiveObject[i];

            if (interactiveObject == null)
            {
                continue;
            }
            interactiveObject.Execute(deltaTime);
        }
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
