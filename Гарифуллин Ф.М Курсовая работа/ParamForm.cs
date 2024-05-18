using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гарифуллин_Ф.М_Курсовая_работа
{
    public partial class ParamForm : Form
    {
        private event Action<Param>? _Delegate;
        private Param _param = new Param();
        public ParamForm()
        {
            InitializeComponent();
        }
        public void AddEvent(Action<Param> Delegate)
        {
            _Delegate += Delegate;
        }
        public int[] ParseString(string str)
        {
            return str.Split(' ').Select(x => int.Parse(x)).ToArray();
        }
        private void buttonSetParam_Click(object sender, EventArgs e)
        {
            _param.mas = ParseString(textBox1.Text);
            _param.a = int.Parse(textBox2.Text);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (_param != null)
            {
                _Delegate?.Invoke(_param);
                Close();
            }
           
        }


    }
}
