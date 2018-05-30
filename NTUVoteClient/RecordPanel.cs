using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace NTUOSC.Vote
{
    public partial class RecordPanel : UserControl
    {
        public RecordPanel()
        {
            InitializeComponent();
        }

        public string StudentId {
            get { return studentIdLabel.Text; }
            set { studentIdLabel.Text = value; }
        }

        public string Status {
            get { return statusLabel.Text; }
            set { statusLabel.Text = value; }
        }
    }
}
