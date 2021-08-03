using Assets.Scripts.MVC.Data;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
public class Data : ScriptableObject
{
    
    [SerializeField] private string _jampDataPath;
    [SerializeField] private string _speedDataPath;
    [SerializeField] private string _controlPointsDataPath;
    [SerializeField] private string _locationDataPath;
    [SerializeField] private string _canvasDataPath;
    [SerializeField] private string _rollerBallPath;
    [SerializeField] private string _exitPointPath;

    private JampBufData _jampBuf;
    private SpeedBufData _speedBuf;
    private ControlPointsData _controlPoints;
    private LocationData _location;
    private CanvasData _canvas;
    private RollerBallData _rollerBall;
    private Camera _mainCamera;
    private ExitPointData _exitPoint;

    public JampBufData JampBuf
    {
        get
        {
            if (_jampBuf == null)
            {
                _jampBuf = Load<JampBufData>("Data/" + _jampDataPath);
            }

            return _jampBuf;
        }
    }

    public SpeedBufData SpeedBuf
    {
        get
        {
            if (_speedBuf==null)
            {
                _speedBuf = Load<SpeedBufData>("Data/" + _speedDataPath);
            }

            return _speedBuf;
        }
    }

    public ControlPointsData ControlPoints
    {
        get
        {
            if (_controlPoints == null)
            {
                _controlPoints = Load<ControlPointsData>("Data/" + _controlPointsDataPath);
            }
            return _controlPoints;
        }
    }

    public LocationData Location
    {
        get
        {
            if (_location == null)
            {
                _location = Load<LocationData>("Data/" + _locationDataPath);
            }
            return _location;
        }
    }
    public CanvasData Canvas
    {
        get
        {
            if (_canvas == null)
            {
                _canvas = Load<CanvasData>("Data/" + _canvasDataPath);
            }
            return _canvas;
        }
    }
    public RollerBallData RollerBall
    {
        get
        {
            if(_rollerBall == null)
            {
                _rollerBall = Load<RollerBallData>("Data/" + _rollerBallPath);
            }
            return _rollerBall;
        }
    }
    public Camera MainCamera
    {
        get
        {
            if (_mainCamera == null)
            {
                _mainCamera = Camera.main;
            }
            return _mainCamera;
        }
    }

    public ExitPointData ExitPoint
    {
        get
        {
            if (_exitPoint == null)
            {
                _exitPoint = Load<ExitPointData>("Data/" + _exitPointPath);
            }
            return _exitPoint;
        }
    }

    private T Load<T>(string resourcesPath) where T : Object =>
        Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));

}

