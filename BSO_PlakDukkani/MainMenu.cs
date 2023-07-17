using BSO_PlakDukkani.Concrets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BSO_PlakDukkani
{
    public partial class MainMenu : Form
    {
        PlakDukkaniContext _db = new PlakDukkaniContext();
        public MainMenu(Modul item)
        {
            InitializeComponent();
            cmbSatistaMi.SelectedIndex = 1;
            dtCikisTarihi.MaxDate = DateTime.Now;
            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album a1 = new Album();
            a1.Ad = txtAlbumAdi.Text;
            a1.AlbumCikisTarihi = dtCikisTarihi.Value;
            a1.AlbumFiyati = Convert.ToDouble(txtFiyat.Text);
            a1.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text);
            a1.Satistami = cmbSatistaMi.SelectedIndex == 1 ? true : false;
            a1.Sanatci = txtSanatci.Text;
            _db.Albumler.Add(a1);
            _db.SaveChanges();
            Listele();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        void Listele()
        {
            dgvAlbumler.DataSource = null;
            dgvAlbumler.DataSource = _db.Albumler.ToList();
        }

        void Sil()
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                Album album = dgvAlbumler.SelectedRows[0].DataBoundItem as Album;
                _db.Albumler.Remove(album);
                _db.SaveChanges();
                Listele();
            }
            else
            {
                MessageBox.Show("Albüm seçiniz.");
            }
        }
        void Guncelle()
        {
            if (dgvAlbumler.SelectedRows.Count > 0)
            {
                Album a1 = dgvAlbumler.SelectedRows[0].DataBoundItem as Album;
                a1.Ad = txtAlbumAdi.Text;
                a1.AlbumCikisTarihi = dtCikisTarihi.Value;
                a1.AlbumFiyati = Convert.ToDouble(txtFiyat.Text);
                a1.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text);
                a1.Satistami = cmbSatistaMi.SelectedIndex == 1 ? true : false;
                a1.Sanatci = txtSanatci.Text;
                _db.Albumler.Update(a1);
                _db.SaveChanges();
                Listele();
            }
            else
            {
                MessageBox.Show("Albüm seçiniz.");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbSirala_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvListelenenAlan.DataSource = null;
            if (cmbSirala.SelectedIndex == 1)
            {

                var Albumler = _db.Albumler.Where(x => x.Satistami == false).Select(x => new { AlbümAdı = x.Ad, Sanatçı = x.Sanatci });

                dgvListelenenAlan.DataSource = Albumler.ToList();
            }
            else if (cmbSirala.SelectedIndex == 2)
            {
                var Albumler = _db.Albumler.Where(x => x.Satistami == true).Select(x => new { AlbümAdı = x.Ad, Sanatçı = x.Sanatci });
                dgvListelenenAlan.DataSource = Albumler.ToList();
            }
            else if (cmbSirala.SelectedIndex == 3)
            {
                var Albumler = _db.Albumler.OrderByDescending(x => x.Id).Take(10).Select(x => new { AlbümAdı = x.Ad, Sanatçı = x.Sanatci });
                dgvListelenenAlan.DataSource = Albumler.ToList();
            }
            else if (cmbSirala.SelectedIndex == 4)
            {
                var Albumler = _db.Albumler.Where(x => x.IndirimOrani > 0).Select(x => new { AlbümAdı = x.Ad, Sanatçı = x.Sanatci });
                dgvListelenenAlan.DataSource = Albumler.ToList();
            }


        }
    }
}
