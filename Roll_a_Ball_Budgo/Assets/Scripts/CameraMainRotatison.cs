using Assets.Scripts.MVC.RollerBalls;
using UnityEngine;

public class CameraMainRotatison : IExecute
{
    private RollerBall _player;
    private Camera _mainCamera;
    private Vector3 _offset;

    public CameraMainRotatison(RollerBall player, Camera mainCamera)
    {
        _player = player;
        _mainCamera = mainCamera;
        _offset = _mainCamera.transform.position - _player.transform.position;
    }

    public void Execute(float deltaTime)
    {
        _mainCamera.transform.position = _player.transform.position + _offset;
    }
}
