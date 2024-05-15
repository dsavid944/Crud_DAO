using System;
using System.Windows.Forms;
using Crud_DAO.Forms;

namespace Crud_DAO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ViewFuncionariosForm viewForm = new ViewFuncionariosForm();
            viewForm.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FuncionarioForm addForm = new FuncionarioForm();
            addForm.ShowDialog();
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            string input = InputBox.Show("Gestión de Funcionarios", "Ingrese el número de documento del funcionario a gestionar:");
            if (!string.IsNullOrEmpty(input))
            {
                UpdateFuncionarioForm updateForm = new UpdateFuncionarioForm(input);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Número de documento no válido. Por favor, intente de nuevo.");
            }
        }
    }
}
