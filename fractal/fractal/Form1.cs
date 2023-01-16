namespace fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void drawF(int x, int y, int lenght, double angle, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            double x1;
            double y1;
            x1 = x + lenght * Math.Sin(angle * Math.PI * 2 / 360.0);
            y1 = y + lenght * Math.Cos(angle * Math.PI * 2 / 360.0);

            g.DrawLine(new Pen(Color.Black), x, y, (int)x1, (int)y1);
            if (lenght > 2)
            {
                drawF((int)x1, (int)y1, (int)(lenght / 1.5), angle + 30, e);
                drawF((int)x1, (int)y1, (int)(lenght / 1.5), angle - 30, e);
                drawF((int)x1, (int)y1, (int)(lenght / 1.5), angle + 15, e);
                drawF((int)x1, (int)y1, (int)(lenght / 1.5), angle - 15, e);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            drawF(panel1.Width / 2, 0, 200, 0, e);

        }
    }
}