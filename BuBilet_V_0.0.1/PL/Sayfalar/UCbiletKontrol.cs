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
    public partial class UCbiletKontrol : UserControl
    {
        public UCbiletKontrol()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = biletSorgula("123456");
        }

        

        public DataTable biletSorgula(string PNR)
        {
            using (NpgsqlConnection baglanti = new NpgsqlConnection("Server = localhost; Port = 5432; Database = ProjeDenemesi; User ID = postgres; password = ahmet1234"))
            {
                baglanti.Open();
                using (NpgsqlCommand comm = new NpgsqlCommand("SELECT * FROM Biletler WHERE PNR = @PNR", baglanti))
                {
                    comm.Parameters.AddWithValue("@PNR", PNR);
                    
                    using (NpgsqlDataReader dr = comm.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }
            return null;
        }

        private void UCbiletKontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
