using System.CodeDom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NAudio.Wave;

namespace schedulo;
public partial class FartButton : Button
{
    public FartButton()
    {
        this.Width = 100;
        this.Height = 100;
        
        this.Text = "пукнуть";
        this.Click += buttonClick;
    }

    private void buttonClick(object sender, EventArgs e) 
    {
        using (var audioFile = new AudioFileReader(@"D:\c#solutions\taskSCHEDULER\schedulo\bin\Debug\net8.0-windows\sound.mp3"))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(1000);
            }
        }
        
        MessageBox.Show("ТЫ ХУЕСОС");
    }
}