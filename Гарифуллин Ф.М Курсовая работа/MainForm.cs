using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Гарифуллин_Ф.М_Курсовая_работа
{
    public partial class MainForm : Form
    {
        Management _management;
        Visualizer _visualizer;
        Param _param;

        public MainForm()
        {
            InitializeComponent();
        }
        private void SetParam(Param param)
        {
            _param = param;
            if ( param == null)
            {
                return;
            }
            

            
        }
        private void Draw()
        {

            if (_visualizer == null)
            {
                return;
            }
            Bitmap bmp = new(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _visualizer.Drawning(gr, _management._realization.num);
            pictureBox1.Image = bmp;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            _management = new Management(_param);
            _management.PerformOperation();
            if (_management._storage == null)
            {
                return;

            }
            _visualizer = new Visualizer(_management._storage._states[0]);
            Draw();

        }
        int j = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            if (_management._storage == null || j + 1 >= _management._storage._states.Count)
            {
                return;
            }
            else j++;
            _visualizer = new Visualizer(_management._storage._states[j]);
            Draw();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (_management._storage == null || j - 1 < 0)
            {
                return;
            }
            else j--;

            _visualizer = new Visualizer(_management._storage._states[j]);
            Draw();
        }

     

        private void buttonSetParam_Click(object sender, EventArgs e)
        {
            ParamForm form = new();
            form.AddEvent(SetParam);
            form.Show();
            
        }
    }
}
