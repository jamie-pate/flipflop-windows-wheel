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
        private Flippable[] flippable;
        private void Form1_Load(object sender, EventArgs e) {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!hasAdministrativeRight) {
                RunElevated(Application.ExecutablePath);
                this.Close();
                Application.Exit();
            }

            //probably only want to flip mice.
            flippable = getFlippable("hid.mousedevice");
            dgv_flippable.DataSource = flippable;
            foreach (var col in dgv_flippable.Columns.OfType<DataGridViewCheckBoxColumn>()) {
                col.TrueValue = true;
                col.FalseValue = false;
                col.IndeterminateValue = null;
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

        private Flippable[] getFlippable(string filter) {
            List<Flippable> flips = new List<Flippable>();
            using (RegistryKey hid = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\HID\",false)) {
                foreach (string devicekn in hid.GetSubKeyNames()) {
                    using (RegistryKey device = hid.OpenSubKey(devicekn,false)) {
                        foreach (string devicekn2 in device.GetSubKeyNames()) {
                            using (RegistryKey device2 = device.OpenSubKey(devicekn2,false)) {
                                using (RegistryKey devparam = device2.OpenSubKey("Device Parameters",true)) {
                                    if (devparam != null) {
                                        flips.Add(new Flippable(new string[] { devicekn, devicekn2 }, device2, devparam, tmr_popup));
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (filter != null) {
                return flips.Where(f=>f.deviceDesc.Contains(filter)).ToArray();
            }
            return flips.ToArray();
        }

        private void dgv_flippable_MouseUp(object sender, MouseEventArgs e) {
            dgv_flippable.EndEdit();
        }

        private void button1_Click(object sender, EventArgs e) {
            flippable = getFlippable(null);
            dgv_flippable.DataSource = flippable;
        }

        private void btn_flip_Click(object sender, EventArgs e) {
            foreach (var f in flippable) {
                f.vertical = true;
                f.horizontal = true;
            }
            dgv_flippable.DataSource = null;
            dgv_flippable.DataSource = flippable;
        }

        private void btn_normal_Click(object sender, EventArgs e) {
            foreach (var f in flippable) {
                f.vertical = false;
                f.horizontal = false;
            }
            dgv_flippable.DataSource = null;
            dgv_flippable.DataSource = flippable;
        }

        private void tmr_popup_Tick(object sender, EventArgs e) {
            tmr_popup.Enabled = false;
            notifyIcon1.ShowBalloonTip(99999999);
        }
    }

    public class Flippable {
        public Flippable(string[] keyPath, RegistryKey deviceKey, RegistryKey devparam, Timer timer) {
            this._keyPath = keyPath;
            IEnumerable<bool?> flipValues = Flippable.valueNames
                .Select(v => onlyIntBool(devparam.GetValue(v, null)));
            this.name = (string)deviceKey.GetValue("Driver", defaultValue: "No driver found");
            this.deviceDesc = (string)deviceKey.GetValue("DeviceDesc");
            this._vertical = flipValues.ElementAt(0);
            this._horizontal = flipValues.ElementAt(1);
            this._timer = timer;
        }
        private bool? onlyIntBool(object value) {
            try {
                return value == null ? null : (bool?)(((int)value) != 0);
            } catch {
                return null;
            }
        }
        public static string[] valueNames = new string[] { "FlipFlopWheel", "FlipFlopHScroll" };

        public string name { get; private set; }
        internal string deviceDesc { get; private set; }
        private string[] _keyPath;
        private bool? _vertical;
        private bool? _horizontal;
        Timer _timer;
        public bool? vertical { set { flip(Flippable.valueNames[0], value); _vertical = value; } get { return _vertical; } }
        public bool? horizontal { set { flip(Flippable.valueNames[1], value); _horizontal = value; } get { return _horizontal; } }

        public void flip(string valueName, bool? value) {
            using (RegistryKey hid = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Enum\HID\", false)) {
                using (RegistryKey device = hid.OpenSubKey(_keyPath[0], false)) {
                    using (RegistryKey device2 = device.OpenSubKey(_keyPath[1], false)) {
                        using (RegistryKey devparam = device2.OpenSubKey("Device Parameters", true)) {
                            if (value == null) {
                                devparam.DeleteValue(valueName);
                            } else {
                                devparam.SetValue(valueName, value == true ? 1 : 0);
                                _timer.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

    }
}
