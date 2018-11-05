using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_pacientes.Catalogos
{
    public partial class CatVacunasPanel : UserControl
    {
        String consultasql;
        Utils.GlobalFunctions opSql = new Utils.GlobalFunctions();
        int pacienteid = 0, expedienteoid = 0, consultaid = 0;
        public CatVacunasPanel()
        {
            InitializeComponent();
        }
        void HabilitarObjetos(bool estado = false)
        {
            //txtNombre.Enabled = estado;
            //txtUsuario.Enabled = estado;
            //txtClave.Enabled = estado;
            //txtConfirmacion.Enabled = estado;
            cmbExpediente.Enabled = false;
            cmbDoctor.Enabled = false;
        }

        public void LimpiarObjetos()
        {
            //txtNombre.Clear();
            //txtUsuario.Clear();
            //txtClave.Clear();
            //txtConfirmacion.Clear();
            cmbPaciente.SelectedIndex = 0;
        }

        void MostrarPacientes()
        {
            opSql.FillComboBox(cmbPaciente, "pacienteID", "nombre");
        }

        void MostrarTipoVacunas()
        {
            opSql.FillCombo(cmbTipoVacunas, "tipoVacunaID", "nombre");
        }

        private void CatVacunasPanel_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
            MostrarTipoVacunas();
            HabilitarObjetos();
        }


    }
}
