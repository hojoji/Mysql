using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=ajandek; Uid=root; Pwd=''");
            conn.Open();

            this.FormClosed += (sender, args) =>
            {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes();
        }

        void AdatBetoltes()
        {
            string sql = @"
            SELECT id, nev, uzlet
            FROM ajandek
            ORDER BY nev
            ";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    var ajandek = new Ajandek(id, nev, uzlet);
                    ajandekListBox.Items.Add(ajandek);
                }
            }

        }

        private void FelveszButton_Click(object sender, EventArgs e)
        {
            string nev = nevTxt.Text;
            string bolt = boltTxt.Text;
            string sql = @"
            INSERT INTO `ajandek`(`nev`, `uzlet`)
             VALUES
            ('" + nev + "','" + bolt + "')";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            ajandekListBox.Items.Clear();
            AdatBetoltes();
        }
        private void TorolButton_Click(object sender, EventArgs e)
        {

            string sql = @"
            DELETE FROM `ajandek` WHERE nev='" + ajandekListBox.SelectedItem + "'";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            ajandekListBox.Items.Remove(ajandekListBox.SelectedItem);
        }
        private void ReszletButton_Click(object sender, EventArgs e)
        {
            string sql = @"
            SELECT id, nev, uzlet
            FROM ajandek
            wHERE nev='" + ajandekListBox.SelectedItem + "'";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    //    if (uzlet == null) { uzlet = "Saját készítésű"; }

                    reszletekLbl.Text = "ID: " + id + "\nNév: " + nev + "\nÜzlet: " + uzlet;
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SzerkesztButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.Enabled = true;
        }

        private void ModositButton_Click(object sender, EventArgs e)
        {

            string nev = modositNev.Text;
            string bolt = modositBolt.Text;
            string sql = @"
            UPDATE `ajandek` SET `nev`='" + nev + "',`uzlet`='" + bolt + "' WHERE `nev`='" + ajandekListBox.SelectedItem + "'";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.ExecuteNonQuery();
            ajandekListBox.Items.Clear();
            AdatBetoltes();
        }
    }
}
