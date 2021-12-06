﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using DronCities.Assets;
using System.Runtime.InteropServices;


namespace DronCities
{

	public partial class Form1 : Form
	{
		
		private OpenFileDialog ofd;

		public Form1()
		{
			InitializeComponent();
			//WindowState = FormWindowState.Maximized;
			//TopMost = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			
			ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				
				var parser = new TextFieldParser(ofd.FileName,Encoding.Default);
				var result = Parse.ParseCVSFile(parser);
				string RES = "";
				//result.Encoding
				//byte[] bytes = Encoding.Default.GetBytes(result);
				//result = Encoding.UTF8.GetString(bytes);
				
				int i = 0;
				int count = 1;
				string[] textResult = new string[5];
				foreach(var item in result)
				{
					//textResult[i] += count +") "+ item + Environment.NewLine;
					textResult[i] += item + ",";
					i++;
					if (i == 5)
					{
						i = 0;
						count += 1;
					}
					GoProgressBar(1, 10000);

				}
				
				richTextBox2.Text += textResult[0];
				richTextBox3.Text += textResult[1];
				richTextBox4.Text += textResult[2];
				richTextBox5.Text += textResult[3];
				richTextBox6.Text += textResult[4];

				var Test = new Country(textResult[0], textResult[1], textResult[2], textResult[3], textResult[4]);

				button1.Visible = false;
				button2.Visible = true;

				
			}
			
		}

		void GoProgressBar(int arg, int arg_lengt)
		{
			int a = (arg_lengt / 100) * arg;
			Convert.ToInt32(a);
			if(progressBar1.Value + a > 100) progressBar1.Value = 100 - a;
			progressBar1.Value += a;
		}

		
		private void button2_Click(object sender, EventArgs e)
		{
			HideAllStartForms();
			pictureBox1.Visible = true;
			Country Russia = new Country(richTextBox2.Text, richTextBox3.Text, richTextBox4.Text, richTextBox5.Text, richTextBox6.Text);
			
			Draw(Russia);

		}

		private void Draw(Country country)
		{
			//Graphics graph = pictureBox1.CreateGraphics();
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics graph = Graphics.FromImage(bmp);
			List<Rectangle> rect = new List<Rectangle>();
			//Rectangle rect = ;
			for (int i = 0; i < country.Cities.Count; i++)
			{
				rect.Add(new Rectangle(Convert.ToInt32(Math.Round(country.Cities[i].y * 10)) - 100, Convert.ToInt32(Math.Round(country.Cities[i].x * 10)) - 100, 3, 3));
			}
			for (int i = 0; i < country.Cities.Count; i++)
			{
				graph.DrawRectangle(Pens.Black, rect[i]);
				graph.FillRectangle(Brushes.Black, rect[i]);
			}

			graph.DrawRectangle(Pens.Red, new Rectangle(Convert.ToInt32(Math.Round(country.StartPoint.y * 10)) - 100, Convert.ToInt32(Math.Round(country.StartPoint.x * 10)) - 100, 3, 3));
			graph.FillRectangle(Brushes.Red, new Rectangle(Convert.ToInt32(Math.Round(country.StartPoint.y * 10)) - 100, Convert.ToInt32(Math.Round(country.StartPoint.x * 10)) - 100, 3, 3));

			
			FindMinDistance MinDistance = new FindMinDistance(country);

			DrawSide(graph, MinDistance);
			List<Rectangle> rectLeftUp = new List<Rectangle>();
			
			pictureBox1.Image = bmp;

			//textBox2.Text = $"Слева : {MinDistance.LeftDown.Count} городов, справа : {MinDistance.LeftDown.Count} городов!";
			textBox2.Visible = true;
		}

		private void DrawSide(Graphics graph, FindMinDistance MinDistance)
		{
			List<Rectangle> rectLeftDown = new List<Rectangle>();
			List<Rectangle> rectLeftUp = new List<Rectangle>();
			List<Rectangle> rectRightDown = new List<Rectangle>();
			List<Rectangle> rectRightUp = new List<Rectangle>();
			///////////////////////////////////////////////////////
			for (int i = 0; i < MinDistance.LeftDown.Count; i++)
			{
				rectLeftDown.Add(new Rectangle(Convert.ToInt32(Math.Round(MinDistance.LeftDown[i].y * 10)) - 100, Convert.ToInt32(Math.Round(MinDistance.LeftDown[i].x * 10)) - 100, 3, 3));
			}
			for (int i = 0; i < MinDistance.LeftUp.Count; i++)
			{
				rectLeftUp.Add(new Rectangle(Convert.ToInt32(Math.Round(MinDistance.LeftUp[i].y * 10)) - 100, Convert.ToInt32(Math.Round(MinDistance.LeftUp[i].x * 10)) - 100, 3, 3));
			}
			for (int i = 0; i < MinDistance.RightDown.Count; i++)
			{
				rectRightDown.Add(new Rectangle(Convert.ToInt32(Math.Round(MinDistance.RightDown[i].y * 10)) - 100, Convert.ToInt32(Math.Round(MinDistance.RightDown[i].x * 10)) - 100, 3, 3));
			}
			for (int i = 0; i < MinDistance.RightUp.Count; i++)
			{
				rectRightUp.Add(new Rectangle(Convert.ToInt32(Math.Round(MinDistance.RightUp[i].y * 10)) - 100, Convert.ToInt32(Math.Round(MinDistance.RightUp[i].x * 10)) - 100, 3, 3));
			}
			////////////////////////////////////////////////////////
			for (int i = 0; i < MinDistance.LeftDown.Count; i++)
			{
				graph.DrawRectangle(Pens.Blue, rectLeftDown[i]);
				graph.FillRectangle(Brushes.Blue, rectLeftDown[i]);
			}
			for (int i = 0; i < MinDistance.LeftUp.Count; i++)
			{
				graph.DrawRectangle(Pens.Green, rectLeftUp[i]);
				graph.FillRectangle(Brushes.Green, rectLeftUp[i]);
			}
			for (int i = 0; i < MinDistance.RightDown.Count; i++)
			{
				graph.DrawRectangle(Pens.Yellow, rectRightDown[i]);
				graph.FillRectangle(Brushes.Yellow, rectRightDown[i]);
			}
			for (int i = 0; i < MinDistance.RightUp.Count; i++)
			{
				graph.DrawRectangle(Pens.Purple, rectRightUp[i]);
				graph.FillRectangle(Brushes.Purple, rectRightUp[i]);
			}
		}
	}
}
