using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonoEstrellado5
{
    public partial class Vizualizer : Form
    {
        private Estrella estrella;
        private float radioActual;
        public Vizualizer()
        {
            InitializeComponent();

            this.Resize += new EventHandler(Vizualizer_Resize);
            picCanvas.SizeChanged += new EventHandler(PicCanvas_SizeChanged);
            labelWidth.Text = "Ancho: ";
            labelHeight.Text = "Alto: ";
        }

        private void Vizualizer_Load(object sender, EventArgs e)
        {
            ActualizarDimensionesPictureBox();
        }

        private void ActualizarDimensionesPictureBox()
        {
            labelWidth.Text = $"Ancho: {picCanvas.Width}";
            labelHeight.Text = $"Alto: {picCanvas.Height}";
        }
        private void Vizualizer_Resize(object sender, EventArgs e)
        {
            AjustarDibujo();
        }
        private void PicCanvas_SizeChanged(object sender, EventArgs e)
        { 
            ActualizarDimensionesPictureBox();
            if (picCanvas.Width > 0 && picCanvas.Height > 0)
            {
                AjustarDibujo();
            }
        }

        private void AjustarDibujo()
        {
            
        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtRadio.Text, out float radio) && radio > 0)
            {
                if (picCanvas.Width > 0 && picCanvas.Height > 0)
                {
                    if (picCanvas.Image != null)
                    {
                        picCanvas.Image.Dispose();
                    }
                    Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
                    picCanvas.Image = bmp;
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                        estrella = new Estrella();
                        estrella.EstablecerGraphics(g);
                        estrella.EstablecerPen(new Pen(Color.Black, 2));
                        PointF centro = new PointF(picCanvas.Width / 2, picCanvas.Height / 2);
                        List<PointF> vertices = estrella.CalcularVertices(radio, centro);
                        estrella.Dibujar();

                      
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un radio válido.");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtRadio.Clear();
            picCanvas.Image = null;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
