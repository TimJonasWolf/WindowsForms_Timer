using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Timer
{
	public partial class Form1 : Form
	{
		private TimeSpan timeL;
		Boolean weiter = true;
		public Form1()
		{
			InitializeComponent();
		}


		private void timer_Tick(object sender, EventArgs e)
		{
			timeL = timeL.Add(TimeSpan.FromSeconds(1)); // mit Add addiert und zb mit Subtract geht es ins minus

			label1.Text = timeL.ToString(@"hh\:mm\:ss"); // @ ist ein zeichen der dokumentation ka für was aber zeigt einfach strings
			if (timeL.TotalSeconds >= 30) 
			{
				timer.Stop();
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			timeL = new TimeSpan(Convert.ToInt32(timeL.TotalHours), Convert.ToInt32(timeL.TotalMinutes), Convert.ToInt32(timeL.TotalSeconds));
			label1.Text = timeL.ToString(@"hh\:mm\:ss");
			timer.Start();

			if (timeL.TotalSeconds == 30) 
			{
				timeL = new TimeSpan(0, 0, 0);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			timer.Stop();
			label1.Text = timeL.ToString(@"hh\:mm\:ss");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			timer.Stop();

			timeL = new TimeSpan(0, 0, 0);
			label1.Text = timeL.ToString(@"hh\:mm\:ss");
		}


	}
}
