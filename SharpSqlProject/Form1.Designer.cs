
namespace SharpSqlProject
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.exit_but = new System.Windows.Forms.Button();
			this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.button7 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.button8 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.button5 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.metroTabControl1.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.metroTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.metroTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.exit_but);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1000, 65);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(3, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Управление базой данных";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// exit_but
			// 
			this.exit_but.BackColor = System.Drawing.Color.SandyBrown;
			this.exit_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.exit_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.exit_but.Location = new System.Drawing.Point(955, 12);
			this.exit_but.Name = "exit_but";
			this.exit_but.Size = new System.Drawing.Size(33, 39);
			this.exit_but.TabIndex = 0;
			this.exit_but.Text = "X";
			this.exit_but.UseVisualStyleBackColor = false;
			this.exit_but.Click += new System.EventHandler(this.button1_Click);
			// 
			// metroTabControl1
			// 
			this.metroTabControl1.Controls.Add(this.metroTabPage1);
			this.metroTabControl1.Controls.Add(this.metroTabPage2);
			this.metroTabControl1.Controls.Add(this.metroTabPage3);
			this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroTabControl1.Location = new System.Drawing.Point(0, 65);
			this.metroTabControl1.Name = "metroTabControl1";
			this.metroTabControl1.SelectedIndex = 2;
			this.metroTabControl1.Size = new System.Drawing.Size(1000, 585);
			this.metroTabControl1.TabIndex = 1;
			this.metroTabControl1.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.button7);
			this.metroTabPage1.Controls.Add(this.button2);
			this.metroTabPage1.Controls.Add(this.button1);
			this.metroTabPage1.Controls.Add(this.dataGridView1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(992, 543);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Приходной ордер";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button7.Location = new System.Drawing.Point(163, 462);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(113, 46);
			this.button7.TabIndex = 5;
			this.button7.Text = "Обновить!";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(871, 462);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 46);
			this.button2.TabIndex = 4;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 462);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 46);
			this.button1.TabIndex = 3;
			this.button1.Text = "Проверить соединение";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView1.Location = new System.Drawing.Point(8, 15);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(976, 420);
			this.dataGridView1.TabIndex = 2;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.Controls.Add(this.button8);
			this.metroTabPage2.Controls.Add(this.button3);
			this.metroTabPage2.Controls.Add(this.button4);
			this.metroTabPage2.Controls.Add(this.dataGridView2);
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(992, 543);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Поставщики";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button8.Location = new System.Drawing.Point(163, 462);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(113, 46);
			this.button8.TabIndex = 7;
			this.button8.Text = "Обновить!";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(8, 462);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(113, 46);
			this.button3.TabIndex = 6;
			this.button3.Text = "Проверить соединение";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(871, 462);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(113, 46);
			this.button4.TabIndex = 5;
			this.button4.Text = "Удалить";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView2.Location = new System.Drawing.Point(8, 15);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(976, 420);
			this.dataGridView2.TabIndex = 2;
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.Controls.Add(this.button5);
			this.metroTabPage3.Controls.Add(this.button9);
			this.metroTabPage3.Controls.Add(this.button6);
			this.metroTabPage3.Controls.Add(this.dataGridView3);
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(992, 543);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "Склады";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 10;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.Location = new System.Drawing.Point(8, 463);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(113, 46);
			this.button5.TabIndex = 7;
			this.button5.Text = "Проверить соединение";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.LightSkyBlue;
			this.button9.Location = new System.Drawing.Point(163, 463);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(113, 46);
			this.button9.TabIndex = 6;
			this.button9.Text = "Обновить!";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(871, 463);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(113, 46);
			this.button6.TabIndex = 5;
			this.button6.Text = "Удалить";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView3.Location = new System.Drawing.Point(8, 14);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(976, 420);
			this.dataGridView3.TabIndex = 2;
			this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 650);
			this.Controls.Add(this.metroTabControl1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.metroTabControl1.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.metroTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.metroTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button exit_but;
		private MetroFramework.Controls.MetroTabControl metroTabControl1;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private System.Windows.Forms.Label label1;
		private MetroFramework.Controls.MetroTabPage metroTabPage3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button9;
	}
}

