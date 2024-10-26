using LOGIN;

namespace THANHVIEN
{
    public partial class Maytram : Form
    {
        public Maytram()
        {
            InitializeComponent();
        }

        private void btnNAPTIEN_Click(object sender, EventArgs e)
        {
            Naptien nt = new Naptien();
            nt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trutien tt = new Trutien();
            tt.ShowDialog();
        }
    }
}
