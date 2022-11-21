using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zk_snake_tool
{
    public partial class Form1 : Form
    {
        bool[] values = new bool[25];

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var button = (CheckBox)sender;
            var changedButton = int.Parse(button.Name.Replace("checkBox", ""));
            values[changedButton - 1] = !values[changedButton-1];
            var labelText = 0;
            for(int i = 0; i < values.Length; i++)
            {
                if(values[values.Length - i - 1])
                {
                    labelText += 1 << i;
                }
            }
            label1.Text = labelText.ToString();
        }
    }
}
