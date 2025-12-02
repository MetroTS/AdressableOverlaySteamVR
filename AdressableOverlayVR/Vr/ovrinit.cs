using Valve.VR;
using System;

namespace AdressableOverlayVR.Vr
{
    public static class InitVR
    {
        public static bool IsInitialized = false;

        public static void Initialize()
        {
            EVRInitError error = EVRInitError.None;

            OpenVR.Init(ref error, EVRApplicationType.VRApplication_Overlay);

            if (error != EVRInitError.None)
                Console.WriteLine("OpenVR initialization failed: " + error);

            if (OpenVR.Overlay == null)
                Console.WriteLine("OpenVR Overlay not available " + error);
            IsInitialized = true;
        }

        public static void Shutdown()
        {
            if (IsInitialized)
                OpenVR.Shutdown();
        }
    }
}