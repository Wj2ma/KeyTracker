using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyTracker {
    public partial class KeyTracker : Form {
        enum STATS {
            Status = 0,
            Kps = 1,
            PeakKps = 2,
            TotalKeys = 3,
            ElapsedTime = 4
        }

        private Dictionary<string, Keys> keyMap = new Dictionary<string, Keys>() {
            { "[", Keys.OemOpenBrackets },
            { "]", Keys.OemCloseBrackets },
            { ";", Keys.OemSemicolon },
            { "'", Keys.OemQuotes },
            { ",", Keys.Oemcomma },
            { ".", Keys.OemPeriod },
            { "/", Keys.OemQuestion },
            { "-", Keys.OemMinus},
            { "=", Keys.Oemplus },
            { "LEFT", Keys.Left },
            { "DOWN", Keys.Down },
            { "UP", Keys.Up },
            { "RIGHT", Keys.Right },
            { "NUM0", Keys.NumPad0 },
            { "NUM1", Keys.NumPad1 },
            { "NUM2", Keys.NumPad2 },
            { "NUM3", Keys.NumPad3 },
            { "NUM4", Keys.NumPad4 },
            { "NUM5", Keys.NumPad5 },
            { "NUM6", Keys.NumPad6 },
            { "NUM7", Keys.NumPad7 },
            { "NUM8", Keys.NumPad8 },
            { "NUM9", Keys.NumPad9 },
        };

        private const int KPS_WINDOW = 1000;
        private const int INTERVAL_CHECK = 50;
        private static Color RED = Color.FromArgb(255, 0, 48);
        private static Color GREEN = Color.FromArgb(95, 255, 95);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        KeyboardHook hook = new KeyboardHook(true);
        Dictionary<STATS, Label> fields = new Dictionary<STATS, Label>();
        Dictionary<Keys, Label> arrows = new Dictionary<Keys, Label>();

        Stopwatch timer = new Stopwatch();
        Timer interval = new Timer();
        int peakKps = 0;
        int totalKeys = 0;
        bool started = false;
        Queue<long> times = new Queue<long>();
        Keys[] keys = new Keys[4];
        Dictionary<Keys, bool> pressed;

        public KeyTracker() {
            InitializeComponent();

            hook.KeyDown += KeyPressed;
            hook.KeyUp += KeyReleased;
            this.MouseDown += OnMouseDown;

            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.txt"));

            keys[0] = getKey(config.Left);
            keys[1] = getKey(config.Down);
            keys[2] = getKey(config.Up);
            keys[3] = getKey(config.Right);
            pressed = keys.ToDictionary(x => x, x => false);

            this.TopMost = config.Overlay;
        }

        private void Form1_Load(object sender, EventArgs e) {
            fields[STATS.Status] = StatusBox;
            fields[STATS.Kps] = KpsBox;
            fields[STATS.PeakKps] = PeakKpsBox;
            fields[STATS.TotalKeys] = TotalKeysBox;
            fields[STATS.ElapsedTime] = TimeBox;

            arrows[keys[0]] = LeftBox;
            arrows[keys[1]] = DownBox;
            arrows[keys[2]] = UpBox;
            arrows[keys[3]] = RightBox;

            interval.Tick += new EventHandler(IntervalProcessor);
            interval.Interval = INTERVAL_CHECK;
        }

        private void OnMouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void KeyPressed(Keys key, bool Shift, bool Ctrl, bool Alt) {
            //if (started && !pressed[key]) {
            //    ++totalKeys;
            //    pressed[key] = true;
            //    times.Enqueue(timer.ElapsedMilliseconds);
            //    fields[STATS.TotalKeys].Text = "Total Keys: " + totalKeys;

            //    UpdateKps();
            //    UpdateArrows();
            //}
            if (started && keys.Contains(key)) {
                if (started && !pressed[key]) {
                    ++totalKeys;
                    pressed[key] = true;
                    times.Enqueue(timer.ElapsedMilliseconds);
                    fields[STATS.TotalKeys].Text = totalKeys.ToString();

                    UpdateKps();
                    UpdateArrows();
                }
            } else if (Alt && key == Keys.R) {
                if (started) {
                    fields[STATS.Status].BackColor = RED;
                    timer.Stop();
                    interval.Stop();
                } else {
                    fields[STATS.Status].BackColor = GREEN;
                    peakKps = 0;
                    totalKeys = 0;
                    times.Clear();
                    fields[STATS.Kps].Text = times.Count.ToString();
                    fields[STATS.PeakKps].Text = peakKps.ToString();
                    fields[STATS.TotalKeys].Text = totalKeys.ToString();
                    timer.Reset();
                    timer.Start();
                    interval.Start();
                }
                started = !started;
            }
        }

        private void KeyReleased(Keys key, bool Shift, bool Ctrl, bool Alt) {
            if (keys.Contains(key)) {
                pressed[key] = false;
                UpdateArrows();
            }
        }

        private void IntervalProcessor(Object obj, EventArgs eventArgs) {
            fields[STATS.ElapsedTime].Text = String.Format("{0:0.00}", timer.ElapsedMilliseconds / 1000.0);
            UpdateKps();
        }

        private void UpdateKps() {
            while (times.Count > 0 && (times.Peek() + KPS_WINDOW <= timer.ElapsedMilliseconds)) {
                times.Dequeue();
            }

            int kps = (int)(times.Count * (1000.0 / KPS_WINDOW));
            fields[STATS.Kps].Text = kps.ToString();
            if (kps > peakKps) {
                peakKps = kps;
                fields[STATS.PeakKps].Text = peakKps.ToString();
            }
        }

        private void UpdateArrows() {
            foreach (var arrow in pressed) {
                if (arrow.Value) {
                    arrows[arrow.Key].BackColor = Color.MediumSlateBlue;
                } else {
                    arrows[arrow.Key].BackColor = Color.OldLace;
                }
            }
        }

        private Keys getKey(string key) {
            key = key.ToUpper();
            if (keyMap.ContainsKey(key)) {
                return keyMap[key];
            }
            return (Keys)key[0];
        }

        private void DownBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void TotalKeysBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void PeakKpsBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void KpsBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void RightBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void UpBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void TimeBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void LeftBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void TimeLabel_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void TotalKeysLabel_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void PeakKpsLabel_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void KpsLabel_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        private void StatusBox_MouseDown(object sender, MouseEventArgs e) {
            OnMouseDown(sender, e);
        }

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}