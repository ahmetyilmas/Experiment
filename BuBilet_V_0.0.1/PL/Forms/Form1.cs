using BuBilet_V_0._0._1.Sayfalar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace BuBilet_V_0._0._1
{
    public partial class FrmBuBilet : Form
    {
        public FrmBuBilet()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            this.Size = workingArea.Size;
            this.Location = workingArea.Location;

            this.StartPosition = FormStartPosition.Manual;

            NpgsqlConnection baglanti = new NpgsqlConnection("Server = localhost; Port = 5432; Database = ProjeDenemesi; User ID = postgres; password = ahmet1234");
            baglanti.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = baglanti;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT * FROM OtobusSeferleri";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }

            comm.Dispose();
            baglanti.Close();
        }

        

        public void panelEkle(UserControl sayfalar)
        {
            sayfalar.Dock = DockStyle.Fill;
            PnlAnaPanel.Controls.Clear();
            PnlAnaPanel.Controls.Add(sayfalar);
            sayfalar.BringToFront();
        }

        private void BtnSideBarControl_Click(object sender, EventArgs e)
        {
            TmrSideBarTransition.Start();
        }

        bool sideBarExpand = true;

        private void TmrSideBarTransition_Tick(object sender, EventArgs e)
        {
            if (!sideBarExpand)
            {
                PnlSidebar.Width += 10;
                if (PnlSidebar.Width >= PnlSidebar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    TmrSideBarTransition.Stop();
                }
            }
            else
            {
                PnlSidebar.Width -= 10;
                if (PnlSidebar.Width <= PnlSidebar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    TmrSideBarTransition.Stop();
                }
            }
        }

        private void BtnOtobus_Click(object sender, EventArgs e)
        {
            UCotobusler otobusBiletleriSayfasi = new UCotobusler();
            panelEkle(otobusBiletleriSayfasi);
        }

        private void BtnUcak_Click(object sender, EventArgs e)
        {
            UCucakBiletleri ucakBiletleriSayfasi = new UCucakBiletleri();
            panelEkle(ucakBiletleriSayfasi);
        }

        private void BtnOtel_Click(object sender, EventArgs e)
        {
            UCotelRezervasyonlari otelRezervasyonlariSayfasi = new UCotelRezervasyonlari();
            panelEkle(otelRezervasyonlariSayfasi);
        }

        private void BtnBilet_Click(object sender, EventArgs e)
        {
            UCbiletKontrol biletKontrolSayfasi = new UCbiletKontrol();
            panelEkle(biletKontrolSayfasi);
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            UCgirisYapPanel girisYapmaSayfasi = new UCgirisYapPanel();
            panelEkle(girisYapmaSayfasi);
        }

        private void PnlAnaPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
