using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeAndroidStyle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
            this.TopMost = true;

            ytBrowser.Navigate("about:blank");
            if (ytBrowser.Document != null)
            {
                ytBrowser.Document.Write(string.Empty);
            }
            
            ytBrowser.Url = new Uri(String.Format("file://" + Path.GetFullPath("./html/index.html")));
        }
    }
}
