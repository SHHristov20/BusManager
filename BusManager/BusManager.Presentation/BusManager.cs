using BusManager.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;
using BusManager.Data.Data.Contexts;
using BusManager.Data.Data.Repositories;
using BusManager.Core.Interfaces;
using BusManager.Core.Implementations;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BusManager.Presentation
{
    internal static class BusManager
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
        ApplicationConfiguration.Initialize();
            WindowManager windowManager = WindowManager.Instance;
            Application.Run(windowManager);
        }
    }
}