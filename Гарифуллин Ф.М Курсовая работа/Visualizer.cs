
using static System.Windows.Forms.DataFormats;

namespace Гарифуллин_Ф.М_Курсовая_работа
{
    internal class Visualizer
    {

        State? _state { get; set; }

        /// <summary>
        /// ширина окна
        /// </summary>
        private int? _pictureWidth;

        /// <summary>
        /// высота окна
        /// </summary>
        private int? _pictureHeight;


        public Visualizer(State state)
        {
            _state = state;
        }
        public virtual void Drawning(Graphics g,int num)
        {
           
            if (_state == null)
            {
              return;
            }
            
            Pen pen = new(Color.Black);
            Pen pen1 = new(Color.Blue, 1);
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            SolidBrush drawBrush1 = new SolidBrush(Color.Red);
            StringFormat drawFormat = new StringFormat();
            for (int i = 0; i < _state.Mas.Length; i++)
            {
                string str = _state.Mas[i].ToString();
                if (_state.Mas[i] == num)
                {
                     g.DrawString(str, drawFont, drawBrush1,i*30, 20, drawFormat);
                }
                else {
                    g.DrawString(str, drawFont, drawBrush, i * 30, 20, drawFormat);
                }
               
                g.DrawRectangle(pen, i * 30, 20, 20, 20);
            }
            g.DrawEllipse(pen1, _state.Index * 30, 20, 20, 20);
        }

    }
}
