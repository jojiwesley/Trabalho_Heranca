using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Trabalho_Herança
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(UInt32 frequency, UInt32 duration);

        public abstract class Campainha
        {
            public abstract void Musica();
            public void soar()
            {
                Musica();
            }
        }

        public class campainha1 : Campainha //herança 
        {
            public override void Musica() // poliformismo 
            {
                // MUSICA DO MARIO 
                Beep(480, 200);

                Beep(1568, 200);

                Beep(1568, 200);

                Beep(1568, 200);



                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(784, 200);


                Beep(370, 200);

                Beep(392, 200);

                Beep(370, 200);

                Beep(392, 200);

                Beep(392, 400);

                Beep(196, 400);



                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(84, 200);

                Beep(880, 200);

                Beep(831, 200);

                Beep(880, 200);

                Beep(988, 400);


                Beep(880, 200);

                Beep(784, 200);

                Beep(699, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(880, 200);

                Beep(830, 200);

                Beep(880, 200);

                Beep(988, 400);

                Beep(000, 1000);

                Beep(1108, 10);
                Beep(1174, 200);
                Beep(1480, 10);
                Beep(1568, 200);


                Beep(000, 1000);
                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(784, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(880, 200);

                Beep(830, 200);

                Beep(880, 200);

                Beep(988, 400);


                Beep(880, 200);

                Beep(784, 200);

                Beep(699, 200);


                Beep(659, 200);

                Beep(699, 200);

                Beep(784, 200);

                Beep(880, 400);

                Beep(784, 200);

                Beep(699, 200);

                Beep(659, 200);



                Beep(587, 200);

                Beep(659, 200);

                Beep(699, 200);

                Beep(784, 400);

                Beep(699, 200);

                Beep(659, 200);

                Beep(587, 200);



                Beep(523, 200);

                Beep(587, 200);

                Beep(659, 200);

                Beep(699, 400);

                Beep(659, 200);

                Beep(587, 200);

                Beep(494, 200);

                Beep(523, 200);


                Beep(000, 1000);

                Beep(349, 400);

                Beep(392, 200);

                Beep(330, 200);

                Beep(523, 200);

                Beep(494, 200);

                Beep(466, 200);



                Beep(440, 200);

                Beep(494, 200);

                Beep(523, 200);

                Beep(880, 200);

                Beep(494, 200);

                Beep(880, 200);

                Beep(1760, 200);

                Beep(440, 200);



                Beep(392, 200);

                Beep(440, 200);

                Beep(494, 200);

                Beep(784, 200);

                Beep(440, 200);

                Beep(784, 200);

                Beep(1568, 200);

                Beep(392, 200);



                Beep(349, 200);

                Beep(392, 200);

                Beep(440, 200);

                Beep(699, 200);

                Beep(415, 200);

                Beep(699, 200);

                Beep(139, 200);

                Beep(349, 200);



                Beep(330, 200);

                Beep(311, 200);

                Beep(330, 200);

                Beep(659, 200);

                Beep(699, 400);

                Beep(784, 400);



                Beep(440, 200);

                Beep(494, 200);

                Beep(523, 200);

                Beep(880, 200);

                Beep(494, 200);

                Beep(880, 200);

                Beep(176, 200);

                Beep(440, 200);



                Beep(392, 200);

                Beep(440, 200);

                Beep(494, 200);

                Beep(784, 200);

                Beep(440, 200);

                Beep(784, 200);

                Beep(156, 200);

                Beep(392, 200);



                Beep(349, 200);

                Beep(392, 200);

                Beep(440, 200);

                Beep(699, 200);

                Beep(659, 200);

                Beep(699, 200);

                Beep(740, 200);

                Beep(784, 200);

                Beep(392, 200);

                Beep(392, 200);

                Beep(392, 200);

                Beep(392, 200);

                Beep(196, 200);

                Beep(196, 200);

                Beep(196, 200);



                Beep(185, 200);

                Beep(196, 200);

                Beep(185, 200);

                Beep(196, 200);

                Beep(208, 200);

                Beep(220, 200);

                Beep(233, 200);

                Beep(247, 200);



            }
        }

        public class campainha2 : Campainha // herança 
        {
            public override void Musica()
            {
                Beep(200, 500);
                Beep(300, 400);
                Beep(400, 300);
                Beep(500, 200);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campainha Camp1 = new campainha1();
            Camp1.soar();
        }

        private void botão2_Click(object sender, EventArgs e)
        {
            Campainha Camp2 = new campainha2();
            Camp2.soar();
        }
    }
}
