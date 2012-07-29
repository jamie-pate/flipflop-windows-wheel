using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Principal;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!hasAdministrativeRight) {
                RunElevated(Application.ExecutablePath);
                this.Close();
                Application.Exit();
            }
        }
        private static bool RunElevated(string fileName)
        {
            //MessageBox.Show("Run: " + fileName);
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.Verb = "runas";
            processInfo.FileName = fileName;
            try
            {
                Process.Start(processInfo);
                return true;
            }
            catch (Win32Exception)
            {
                //Do nothing. Probably the user canceled the UAC window
            }
            return false;
        }
        

        private void btn_flip_Click(object sender, EventArgs e) {
            setFlip(true);
        }

        private void btn_normal_Click(object sender, EventArgs e) {
            setFlip(false);
        }

        private void setFlip(bool p) {
            using (RegistryKey hid = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\HID\",false)) {
                foreach (string devicekn in hid.GetSubKeyNames()) {
                    using (RegistryKey device = hid.OpenSubKey(devicekn,false)) {
                        foreach (string devicekn2 in device.GetSubKeyNames()) {
                            using (RegistryKey device2 = device.OpenSubKey(devicekn2,false)) {
                                using (RegistryKey devparam = device2.OpenSubKey("Device Parameters",true)) {
                                    if (devparam != null) {
                                        devparam.SetValue("FlipFlopWheel", p ? 1 : 0,RegistryValueKind.DWord);
                                        listView1.Items.Add((string)device2.GetValue("DeviceDesc")).SubItems.Add(p ? "Flipped" : "Normal");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
