using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wesley.Model;

namespace Wesley
{
    public partial class frmACME : Form
    {
        public frmACME()
        {
            InitializeComponent();
        }

        private int opr;
        private void frmACME_Load(object sender, EventArgs e)
        {
            try
            {
                SQLLite.CriarBanco();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SQLLite.Delete(opr);
            LoadData();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TBVOO Voo = new TBVOO();
            Voo.DATA_VOO = Convert.ToDateTime(txtData.Text);
            Voo.CUSTO = Convert.ToDecimal(txtCusto.Text);
            Voo.DISTANCIA = Convert.ToInt32(txtDistancia.Text);
            if (rbNao.Checked)
            {
                Voo.CAPTURA = "N";
            }
            if (rbSim.Checked)
            {
                Voo.CAPTURA = "S";
            }
            Voo.NIVEL_DOR = Convert.ToInt32(txtNivelDor.Text);
            if (opr == 0)
            {
                SQLLite.Add(Voo);
            }
            else
            {
                Voo.ID_VOO = opr;
                SQLLite.Update(Voo);
            }
            LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            txtData.Text = "";
            txtCusto.Text = "";
            txtDistancia.Text = "";
            txtNivelDor.Text = "";
            rbNao.Checked = false;
            rbSim.Checked = false;
            opr = 0;
        }

        private void dgvVoos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVoos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVoos.Rows.Count >= 0)
            {
                opr = Convert.ToInt32(dgvVoos.CurrentRow.Cells[0].Value.ToString());
                txtData.Text = dgvVoos.CurrentRow.Cells[1].Value.ToString();
                txtCusto.Text = dgvVoos.CurrentRow.Cells[2].Value.ToString();
                txtDistancia.Text = dgvVoos.CurrentRow.Cells[3].Value.ToString();
                if (dgvVoos.CurrentRow.Cells[4].Value.ToString() == "S")
                {
                    rbSim.Checked = true;
                }
                if (dgvVoos.CurrentRow.Cells[4].Value.ToString() == "N")
                {
                    rbNao.Checked = true;
                }
                txtNivelDor.Text = dgvVoos.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = SQLLite.GetVoos();
                dgvVoos.DataSource = dt;
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
}
