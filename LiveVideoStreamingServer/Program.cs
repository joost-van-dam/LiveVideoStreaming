using System;
using OBSWebsocketDotNet;

Console.WriteLine("Hello, World!");

var obs = new OBSWebsocket();

obs.ConnectAsync("ws://localhost:4455", "NECRZ46vwRR5i5ui");

//Met die 1sec sleep is hij connected
Thread.Sleep(1000);
Console.WriteLine(obs.IsConnected);
// Server IP (Best Guess): 10.0.0.9
// Server Port: 4455
// Server Password: NECRZ46vwRR5i5ui


public class LiveVideoStreamingServer
{
    private const string _serverIP = "10.0.0.9";
    private const int _serverPort = 4455;
    private const string _serverPassword = "NECRZ46vwRR5i5ui";

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var obs = new OBSWebsocket();

        obs.ConnectAsync("ws://localhost:4455", _serverPassword);

        //Met die 1sec sleep is hij connected
        Thread.Sleep(1000);
        Console.WriteLine($"OBS WebSocket connected: {0}", obs.IsConnected);

        //await obs.SendRequestAsync("SetCurrentScene", new { sceneName = "YourSceneName" });

    }


    private void SendRequestAsync(OBSWebsocket obs)
    {
        //return obs.SendRequest("SetCurrentScene", { sceneName = "YourSceneName" });

    }
}
