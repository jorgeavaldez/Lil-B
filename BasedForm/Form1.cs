﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasedForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Creates a sound playback object
            SoundPlayer bitch = new SoundPlayer("bitch.wav");
            //Plays "Bitch I'm lil B"
            bitch.Play();
        }
    }
}
