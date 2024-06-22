using System.Data;

namespace Presentacion
{
    public partial class FormAdmProfes : Form
    {
        private object objNegProf;
        private object objEntProf;

        public FormAdmProfes()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            dgvProfesionales.ColumnCount = 2;
            dgvProfesionales.Columns[0].HeaderText = "Código";
            dgvProfesionales.Columns[1].HeaderText = "Nombre";
            dgvProfesionales.Columns[0].Width = 60;
            dgvProfesionales.Columns[1].Width = 200;
            LlenarDGV();
        }

        private void LlenarDGV()
        {
            dgvProfesionales.Rows.Clear();

            DataSet ds = objNegProf.listadoProfesionales("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
            {
                LbMensajeError.Text = "No hay profesionales cargados en el sistema";
            }

            private void TxtBox_a_Obj()
            {
                objEntProf.CodProf = int.Parse(TxCodigo.Text);
                objEntProf.Nombre = TxNombre.Text;
            }
        }



    }
}
