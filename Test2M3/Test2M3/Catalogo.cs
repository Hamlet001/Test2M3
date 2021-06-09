using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2M3.Model;

namespace Test2M3
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        public Catalogo ProductModel { get; private set; }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            AddProd f = new AddProd();
            ProductModel = this;
            f.Text = "Form - " + this.MdiChildren.Length.ToString();
            f.Show();
        }
    }
}
