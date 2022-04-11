using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHorseRacing_2
{
    public partial class Form1 : Form
    {

        //Bir kontrolün "Left" property'si o kontrolün sol tarafa olan uzaklıgını size teslim eder...Ve bu kontrole deger atanabilir...


        //Bir kontrolün "Top" property'si o kontrolün üst tarafa olan uzaklıgını size teslim eder...Bu Top property'sine de deger atayabilirsiniz...


        //Bir kontrolün Right ve Bottom özellikleri read only'dir...Yani onlara deger atayamazsınız...Onlardan sadece deger okuyabilirsiniz...



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 5;
        }
    }
}
