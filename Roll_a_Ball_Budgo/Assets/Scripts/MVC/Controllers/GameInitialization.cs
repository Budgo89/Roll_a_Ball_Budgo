using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.ControlPoint;
using Assets.Scripts.MVC.Locations;
using Assets.Scripts.MVC.RollerBalls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class GameInitialization
{
    public GameInitialization(Controllers controllers, Data data, CanvasManager convasManager)
    {        
        var convasFactory = new CanvasFactory(data.Canvas);
        
        
        
        var locationFactory = new LocationFactory(data.Location);        
        var convasInitialization = new CanvasInitialization(convasFactory, convasManager);
        
        
        
        var locationInitialization = new LocationInitialization(locationFactory);        
        controllers.Add(convasInitialization);
        controllers.Add(locationInitialization);
        
    }
}