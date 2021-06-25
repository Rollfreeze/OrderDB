using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.SqlClient;

namespace SharpSqlProject
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		//Движение всего приложения
		Point lastpoint;

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			lastpoint = new Point(e.X, e.Y);
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastpoint.X;
				this.Top += e.Y - lastpoint.Y;
			}
		}

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public MySqlConnection mycon;
		public MySqlCommand mycom;

		//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		//если вы читаете мой код и хотите подключить свой серевер MySql, то вставьте свои данные здесь
		//я скину свои таблицы, которые сделал на локал хосте в phpMyAdmin, чтобы сэкономить ваше время
		//вы можете просто их импортировать себе для проверки функционала с готовой БД, которую я составил, опираясь на 3-е задание
		public string connect = "server=localhost;port=3306;username=root;password=root;database=orderdatabase";
		public SD.DataSet ds;

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				string script = "SELECT * FROM `prihod`";
				mycon = new MySqlConnection(connect);
				mycon.Open();

				MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
				SD.DataTable table = new SD.DataTable();
				ms_data.Fill(table);
				dataGridView1.DataSource = table;
				mycon.Close();
			}
			catch
			{
				MessageBox.Show("Connection lost");
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				string script = "SELECT * FROM `providers`";
				mycon = new MySqlConnection(connect);
				mycon.Open();

				MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
				SD.DataTable table = new SD.DataTable();
				ms_data.Fill(table);
				dataGridView2.DataSource = table;
				mycon.Close();
			}
			catch
			{
				MessageBox.Show("Connection lost");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			try
			{
				string script = "SELECT * FROM `stores`";
				mycon = new MySqlConnection(connect);
				mycon.Open();

				MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
				SD.DataTable table = new SD.DataTable();
				ms_data.Fill(table);
				dataGridView3.DataSource = table;
				mycon.Close();
			}
			catch
			{
				MessageBox.Show("Connection lost");
			}
		}

		//ПОДКЛЮЧИТЬСЯ К БД
		private void check_bd_connection()
		{
			try
			{
				mycon = new MySqlConnection(connect);
				mycon.Open();
				MessageBox.Show("Data Base is connected");
				mycon.Close();
			}
			catch
			{
				MessageBox.Show("Connection lost");
			}
		}
		
		private void button1_Click_1(object sender, EventArgs e)
		{
			check_bd_connection();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			check_bd_connection();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			check_bd_connection();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string selected_num_document = dataGridView1.CurrentRow.Cells["DocumentNumber"].Value.ToString();
			string selected_store = dataGridView1.CurrentRow.Cells["StoreNumber"].Value.ToString();
			string selected_conract_num = dataGridView1.CurrentRow.Cells["ContractNumber"].Value.ToString();

			string delete_row = $"DELETE FROM `prihod` WHERE `prihod`.`DocumentNumber` = {selected_num_document} AND `prihod`.`StoreNumber` = {selected_store} AND `prihod`.`ContractNumber` = {selected_conract_num}";
			Console.WriteLine(delete_row);

			mycon = new MySqlConnection(connect);
			mycon.Open();


			MySqlCommand delete_command = new MySqlCommand(delete_row, mycon);
			delete_command.ExecuteNonQuery();

			MySqlDataAdapter ms_show_data = new MySqlDataAdapter("SELECT * FROM `prihod`", connect);
			SD.DataTable table = new SD.DataTable();
			ms_show_data.Fill(table);
			dataGridView1.DataSource = table;
			mycon.Close();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string selected_num_document = dataGridView2.CurrentRow.Cells["DocumentNumber"].Value.ToString();
			string selected_provider_name = dataGridView2.CurrentRow.Cells["ProviderName"].Value.ToString();
			string selected_productNumber = dataGridView2.CurrentRow.Cells["ProductNumber"].Value.ToString();
			string selected_amount_product = dataGridView2.CurrentRow.Cells["AmmountProduct"].Value.ToString();
			string selected_product_price = dataGridView2.CurrentRow.Cells["ProductPrice"].Value.ToString();
			string selected_total_price = dataGridView2.CurrentRow.Cells["TotalPrice"].Value.ToString();

			string delete_row = $"DELETE FROM `providers` WHERE `providers`.`DocumentNumber` = {selected_num_document} AND `providers`.`ProviderName` = '{selected_provider_name}' AND `providers`.`ProductNumber` = {selected_productNumber} AND `providers`.`AmmountProduct` = {selected_amount_product} AND `providers`.`ProductPrice` = {selected_product_price} AND `providers`.`TotalPrice` = {selected_total_price}";
			

			mycon = new MySqlConnection(connect);
			mycon.Open();


			MySqlCommand delete_command = new MySqlCommand(delete_row, mycon);
			delete_command.ExecuteNonQuery();

			MySqlDataAdapter ms_show_data = new MySqlDataAdapter("SELECT * FROM `providers`", connect);
			SD.DataTable table = new SD.DataTable();
			ms_show_data.Fill(table);
			dataGridView2.DataSource = table;
			mycon.Close();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string selected_store_code = dataGridView3.CurrentRow.Cells["StoreCode"].Value.ToString();
			string selected_store_name = dataGridView3.CurrentRow.Cells["StoreName"].Value.ToString();
			string selected_product_number = dataGridView3.CurrentRow.Cells["ProductNumber"].Value.ToString();
			string selected_product_placement = dataGridView3.CurrentRow.Cells["ProductPlacement"].Value.ToString();


			string delete_row = $"DELETE FROM `stores` WHERE `stores`.`StoreCode` = {selected_store_code} AND `stores`.`StoreName` = '{selected_store_name}' AND `stores`.`ProductNumber` = {selected_product_number} AND `stores`.`ProductPlacement` = '{selected_product_placement}'";
			Console.WriteLine(delete_row);

			mycon = new MySqlConnection(connect);
			mycon.Open();

			MySqlCommand delete_command = new MySqlCommand(delete_row, mycon);
			delete_command.ExecuteNonQuery();

			MySqlDataAdapter ms_show_data = new MySqlDataAdapter("SELECT * FROM `stores`", connect);
			SD.DataTable table = new SD.DataTable();
			ms_show_data.Fill(table);
			dataGridView3.DataSource = table;
			mycon.Close();
		}
	}
}
