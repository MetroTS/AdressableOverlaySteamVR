using System;
using Valve.VR;

class Program
{
    static void Main()
    {
        EVRInitError err = EVRInitError.None;
        OpenVR.Init(ref err, EVRApplicationType.VRApplication_Overlay);

        Console.WriteLine("OpenVR init: " + err);
    }
}

namespace AdressableOverlay
{
    public partial class WristOverlay()
    {
         InitializeComponent
    }
}