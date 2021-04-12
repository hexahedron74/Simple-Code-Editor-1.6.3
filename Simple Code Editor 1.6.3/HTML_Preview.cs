using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Code_Editor_1._6._3
{
    public partial class HTML_Preview : Form
    {
        public HTML_Preview(string file)
        {
            InitializeComponent();
            webBrowser1.DocumentText = file;
            webBrowser2.DocumentText = file;
        }
    }
}
