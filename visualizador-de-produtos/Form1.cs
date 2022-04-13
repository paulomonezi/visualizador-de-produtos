using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                 
            }
        }

        private void BrandCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
