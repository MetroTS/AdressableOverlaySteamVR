using System;
using System.Windows.Forms;
using AdressableOverlayVR.Forms;
using AdressableOverlayVR.Vr;


namespace AdressableOverlay
{
    internal static class MainProgramm
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitVR.Initialize();
            Application.Run(new AOVR());
            InitVR.Shutdown();
        }
        static void Sub()
        {
            Console.WriteLine("wickerwickerwicker");
        }
    }
}
