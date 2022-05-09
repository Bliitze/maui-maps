using System;
using Android.Gms.Maps;
using Android.OS;
using Java.Interop;
using Microsoft.Maui.Handlers;

namespace MapControlDemo.Handlers
{
    public partial class MapHandler : ViewHandler<MapView, Android.Gms.Maps.MapView>
    {
        public MapHandler(IPropertyMapper mapper, CommandMapper commandMapper = null) : base(mapper, commandMapper)
        { }

        protected override Android.Gms.Maps.MapView CreatePlatformView()
        {
            return new Android.Gms.Maps.MapView(Context);
        }

        protected override void ConnectHandler(Android.Gms.Maps.MapView platformView)
        {
            base.ConnectHandler(platformView);
        }
    }
}

