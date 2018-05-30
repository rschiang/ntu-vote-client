using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace NTUOSC.Vote
{
    public partial class LoadingDialog : Form
    {
        public LoadingDialog()
        {
            InitializeComponent();
        }

        public void SetImage(string name)
        {
            image.ImageLocation = Path.GetFullPath(String.Format("Resources\\{0}.gif", name));
        }

        public void ShowCentered(Form parent)
        {
            Show(parent);
            Location = new Point(parent.Location.X + (parent.Width - Width) / 2, parent.Location.Y + (parent.Height - Height) / 2);
        }
    }
}
