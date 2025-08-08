using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_informatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel10_placamae.Visible = false;
            panel6_placamae.Visible = false;
            panel8_placamae.Visible = false;

            panel2_memoria.Visible = false;
            panel4_memoria.Visible = false;
            panel9_memoria.Visible = false;

            panel2_processador.Visible = true;
            panel3_processador.Visible = true;
            panel4_processador.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2_processador.Visible = false;
            panel3_processador.Visible = false;
            panel4_processador.Visible = false;

            panel10_placamae.Visible = false;
            panel6_placamae.Visible = false;
            panel8_placamae.Visible = false;

            panel2_memoria.Visible = true;
            panel9_memoria.Visible = true;
            panel4_memoria.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2_processador.Visible = false;
            panel3_processador.Visible = false;
            panel4_processador.Visible = false;

            panel2_memoria.Visible = false;
            panel4_memoria.Visible = false;
            panel9_memoria.Visible = false;

            panel10_placamae.Visible = true;
            panel6_placamae.Visible = true;
            panel8_placamae.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/processador-intel-core-i7-14700kf-20-core-28-threads-3-4ghz-5-6ghz-turbo-cache-33mb-lga1700-bx8071514700kf",
                UseShellExecute = true
            });
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/processador-amd-ryzen-5-5500x3d-6-core-12-threads-3ghz-4ghz-turbo-cache-99mb-am4-100-100001504wof",
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/processador-amd-ryzen-9-9950x-16-core-32-threads-4-3ghz-5-7ghz-turbo-cache-80mb-am5-100-100001277wof",
                UseShellExecute = true
            });
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/placa-mae-gigabyte-b550m-aorus-elite-ddr4-socket-amd-am4-m-atx-chipset-amd-b550-b550m-aorus-elite",
                UseShellExecute = true
            });
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/memoria-corsair-vengeance-rgb-32gb-2x16gb-ddr5-6400mhz-c36-branco-cmh32gx5m2b6400c36w",
                UseShellExecute = true
            });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/placa-mae-msi-b860m-gaming-plus-wifi-ddr5-lga1851-m-atx-chipset-intel-b860-b860m-gaming-plus-wifi",
                UseShellExecute = true
            });
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "http://pichau.com.br/memoria-corsair-vengeance-ddr5-16gb-2x8gb-5200mhz-c40-preta-cmk16gx5m2b5200c40",
                UseShellExecute = true
            });
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/placa-mae-asus-prime-h610m-cs-d4-ddr4-lga1700-m-atx-chipset-intel-h610-prime-h610m-cs-d4",
                UseShellExecute = true
            });
        }

        private void panel6_processador_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.pichau.com.br/memoria-redragon-rage-8gb-1x8gb-ddr4-3200mhz-c16-vermelha-gm-701",
                UseShellExecute = true
            });
        }

        
    }
}
