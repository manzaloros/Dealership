using System;
using Microsoft.Owin.Hosting;
using Topshelf;

namespace Dealership
{
    public class DealershipServiceControl : ServiceControl
    {
        private IDisposable app;
            
        public bool Start(HostControl hostControl)
        {
            app = WebApp.Start<Startup>("http://*:8008");
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            app.Dispose();
            return true;
        }
    }
}
