using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-493DFJA\SQLEXPRESS;Initial Catalog=proje6;Integrated Security=True");
        
        void kayıt()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute proje6", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
    
            kayıt();
            
            SqlCommand komut = new SqlCommand("select * from TBLÜRÜNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommand komut1 = new SqlCommand("select * from TBLMUSTERILER", baglanti);
            SqlDataAdapter da1 = new SqlDataAdapter(komut1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            SqlCommand komut3 = new SqlCommand("select * from TBLPERSONEL", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            //ürünleri çekme cmb
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select AD from TBLÜRÜNLER  ", baglanti);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                cmbürün.Items.Add(dr[0]);
            }
            baglanti.Close();
            //MÜŞTERİ ÇEKME cmb
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("select ADSOYAD from TBLMUSTERILER  ", baglanti);
            SqlDataReader dr1 = kmt1.ExecuteReader();
            while (dr1.Read())
            {
                cmbmüsteri.Items.Add(dr1[0]);
            }
            baglanti.Close();
            //PERSONEL ÇEKME cmb
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("select AD from TBLPERSONEL  ", baglanti);
            SqlDataReader dr2 = kmt2.ExecuteReader();
            while (dr2.Read())
            {
                cmbpersonel.Items.Add(dr2[0]);
            }
            baglanti.Close();

            //displaymember valuemember 
            cmbürün.DisplayMember = "AD";
            cmbürün.ValueMember = "ID";
            cmbürün.DataSource = dt;
            cmbmüsteri.DisplayMember = "ADSOYAD";
            cmbmüsteri.ValueMember = "ID";
            cmbmüsteri.DataSource = dt1;
            cmbpersonel.DisplayMember = "AD";
            cmbpersonel.ValueMember = "ID";
            cmbpersonel.DataSource = dt3;
            cmbpersonel.Text = "";
            cmbmüsteri.Text = "";
            cmbürün.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLHAREKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", byte.Parse(cmbürün.SelectedValue.ToString()));
            //COMBOBOXTAN SEÇİLEN DEĞERİ STRİNG OLARAK TXTİD YAZDIR cmbürün.SelectedValue.ToString())
            komut.Parameters.AddWithValue("@P2", byte.Parse(cmbmüsteri.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@P3", byte.Parse(cmbpersonel.SelectedValue.ToString()));
            komut.Parameters.AddWithValue("@P4", txtfiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            int STOK = Convert.ToInt32(label9.Text);
            STOK--;
            label9.Text = STOK.ToString();
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("update  TBLÜRÜNLER set STOK=@T1 WHERE AD=@T2", baglanti);
            kmt2.Parameters.AddWithValue("@T1", label9.Text);
            kmt2.Parameters.AddWithValue("@T2",cmbürün.Text);
            kmt2.ExecuteNonQuery();
            baglanti.Close();
            kayıt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLÜRÜNLER (AD,STOK,ALISFİYAT,SATISFİYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtstok.Text);
            komut.Parameters.AddWithValue("@p3", txtalıs.Text);
            komut.Parameters.AddWithValue("@p4", txtsatıs .Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMÜRÜN FR = new FRMÜRÜN();
            FR.Show();
        }

        private void cmbürün_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select STOK from TBLÜRÜNLER WHERE AD=@P1 ", baglanti);
            kmt.Parameters.AddWithValue("@P1", cmbürün.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                label9.Text = dr[0].ToString();
                
            }
           label10.Text = cmbürün.Text;
            baglanti.Close();
            

            
        }

        
    }
}
