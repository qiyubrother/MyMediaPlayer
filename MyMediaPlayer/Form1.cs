using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;

namespace MyMediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            btnOpenFile.Click += (o, ex) => {
                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            };

        }
    }
}
