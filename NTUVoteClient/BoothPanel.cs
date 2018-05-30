using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace NTUOSC.Vote
{
    public partial class BoothPanel : UserControl
    {
        private States _state;
        private DateTime _lastUpdated;

        public BoothPanel()
        {
            InitializeComponent();
            _lastUpdated = DateTime.Now;
        }

        public BoothPanel(Control parent, int number) : this()
        {
            Number = number.ToString();
            parent.Controls.Add(this);
        }

        public enum States {
            Offline = 0,
            Available,
            InUse
        }

        public string Number {
            get { return numberLabel.Text; }
            set { numberLabel.Text = value; }
        }

        public States State {
            get { return _state; }
            set {
                _state = value;
                if (value != States.InUse)
                    _lastUpdated = DateTime.Now;
                UpdateControl();
            }
        }

        public DateTime LastUpdated {
            get { return _lastUpdated; }
            set {
                _lastUpdated = value;
                UpdateTimer();
            }
        }

        protected virtual void UpdateControl() {
            switch (_state) {
                case States.Available:
                    numberLabel.ForeColor = SystemColors.ControlText;
                    statLabel.ForeColor = SystemColors.ControlText;
                    statLabel.Text = "閒置";
                    break;
                case States.InUse:
                    numberLabel.ForeColor = SystemColors.ControlText;
                    statLabel.ForeColor = SystemColors.ControlText;
                    statLabel.Text = "投票中";
                    break;
                default:
                    numberLabel.ForeColor = SystemColors.GrayText;
                    statLabel.ForeColor = SystemColors.GrayText;
                    statLabel.Text = "離線";
                    break;
            }
            UpdateTimer();
        }

        public virtual void UpdateTimer() {
            if (_state == States.InUse) {
                TimeSpan delta = DateTime.Now - LastUpdated;
                timerLabel.Text = ((int)delta.TotalSeconds).ToString();
                this.BackColor = (delta.TotalSeconds > 120) ? Color.Salmon : Color.LightGreen;
            } else
                this.BackColor = (_state == States.Offline) ? Color.LightGray : Color.WhiteSmoke;
        }
    }
}
