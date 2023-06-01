using System.Runtime.Intrinsics.X86;

namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        string chr = "(* - *)";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            if (vx < 0 && label1.Left < 0)
            {
                label1.Left = ClientSize.Width;
            }
            else if (vx > 0 && label1.Right > ClientSize.Width)
            {
                label1.Left = 0;
            }
            else
                label1.Left = label1.Left + vx;

            if (vy < 0 && label1.Top < 0)
            {
                label1.Top = ClientSize.Height;
            }
            else if (vy > 0 && label1.Bottom > ClientSize.Height)
            {
                label1.Top = 0;
            }
            else
                label1.Top = label1.Top + vy;
            */
            label1.Left = label1.Left + vx;
            label1.Top = label1.Top + vy;
            if (label1.Left < 0)
            {
                vx = Math.Abs(vx + (vx / 10));

            }
            else if (label1.Right > ClientSize.Width)
            {
                
                vx = -Math.Abs(vx + (vx / 10));
            }    
            if (label1.Top < 0)
            {

                vy = Math.Abs(vy + (vy / 10));
            }    
            else if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy + (vy / 10));

            }
            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vy = -10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vy = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}