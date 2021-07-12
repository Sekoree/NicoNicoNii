using System;
using System.Threading.Tasks;

namespace NicoNicoNii.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var nnd = new NNDClient();
            //await nnd.LoginAsync("MAILTEL", "PASS");
            //await nnd.LogoutAsync();
            var sess = await nnd.CheckSessionValidityAsync();
            Console.WriteLine("Is session valid? " + sess);
            var vidClient = new NicoVideoClient(nnd);
            var watch = await vidClient.GetWatchPageInfoAsync("sm29442394");
            await vidClient.InitializeNonMemberSessionAsync(watch);
            var sessVid = await vidClient.GetHLSVideoApiResponseAsync(watch);
            var sessVid2 = await vidClient.GetHTTPVideoApiResponseAsync(watch);
        }
    }
}
