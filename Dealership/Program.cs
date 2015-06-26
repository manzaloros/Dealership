using Topshelf;

namespace Dealership
{
    class Program
    {
        static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<DealershipServiceControl>(s =>
                {
                    s.ConstructUsing(name => new DealershipServiceControl());
                    s.WhenStarted((tc, hostControl) => tc.Start(hostControl));
                    s.WhenStopped((tc, hostControl) => tc.Stop(hostControl));
                });
                x.RunAsLocalSystem();

                x.SetDescription("");
                x.SetDisplayName("");
                x.SetServiceName("ThisService");
            });
        }
    }
}
