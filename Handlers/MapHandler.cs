using System;
namespace MapControlDemo.Handlers
{
    partial class MapHandler
    {
        public static IPropertyMapper<MapView, MapHandler> MapMapper = new PropertyMapper<MapView, MapHandler>(ViewMapper)
        { };

        public MapHandler() : base(MapMapper)
        { }
    }
}

