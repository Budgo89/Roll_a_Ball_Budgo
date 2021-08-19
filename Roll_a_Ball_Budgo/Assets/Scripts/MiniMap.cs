using Assets.Scripts.MVC.MiniMapsCamera;
using Assets.Scripts.MVC.RollerBalls;
using UnityEngine;

public class MiniMap : ILateExecute
{
    private Transform _player;
    private Transform _miniMapCamera;
    public MiniMap(RollerBall player, MiniMapCamera miniMapCamera)
    {
        _player = player.transform;
        _miniMapCamera = miniMapCamera.transform;
        _player = Camera.main.transform;
        _miniMapCamera.transform.parent = null;
        _miniMapCamera.transform.rotation = Quaternion.Euler(90.0f, 0, 0);
        _miniMapCamera.transform.position = _player.position + new Vector3(0, 5.0f, 0);

        var rt = Resources.Load<RenderTexture>("MiniMap/MiniMapTexture");

        _miniMapCamera.GetComponent<Camera>().targetTexture = rt;
    }

    public void LateExecute(float deltaTime)
    {
        var newPosition = _player.position;
        newPosition.y = _miniMapCamera.transform.position.y;
        _miniMapCamera.transform.position = newPosition;
        _miniMapCamera.transform.rotation = Quaternion.Euler(90, _player.eulerAngles.y, 0);
    }
}
