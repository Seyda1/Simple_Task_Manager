using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace OSfinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ProsesGüncelleme();
            
        }
        public void ProsesGüncelleme()
        {
            Proseslstbx.Items.Clear();
            foreach (Process proses in Process.GetProcesses())
            {
                Proseslstbx.Items.Add(proses.ProcessName);
            }
        }
        public void ProsesÖldürme()
        {
            Process[] proses = Process.GetProcessesByName(Proseslstbx.SelectedItem.ToString());
            foreach (Process pro in proses)
            {
                pro.Kill();
               
            }
            MessageBox.Show("Öldürülen proses : "+proses[0]);
            ProsesGüncelleme();
        }
        
        public void KullanılanİşlemciYüzdesi()
        {
            String Prosesisim = Proseslstbx.SelectedItem.ToString();
            PerformanceCounter İşlemciSayaç = new PerformanceCounter("Process", "% Processor Time", Prosesisim);
            İşlemciSayaç.NextValue();

            Thread.Sleep(1000);

            float yüzde = İşlemciSayaç.NextValue() / Environment.ProcessorCount;
            String yüzdeSon=yüzde.ToString();
            MessageBox.Show(Prosesisim+" prosesinin kullandığı işlemci yüzdesi : "+yüzdeSon);
        }
        public void BellekKullanımı()
        {
            String Prosesisim = Proseslstbx.SelectedItem.ToString();
            PerformanceCounter BellekSayaç = new PerformanceCounter("Process", "Working Set - Private", Prosesisim,true);

            double BellekKullanımı = Convert.ToDouble(BellekSayaç.NextValue()) / (1024 * 1024);

            String BellekKullanımıSon = BellekKullanımı.ToString();
            MessageBox.Show(Prosesisim + " prosesinin kullandığı bellek miktarı : " + BellekKullanımıSon +" MB ");
            BellekSayaç.Close();
            BellekSayaç.Dispose();
          
           
            
        }
        public void ThreadSayısı()
        {
            Process[] proses = Process.GetProcessesByName(Proseslstbx.SelectedItem.ToString());
            double threadSayısı = Convert.ToDouble(proses[0].Threads.Count);
            
            MessageBox.Show(proses[0]+"prosesinin thread sayısı : "+threadSayısı.ToString());
            
        }

        private void prosesiÖldürToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProsesÖldürme();
        }

        private void Proseslstbx_MouseDown(object sender, MouseEventArgs e)
        {
            Proseslstbx.SelectedIndex = Proseslstbx.IndexFromPoint(e.X, e.Y);
        }

        private void kullandığıİşlemciYüzdesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            KullanılanİşlemciYüzdesi();
        }

        private void kullandığıBellekMiktarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BellekKullanımı();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThreadSayısı();
        }
       
    }
}
