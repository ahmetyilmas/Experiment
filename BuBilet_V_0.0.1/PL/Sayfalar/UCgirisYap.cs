using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuBilet_V_0._0._1.Sayfalar
{
    public partial class UCgirisYapPanel : UserControl
    {
        public UCgirisYapPanel()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = this.textBox1.Text;
            string sifre = this.textBox2.Text;

            if(SifreKontrol(kullaniciAdi, sifre))
            {
                FrmBuBilet frmBuBilet = new FrmBuBilet();
                frmBuBilet.Show();
            }
        }

        private Boolean SifreKontrol(string kullaniciAdi, string sifre)
        {
            using (NpgsqlConnection baglanti = new NpgsqlConnection("Server = localhost; Port = 5432; Database = ProjeDenemesi; User ID = postgres; password = ahmet1234"))
            {
                baglanti.Open();
                using (NpgsqlCommand comm = new NpgsqlCommand("SELECT kullaniciSifre FROM Kullanicilar WHERE kullaniciID = @kullaniciAdi", baglanti))
                {
                    comm.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    using (NpgsqlDataReader dr = comm.ExecuteReader())
                    {
                        

                        if (dr.Read())
                        {
                            string DBsifre = dr["kullaniciSifre"].ToString();
                            if(sifre == DBsifre)
                                return true;
                        }
                    }
                }
            }
            return false;
        }

        private void UCgirisYap_Load(object sender, EventArgs e)
        {

        }
    }
}
