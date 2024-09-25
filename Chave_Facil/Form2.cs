using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chave_Facil
{
    public partial class FrmFunc : Form
    {
        public FrmFunc()
        {
            InitializeComponent();
        }

        public static string nomeFunc;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFunc.Text))
            {
                MessageBox.Show("Este campo não pode ser vazio");
                return;
            }
            
            nomeFunc = txtFunc.Text;
          //  MessageBox.Show(a);
            this.Close();
        }
    }
}
