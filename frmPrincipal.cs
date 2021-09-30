using ProcessamentoImagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public partial class frmPrincipal : Form
    {
        private int ma, sa, lu;
        private int vh, vs, vi;
        private Image image;
        private Filtros filtro;
        private Bitmap imageBitmap, dst, bmpH, bmpS, bmpI;

        private void btMatizMais_Click(object sender, EventArgs e)
        {
            ma += 5;
            vh += 5;
            lVarH.Text = "" + vh;
            if (ma > 360) ma -= 360;
            filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
            pbH.Image = bmpH;
            pbS.Image = bmpS;
            pbI.Image = bmpI;
            pictureBox1.Image = dst;
        }

        private void btSaturacaoMenos_Click(object sender, EventArgs e)
        {
            if (sa > -100)
            {
                sa -= 5;
                vs -= 5;
                lVarS.Text = "" + vs;
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
                pbH.Image = bmpH;
                pbS.Image = bmpS;
                pbI.Image = bmpI;
                pictureBox1.Image = dst;
            }
        }

        private void btSaturacaoMais_Click(object sender, EventArgs e)
        {
            if (sa < 100)
            {
                sa += 5;
                vs += 5;
                lVarS.Text = "" + vs;
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
                pbH.Image = bmpH;
                pbS.Image = bmpS;
                pbI.Image = bmpI;
                pictureBox1.Image = dst;
            }
        }

        private void btLumMenos_Click(object sender, EventArgs e)
        {
            if (lu > -255)
            {
                lu -= 5;
                vi -= 5;
                lVarI.Text = "" + vi;
                if (lu < -255) lu = -255;
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
                pbH.Image = bmpH;
                pbS.Image = bmpS;
                pbI.Image = bmpI;
                pictureBox1.Image = dst;
            }
        }

        private void btLumMais_Click(object sender, EventArgs e)
        {
            if (lu < 255)
            {
                lu += 5;
                vi += 5;
                lVarI.Text = "" + vi;
                if (lu > 255) lu = 255;
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
                pbH.Image = bmpH;
                pbS.Image = bmpS;
                pbI.Image = bmpI;
                pictureBox1.Image = dst;
            }
        }

        private void btMatizMenos_Click(object sender, EventArgs e)
        {
            ma -= 5;
            vh -= 5;
            lVarH.Text = "" + vh;
            if (ma < 0) ma += 360;
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
            pbH.Image = bmpH;
            pbS.Image = bmpS;
            pbI.Image = bmpI;
            pictureBox1.Image = dst;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X, y = e.Y;
            double distx = (pictureBox1.Width - image.Width) / 2;
            double disty = (pictureBox1.Height - image.Height) / 2;
            if (x > distx && x < pictureBox1.Width - distx
                && y > disty && y < pictureBox1.Height - disty
                && lX.BackColor.R < 255 && lY.BackColor.R < 255)
            {
                Color cor;
                x -= (int)distx + 1;
                y -= (int)disty + 1;
                lX.Text = "X = " + x;
                lY.Text = "Y = " + y;
                if (x >= 0 && x < dst.Width && y >= 0 && y < dst.Height)
                {           
                    lH.Text = "" + ((bmpH.GetPixel(x, y).R * 360) / 255);
                    lS.Text = "" + ((bmpS.GetPixel(x, y).R * 100) / 255);
                    lL.Text = "" + bmpI.GetPixel(x, y).R;

                    cor = dst.GetPixel(x, y);

                    lRed.Text = "R : " + cor.R;
                    lGreen.Text = "G : " + cor.G;
                    lBlue.Text = "B : " + cor.B;
                    
                    lCyano.Text = "C : " + (255 - cor.R);
                    lMagenta.Text = "M : " + (255 - cor.G);
                    lYellow.Text = "Y : " + (255 - cor.B);
                }
                else
                {
                    lY.BackColor = lX.BackColor = Color.FromArgb(255, 0, 0);
                }
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image;
            ma = sa = lu = 0;
            vh = vs = vi = 0;
            lVarH.Text = "+0";
            lVarS.Text = "+0";
            lVarI.Text = "+0";

          
            filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
            pictureBox1.Enabled = true;
            btRestaurar.Enabled = btLimpar.Enabled = gbFiltros.Enabled = true;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            gbFiltros.Enabled = false;
            btLimpar.Enabled = false;
        }

        public frmPrincipal()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Enabled = btRestaurar.Enabled = btLimpar.Enabled = gbFiltros.Enabled = false;

            filtro = new Filtros();
        }

        private void btAbrirImagem_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                imageBitmap = new Bitmap(image);
                dst = new Bitmap(image);
                bmpH = new Bitmap(image);
                bmpS = new Bitmap(image);
                bmpI = new Bitmap(image);
                
                filtro.MSI(imageBitmap, dst, bmpH, bmpS, bmpI, ma, sa, lu);
                pbH.Image = bmpH;
                pbS.Image = bmpS;
                pbI.Image = bmpI;
                pictureBox1.Image = dst;
                pictureBox1.Enabled = true;
                btRestaurar.Enabled = btLimpar.Enabled = gbFiltros.Enabled = true;
                vh = vs = vi = 0;
            }
        }
    }
}
