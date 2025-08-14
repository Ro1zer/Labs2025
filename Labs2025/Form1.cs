using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Country first = new Country("United Kingdom", 244_376, 68_265_209, "London", 8_945_309);
            Country second = new Country("United States", 8_080_470, 340_110_988, "Washington, D.C.", 689_545);
            first.SetName("Ukraine");
            first.SetSquare(603_550);
            first.SetPopulation(32_862_000);
            first.SetCapitalName("Kyiv");
            first.SetCapitalPopulation(2_952_301);
            MessageBox.Show(first.ToString());
            MessageBox.Show(second.ToString());
            Close();
        }
    }
}
