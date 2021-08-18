// By Nirex @ github.com/nirex0

using System;
using System.ComponentModel;

namespace XControls.Core
{
    public delegate void LerpEventHandler(object sender, float value);

    public class Lerp
    {   
        private readonly BackgroundWorker LerpWorker = new();

        private float internalValue;
        private bool isPaused;

        public event LerpEventHandler OnTick;
        public event LerpEventHandler OnDone;
        public event LerpEventHandler OnStart;
        public event LerpEventHandler OnPause;

        public float First { get; set; }
        public float Second { get; set; }
        public float Alpha { get; set; }
        public float Min { get; set; }
        public int Delay { get; set; }

        public Lerp()
        {
            isPaused = true;

            First = 0;
            Second = 100;
            Alpha = 0.5f;
            Min = 1;
            Initialize();
        }        
        public Lerp(float first, float second, float alpha, float min, int delay = 1)
        {
            isPaused = true;

            First = first;
            Second = second;
            Alpha = alpha;
            Min = min;
            Delay = delay;
            Initialize();
        }
        public void Start()
        {
            if (isPaused == true)
            {
                isPaused = false;
                LerpWorker.RunWorkerAsync();
                OnLerpStart();
            }
        }        
        public void Pause()
        {
            if (isPaused == false)
            {
                isPaused = true;
                OnLerpPause();
            }
        }        
        private void Initialize()
        {
            LerpWorker.DoWork += LerpWorker_DoWork;
            LerpWorker.RunWorkerCompleted += LerpWorker_RunWorkerCompleted;
            if (Delay < 1) { Delay = 1; }
        }        

        private void LerpWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            First += (Second - First) * Alpha;
            internalValue = First;
            System.Threading.Thread.Sleep(Delay);
        }        
        private void LerpWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {   
            // Don't do anything if the class is paused
            if (isPaused) return;

            OnLerpTick();
            
            if (IsCloserThan(First, Second, Min))            
                OnLerpDone();

            // Pause could be triggered in the if statement above within the body of OnLerpDone method.
            if (!isPaused) LerpWorker.RunWorkerAsync();
        } 

        protected virtual void OnLerpTick()
        {
            OnTick?.Invoke(this, internalValue);
        }        
        protected virtual void OnLerpDone()
        {
            isPaused = true;
            OnDone?.Invoke(this, internalValue);
        }        
        protected virtual void OnLerpStart()
        {
            OnStart?.Invoke(this, internalValue);
        }
        protected virtual void OnLerpPause()
        {
            OnPause?.Invoke(this, internalValue);
        }

        private bool IsCloserThan(float a, float b, float value)
        {
            return MathF.Abs(a - b) < value;
        }
    }
}
