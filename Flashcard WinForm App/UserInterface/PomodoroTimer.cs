using Flashcard_WinForm_App.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class PomodoroTimer : UserControl
    {
        private int timeLeftInSeconds;
        private PomodoroState currentState = PomodoroState.Idle;

        [DefaultValue(0)]
        public int WorkDurationMinutes { get; set; } = 25;
        [DefaultValue(0)]
        public int BreakDurationMinutes { get; set; } = 5;

        public event EventHandler? OnBreakStarted;
        public event EventHandler? OnBreakEnded;
        public event EventHandler? OnBreakStopped;

        public PomodoroTimer()
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            this.BackColor = Theme.BackgroundColor;
            countdownTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            countdownTimer.Tick += CountdownTimer_Tick;
        }

        public void StartTimer()
        {
            if (currentState == PomodoroState.Idle)
            {
                currentState = PomodoroState.Working;
                timeLeftInSeconds = WorkDurationMinutes * 60;
            }
            countdownTimer.Start();
        }

        public void StopTimer()
        {
            countdownTimer.Stop();
            currentState = PomodoroState.Idle;

            timeLeftInSeconds = WorkDurationMinutes * 60;
            UpdateDisplay(timeLeftInSeconds);

            OnBreakStopped?.Invoke(this, EventArgs.Empty);
        }

        private void CountdownTimer_Tick(object? sender, EventArgs e)
        {
            if (timeLeftInSeconds > 0)
            {
                timeLeftInSeconds--;
                UpdateDisplay(timeLeftInSeconds);
            }
            else
            {
                TransitionState();
            }
        }

        private void TransitionState()
        {
            countdownTimer.Stop();

            if (currentState == PomodoroState.Working)
            {
                currentState = PomodoroState.OnBreak;
                timeLeftInSeconds = BreakDurationMinutes * 60;

                OnBreakStarted?.Invoke(this, EventArgs.Empty);

                countdownTimer.Start();
            }
            else
            {
                currentState = PomodoroState.Idle;
                timeLeftInSeconds = WorkDurationMinutes * 60;

                OnBreakEnded?.Invoke(this, EventArgs.Empty);

                UpdateDisplay(timeLeftInSeconds);
            }
        }

        private void UpdateDisplay(int seconds)
        {
            lblTimer.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }
    }
}
