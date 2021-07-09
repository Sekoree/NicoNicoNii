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
            //await nnd.LoginAsync("MAILTEL", "PW");
            var sess = await nnd.CheckSessionValidityAsync();
            Console.WriteLine("Is session valid? " + sess);
            var vidClient = new NicoVideoClient(nnd);
            await vidClient.GetWatchPageInfoAsync("sm29442394");
        }
    }
}
