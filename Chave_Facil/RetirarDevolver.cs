using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chave_Facil
{
    public class RetirarDevolver
    {
        public void RetirarChave(Button btnDevolver, Button btnRetirar, Panel panelSala)
        {
            {
                btnDevolver.Enabled = true;
                btnRetirar.Enabled = false;
                panelSala.BackColor = Color.Red;

                FrmFunc frmFunc = new FrmFunc();
                frmFunc.ShowDialog();

                string resultado = FrmFunc.a;
                MessageBox.Show(resultado);

            }
        }
        public void DevolverChave(Button btnDevolver, Button btnRetirar, Panel panelSala)
        {
            {
                btnDevolver.Enabled = false;
                btnRetirar.Enabled = true;
                panelSala.BackColor = Color.Lime;

                FrmFunc frmFunc = new FrmFunc();
                frmFunc.ShowDialog();
                string resultado = FrmFunc.a;
                MessageBox.Show(resultado);
            }
        }
        
    }
}
