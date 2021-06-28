using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class GameInitialization
{
    public GameInitialization(Controllers controllers, Data data)
    {
        var jampBufFactory = new JampBufFactory(data.JampBuf);
        var speedBufFactory = new SpeedBufFactory(data.SpeedBuf);
        var jampBufInitialization = new JampBufInitialization(jampBufFactory);
        var speedBufInitialization = new SpeedBufInitialization(speedBufFactory);
        controllers.Add(jampBufInitialization);
        controllers.Add(speedBufInitialization);
    }
}
