using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chave_Facil
{
    public partial class FrmChaveFacil : Form
    {
        public FrmFunc frmFunc;
        private RetirarDevolver retirarDevolver;

        public FrmChaveFacil()
        {
            InitializeComponent();
            retirarDevolver = new RetirarDevolver();

    }

    /*private void RetirarChave(Button btnDevolver, Button btnRetirar, Panel panelSala)
        {
            btnDevolver.Enabled = true;
            btnRetirar.Enabled = false;
            panelSala.BackColor = Color.Red;

            FrmFunc frmFunc = new FrmFunc();
            frmFunc.ShowDialog();

            string resultado = FrmFunc.a;
            MessageBox.Show(resultado);
        }

        private void DevolverChave(Button btnDevolver, Button btnRetirar, Panel panelSala)
        {
            btnDevolver.Enabled = false;
            btnRetirar.Enabled = true;
            panelSala.BackColor = Color.Lime;

            FrmFunc frmFunc = new FrmFunc();
            frmFunc.ShowDialog();

            string resultado = FrmFunc.a;
            MessageBox.Show(resultado);
        }
    */
        private void btnRtrS1_Click(object sender, EventArgs e)
        {
            retirarDevolver.RetirarChave(btnDvlrS1, btnRtrS1, pnSala1);
         /* btnDvlrS1.Enabled = true;
            btnRtrS1.Enabled = false;
            pnSala1.BackColor = Color.Red;
            FrmFunc frmFunc = new FrmFunc();
            frmFunc.ShowDialog();

            string teste = FrmFunc.a;
            MessageBox.Show(a); */
        }

        private void btnDvlrS1_Click(object sender, EventArgs e)
        {
            retirarDevolver.DevolverChave(btnDvlrS1, btnRtrS1, pnSala1);
            /* btnDvlrS1.Enabled = false;
               btnRtrS1.Enabled = true;
               pnSala1.BackColor = Color.Lime;
               FrmFunc frmFunc = new FrmFunc();
               frmFunc.ShowDialog(); */
        }
    }
}
