using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pengumpulan_Poin_Versi_2
{
    public partial class Form1 : Form
    {
        private object userId;
        private object pointsToAdd;
        private int number1 = 0;
        private int number2 = 0;
        internal object button12;
        internal object button13;
        internal readonly object button14;

        public class Program
        {
            private static int jumlahPoin = 0; // Jumlah poin awal pengguna

            public static void Main(string[] args)
            {
                // Membuat objek Timer dengan interval 1 menit (60000 milidetik)
                System.Timers.Timer timer = new System.Timers.Timer(60000);
                timer.Elapsed += TimerElapsed;
                timer.Start();

                Console.WriteLine("Sistem pembaruan poin pengguna dimulai.");
                Console.WriteLine("Tekan tombol 'Enter' untuk menghentikan sistem.");
                Console.ReadLine();

                timer.Stop();
                timer.Elapsed -= TimerElapsed;

                Console.WriteLine("Sistem pembaruan poin pengguna dihentikan.");
                Console.WriteLine("Jumlah poin akhir pengguna: " + jumlahPoin);
                Console.ReadLine();
            }

            private static void TimerElapsed(object sender, ElapsedEventArgs e)
            {
                // Kode pembaruan poin pengguna
                // Misalnya, mengambil data pengguna dari database berdasarkan ID
                int userId = 1; // ID pengguna
                int poinUpdate = GetPoinUpdateFromDatabase(userId);

                jumlahPoin += poinUpdate;
                Console.WriteLine("Poin diperbarui: " + poinUpdate);
            }

            private static int GetPoinUpdateFromDatabase(int userId)
            {
                // Kode untuk mengambil pembaruan poin dari database
                // Misalnya, menggunakan ADO.NET atau ORM seperti Entity Framework

                // Contoh sederhana: mengembalikan nilai tetap
                return 10; // Jumlah poin yang diperbarui
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void button16_Click(object sender, EventArgs e)
        {

        }

        public void button15_Click(object sender, EventArgs e)
        {
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        internal void Hide()
        {
            throw new NotImplementedException();
        }
    }
    
}
