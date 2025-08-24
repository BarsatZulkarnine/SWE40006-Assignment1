using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace RGB.Dependency
{
    public class BackgroundColorChanger
    {
        private Form _targetForm;
        private Timer _colorTimer;
        private int _colorIndex = 0;

        private Color[] _colors = new Color[]
        {
            Color.FromArgb(255, 99, 71),   // Red
            Color.FromArgb(30, 144, 255), // Blue
            Color.FromArgb(50, 205, 50),  //Green
            
        };

        public BackgroundColorChanger(Form form)
        {
            _targetForm = form;
            _colorTimer = new Timer();
            _colorTimer.Interval = 5000; 
            _colorTimer.Tick += OnTimerTick;
            _colorTimer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _targetForm.BackColor = _colors[_colorIndex];
            _colorIndex = (_colorIndex + 1) % _colors.Length;
        }

        public void Stop()
        {
            _colorTimer.Stop();
        }

        public void Start()
        {
            _colorTimer.Start();
        }
    }
}
