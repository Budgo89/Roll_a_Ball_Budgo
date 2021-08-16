using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.ControlPoint;
using Assets.Scripts.MVC.Locations;
using Assets.Scripts.MVC.RollerBalls;
using Assets.Scripts.MVC.ZoneOuts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class GameInitialization
{
    public GameInitialization(Controllers controllers, Data data, CanvasManager convasManager)
    {        
        var convasFactory = new CanvasFactory(data.Canvas);
        var zoneOutFactory = new ZoneOutFactor(data.ZoneOut);
        var locationFactory = new LocationFactory(data.Location);        
        var convasInitialization = new CanvasInitialization(convasFactory, convasManager);
        var zoneOutInitialization = new ZoneOutInitialization(zoneOutFactory);
        var locationInitialization = new LocationInitialization(locationFactory);        
        controllers.Add(convasInitialization);
        controllers.Add(locationInitialization);
        controllers.Add(zoneOutInitialization);        
    }
}