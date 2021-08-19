using UnityEngine;

public class SpeedBufFactory : ISpeedBufFactory
{
    private readonly SpeedBufData _speedBufData;    

    public SpeedBufFactory(SpeedBufData speedBufData)
    {
        _speedBufData = speedBufData;
        
    }

    public ISpeedBuf CreateSpeedBuf(int i)
    {
        var speedBuf = _speedBufData.GetSpeedBuf(i);
        var speedBufPosition = _speedBufData.GetSpeedBufPosition(i);
        return Object.Instantiate(speedBuf, speedBufPosition, Quaternion.identity);
    }

    public int SpeedBufCount()
    {
        return _speedBufData.SpeedBufCount();
    }

}
