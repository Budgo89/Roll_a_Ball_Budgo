using Assets.Scripts.MVC.Canvass;
using Assets.Scripts.MVC.Locations;
using Assets.Scripts.MVC.MiniMaps;
using Assets.Scripts.MVC.ZoneOuts;

internal sealed class GameInitialization
{
    public GameInitialization(Controllers controllers, Data data, CanvasManager convasManager)
    {        
        var convasFactory = new CanvasFactory(data.Canvas);
        var zoneOutFactory = new ZoneOutFactor(data.ZoneOut);
        var locationFactory = new LocationFactory(data.Location);
        var miniMapCanvasFactory = new MiniMapCanvasFactory(data.MiniMapCanvas);        
        var convasInitialization = new CanvasInitialization(convasFactory, convasManager);
        var zoneOutInitialization = new ZoneOutInitialization(zoneOutFactory);
        var locationInitialization = new LocationInitialization(locationFactory);
        var miniMapCanvasInitialization = new MiniMapCanvasInitialization(miniMapCanvasFactory);        
        controllers.Add(convasInitialization);
        controllers.Add(locationInitialization);
        controllers.Add(zoneOutInitialization);
        controllers.Add(miniMapCanvasInitialization);
        
    }
}