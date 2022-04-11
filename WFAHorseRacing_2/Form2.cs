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
    public partial class Form2 : Form
    {

        //Bazı kontrollerinizin üzerinde minik ok işaretleri göreceksiniz. Bu işaretler smart tag işaretleri olarak bilinir...Smart Tag, sizin ilgili kontrolünüzde cok sık kullandıgınız işlemlere kısa yoldan ulasmanızı saglar...
        public Form2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region YarisKodlari

            pbGolge.Left += rnd.Next(5, 16);
            pbRuzgar.Left += rnd.Next(5, 16);
            pbGunbatimi.Left += rnd.Next(5, 16);

            if (pbGolge.Right >= lblFinish.Left)
            {
                timer1.Stop();

                DialogResult dr = MessageBox.Show("Yarısı Gölge kazandı\nTekrar oynamak ister misiniz?", "Gölgenin yayılması", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunbatimi.Left = 0;
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbRuzgar.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarısı Rüzgar kazandı.\nTekrar oynamak ister misiniz?", "Rüzgar esti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunbatimi.Left = 0;
                }
                else
                {
                    Application.Exit();
                }
            }
            else if(pbGunbatimi.Right>=lblFinish.Left)
            {

                timer1.Stop();
                DialogResult dr = MessageBox.Show("Yarısı günbatımı kazanarak günü ismine layık bir şekilde sonlandırdı.\nTekrar oynamak ister misiniz?","Günabattı",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbGolge.Left = pbRuzgar.Left = pbGunbatimi.Left = 0;
                }
                else
                {
                    Application.Exit();
                }
            }




            #endregion
        }
    }
}
