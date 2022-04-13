using System;
using System.IO;
using System.Windows.Forms;

namespace visualizador_de_produtos
{
    public partial class Form1 : Form
    {
        private const string PathPictures = @"C:\Users\pa_ul\source\repos\visualizador-de-produtos\fotos";

        public Form1()
        {
            InitializeComponent();
        }

        private void ModelCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] carPictures = Directory.GetFiles(PathPictures);

            foreach(string picture in carPictures)
            {
                string[] split = picture.Split('\\');
                string[] split2 = split[7].Split('.');
                if (ModelCBox.Text == split2[0])
                {
                    pictureBox1.ImageLocation = PathPictures + "\\" + ModelCBox.Text + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void BrandCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModelCBox.Text = string.Empty;
            if (BrandCBox.Text == "FIAT")
            {
                ModelCBox.Items.Clear();
                ModelCBox.Items.Add("STRADA");
                ModelCBox.Items.Add("PUNTO");
                ModelCBox.Items.Add("ARGO");
            }
            else if (BrandCBox.Text == "FORD")
            {
                ModelCBox.Items.Clear();
                ModelCBox.Items.Add("FOCUS");
                ModelCBox.Items.Add("MUSTANG");
                ModelCBox.Items.Add("FORDONA BRABA");
            }
            else if (BrandCBox.Text == "CHEVROLET")
            {
                ModelCBox.Items.Clear();
                ModelCBox.Items.Add("ONIX");
            }
        }
    }
}
