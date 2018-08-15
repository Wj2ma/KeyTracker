using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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

        private const int KPS_WINDOW = 1000;
        private const int INTERVAL_CHECK = 50;
        private static Color RED = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
        private static Color GREEN = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(255)))), ((int)(((byte)(95)))));
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
        Dictionary<Keys, bool> pressed = new Dictionary<Keys, bool>() {
            { Keys.A, false },
            { Keys.S, false },
            { Keys.Oem1, false },
            { Keys.Oem7, false }
        };

        public KeyTracker() {
            InitializeComponent();
            hook.KeyDown += KeyPressed;
            hook.KeyUp += KeyReleased;
            this.MouseDown += OnMouseDown;
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e) {
            fields[STATS.Status] = StatusBox;
            fields[STATS.Kps] = KpsBox;
            fields[STATS.PeakKps] = PeakKpsBox;
            fields[STATS.TotalKeys] = TotalKeysBox;
            fields[STATS.ElapsedTime] = TimeBox;

            arrows[Keys.A] = LeftBox;
            arrows[Keys.S] = DownBox;
            arrows[Keys.Oem1] = UpBox;
            arrows[Keys.Oem7] = RightBox;

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
            switch (key) {
                case Keys.A:
                case Keys.S:
                case Keys.Oem1:
                case Keys.Oem7:
                    if (started && !pressed[key]) {
                        ++totalKeys;
                        pressed[key] = true;
                        times.Enqueue(timer.ElapsedMilliseconds);
                        fields[STATS.TotalKeys].Text = totalKeys.ToString();

                        UpdateKps();
                        UpdateArrows();
                    }
                    break;
                case Keys.R:
                    if (Alt) {
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
                    break;
            }
        }

        private void KeyReleased(Keys key, bool Shift, bool Ctrl, bool Alt) {
            //pressed[key] = false;
            //UpdateArrows();
            switch (key) {
                case Keys.A:
                case Keys.S:
                case Keys.Oem1:
                case Keys.Oem7:
                    pressed[key] = false;
                    UpdateArrows();
                    break;
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