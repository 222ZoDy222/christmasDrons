
namespace DronCities
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		public void HideAllStartForms()
		{
			this.button1.Visible = false;
			this.richTextBox1.Visible = false;
			this.richTextBox2.Visible = false;
			this.richTextBox3.Visible = false;
			this.richTextBox4.Visible = false;
			this.richTextBox5.Visible = false;
			this.richTextBox6.Visible = false;
			this.progressBar1.Visible = false;
			this.textBox1.Visible = false;
			this.button2.Visible = false;
		}
		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.richTextBox5 = new System.Windows.Forms.RichTextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(270, 342);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(249, 76);
			this.button1.TabIndex = 0;
			this.button1.Text = "Открыть файл";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 342);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(245, 76);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "Откройте файл CSV с городами";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(12, 9);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(117, 316);
			this.richTextBox2.TabIndex = 2;
			this.richTextBox2.Text = "";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Location = new System.Drawing.Point(135, 9);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.ReadOnly = true;
			this.richTextBox3.Size = new System.Drawing.Size(122, 316);
			this.richTextBox3.TabIndex = 3;
			this.richTextBox3.Text = "";
			// 
			// richTextBox4
			// 
			this.richTextBox4.Location = new System.Drawing.Point(263, 9);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.ReadOnly = true;
			this.richTextBox4.Size = new System.Drawing.Size(178, 316);
			this.richTextBox4.TabIndex = 4;
			this.richTextBox4.Text = "";
			// 
			// richTextBox5
			// 
			this.richTextBox5.Location = new System.Drawing.Point(447, 9);
			this.richTextBox5.Name = "richTextBox5";
			this.richTextBox5.ReadOnly = true;
			this.richTextBox5.Size = new System.Drawing.Size(178, 316);
			this.richTextBox5.TabIndex = 5;
			this.richTextBox5.Text = "";
			// 
			// richTextBox6
			// 
			this.richTextBox6.Location = new System.Drawing.Point(631, 9);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.ReadOnly = true;
			this.richTextBox6.Size = new System.Drawing.Size(157, 316);
			this.richTextBox6.TabIndex = 6;
			this.richTextBox6.Text = "";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(526, 371);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(261, 16);
			this.progressBar1.TabIndex = 7;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(526, 397);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(261, 20);
			this.textBox1.TabIndex = 8;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(270, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(249, 76);
			this.button2.TabIndex = 9;
			this.button2.Text = "Начать расчёты";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1964, 1041);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(26, 954);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(505, 56);
			this.textBox2.TabIndex = 11;
			this.textBox2.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1964, 1041);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.richTextBox6);
			this.Controls.Add(this.richTextBox5);
			this.Controls.Add(this.richTextBox4);
			this.Controls.Add(this.richTextBox3);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.RichTextBox richTextBox5;
		private System.Windows.Forms.RichTextBox richTextBox6;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}

	
}

