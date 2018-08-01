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

        const int KPS_WINDOW = 1000;
        const int INTERVAL_CHECK = 50;

        public KeyTracker() {
            InitializeComponent();
            hook.KeyDown += KeyPressed;
            hook.KeyUp += KeyReleased;
        }

        private void Form1_Load(object sender, EventArgs e) {
            fields[STATS.Status] = StatusBox;
            fields[STATS.Kps] = KpsBox;
            fields[STATS.PeakKps] = PeakKpsBox;
            fields[STATS.TotalKeys] = TotalKeysBox;
            fields[STATS.ElapsedTime] = ElapsedTimeBox;

            arrows[Keys.A] = LeftBox;
            arrows[Keys.S] = DownBox;
            arrows[Keys.Oem1] = UpBox;
            arrows[Keys.Oem7] = RightBox;

            interval.Tick += new EventHandler(IntervalProcessor);
            interval.Interval = INTERVAL_CHECK;
        }

        private void KeyPressed(Keys key, bool Shift, bool Ctrl, bool Alt) {
            switch (key) {
                case Keys.A:
                case Keys.S:
                case Keys.Oem1:
                case Keys.Oem7:
                    if (started && !pressed[key]) {
                        ++totalKeys;
                        pressed[key] = true;
                        times.Enqueue(timer.ElapsedMilliseconds);
                        fields[STATS.TotalKeys].Text = "Total Keys: " + totalKeys;

                        UpdateKps();
                        UpdateArrows();
                    }
                    break;
                case Keys.R:
                    if (Alt) {
                        if (started) {
                            fields[STATS.Status].Text = "STOPPED";
                            timer.Stop();
                            interval.Stop();
                        } else {
                            fields[STATS.Status].Text = "STARTED";
                            peakKps = 0;
                            totalKeys = 0;
                            times.Clear();
                            fields[STATS.Kps].Text = "KPS: " + times.Count;
                            fields[STATS.PeakKps].Text = "Peak KPS: " + peakKps;
                            fields[STATS.TotalKeys].Text = "Total Keys: " + totalKeys;
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
            fields[STATS.ElapsedTime].Text = "Elapsed Time: " + timer.ElapsedMilliseconds / 1000.0;
            UpdateKps();
        }

        private void UpdateKps() {
            while (times.Count > 0 && (times.Peek() + KPS_WINDOW <= timer.ElapsedMilliseconds)) {
                times.Dequeue();
            }

            int kps = (int)(times.Count * (1000.0 / KPS_WINDOW));
            fields[STATS.Kps].Text = "KPS: " + kps;
            if (kps > peakKps) {
                peakKps = kps;
                fields[STATS.PeakKps].Text = "Peak KPS: " + peakKps;
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
    }
}