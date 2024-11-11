namespace DoAn4
{
    public partial class Form1 : Form
    {
        private int x = 300;
        private int y = 150;
        
        private bool xoa = true;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(Ve);
            this.KeyDown += new KeyEventHandler(DieuKhien);

        }
        private void Ve(object sender, PaintEventArgs e)
        {
            if (xoa)
            {
                {
                    Graphics g = e.Graphics;
                    g.FillEllipse(Brushes.DarkKhaki, x  , y , 150, 150);
                }

            }



        }
            
        private void DieuKhien(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (y != 0)
                        y -= 10;
                        break;
                case Keys.Down:
                    if (y != 650)
                    y += 10;
                    break;
                case Keys.Left:
                    if (x != 0)
                    x -= 10;
                    break;
                case Keys.Right:
                    if ( x != 680 )
                    x += 10;
                    break;
                case Keys.V:
                    this.xoa = true;
                    break;
                case Keys.X:
                    this.xoa = false;
                    break;
            }

            this.Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

