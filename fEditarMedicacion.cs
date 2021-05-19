using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MedicacionAlerxias
{
    public partial class fEditarMedicacion : Form
    {
        private clsBd oBD;
        private clsMedicacion oMedicacion;
        private clsDiarioDoses oDiario;
        private DataSet dsMedicacion;

        public fEditarMedicacion(clsBd oBD, clsMedicacion oMedicacion, clsDiarioDoses oDiario)
        {
            InitializeComponent();

            this.oBD = oBD;
            this.oMedicacion = oMedicacion;
            this.oDiario = oDiario;

        }

        private void fEditarMedicacion_Load(object sender, EventArgs e)
        {
            bts_CRUD_Enabler();
            verMedicacion();
        }

        private void verMedicacion() //TODO unselect dgv
        {
            dgvMedicacion.Rows.Clear();
            dsMedicacion = oMedicacion.obterTodaMedicacion(oBD);
            for (int i = 0; i < dsMedicacion.Tables[0].Rows.Count; i++)
            {
                dgvMedicacion.Rows.Add(dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_NOME],
                                    dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_LABORATORIO],
                                    dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_TRATAMENTO],
                                    dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_INFO_RESUMIDA]);
            }
            dgvMedicacion.CurrentCell = null;
        }

        private void bts_CRUD_Enabler()
        {
            btGardar.Enabled = (txbNome.Text != "" && txbLaboratorio.Text != "" && txbTratamento.Text != "" && txbInfoResumida.Text != "") && valoresCambiados();
            btLimpar.Enabled = btEliminar.Enabled = dgvMedicacion.CurrentRow != null;
        }

        private bool valoresCambiados() // Verifica se os valores foron cambiados respecto dos iniciais.
        {
            return (txbNome.Text != oMedicacion.Nome || txbLaboratorio.Text != oMedicacion.Laboratorio ||
                    txbTratamento.Text != oMedicacion.Tratamento || txbInfoResumida.Text != oMedicacion.InfoResumida);
        }

        private void limpiarCampos()
        {
            txbNome.Clear();
            txbLaboratorio.Clear();
            txbTratamento.Clear();
            txbInfoResumida.Clear();
            dgvMedicacion.CurrentCell = null;
        }

        private void cargarDatosNosCampos() // Mostramos os datos nos campos e pasámolos a clsMedicacion, para poder eliminalos, por exemplo.
        {
            int index = dgvMedicacion.CurrentRow.Index;
            oMedicacion.Nome = txbNome.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_NOME]);
            oMedicacion.Laboratorio = txbLaboratorio.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_LABORATORIO]);
            oMedicacion.Tratamento = txbTratamento.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_TRATAMENTO]);
            oMedicacion.InfoResumida = txbInfoResumida.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_INFO_RESUMIDA]);
        }

        private void asignarPropiedadesMedicacion() // Asignamos os valores ás propiedades para futura inserción / modificación.
        {
            oMedicacion.Nome = txbNome.Text;
            oMedicacion.Laboratorio = txbLaboratorio.Text;
            oMedicacion.Tratamento = txbTratamento.Text;
            oMedicacion.InfoResumida = txbInfoResumida.Text;
        }


        private void procesoGardar()
        {
            try
            {
                if (dgvMedicacion.CurrentRow != null)
                {
                    DialogResult result = MessageBox.Show("DESEXA MODIFICAR A MEDICACIÓN SELECCIONADA?\n\n" +
                                                          "Se o que desexa é engadir unha nova, prema '" + DialogResult.No.ToString() + "', e será engadida.\n" +
                                                          "Cancele para saír.",
                                                          "MODIFICACIÓN OU INSERCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //oMedicacion.Id = Convert.ToInt32(dsMedicacion.Tables[0].Rows[dgvMedicacion.CurrentRow.Index][clsMedicacion.INDEX_ID]);
                        asignarPropiedadesMedicacion();
                        oMedicacion.actualizarMedicacion(oBD);
                        MessageBox.Show("A medicación seleccionada foi actualizada con éxito.", "ACTUALIZACIÓN de Medicación",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(result == DialogResult.No)
                    {
                        asignarPropiedadesMedicacion();
                        oMedicacion.gardarMedicacion(oBD);
                        MessageBox.Show("A medicación foi engadida con éxito.", "INSERCIÓN de nova Medicación",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Ningunha medicación foi modificada nin engadida. Operación cancelada con éxito", "CANCELACIÓN",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    asignarPropiedadesMedicacion();
                    oMedicacion.gardarMedicacion(oBD);
                    MessageBox.Show("A medicación foi engadida con éxito.", "INSERCIÓN de nova Medicación",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.Write("--- Excepción en clase 'fEditarMedicacion.cs'. MENSAXE: " + ex.Message);
                MessageBox.Show("Ocorreu un erro inesperado ao intentar gardar a medicación. Faga outro intento, e se o erro persiste, póñase en contacto co equipo de mantemento.",
                                "ERRO de inserción na BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void procesoEliminar()
        {
            try
            {
                DialogResult result = MessageBox.Show("Está seguro de que desexa eliminar a medicación seleccionada? Tamén se eliminarán todas as tomas relacionadas.", 
                                                      "ELIMINACIÓN de Medicación e Tomas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    oDiario.IdMedicacion = oMedicacion.Id; // Asignado ao facer click nunha celda do DataGridView.
                    oDiario.eliminarTomasPorIdMedicacion(oBD);
                    oMedicacion.eliminarMedicacionPorId(oBD);
                    MessageBox.Show("A medicación seleccionada, e as tomas relacionadas, foron eliminadas con éxito.", "ELIMINACIÓN de Medicación e Tomas",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ningunha medicación nin tomas foron eliminadas. Operación cancelada satisfactoriamente.", "ELIMINACIÓN de Medicación e Tomas",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.Write("--- Excepción en clase 'fEditarMedicacion.cs'. MENSAXE: " + ex.Message);
                MessageBox.Show("Ocorreu un erro inesperado ao intentar eliminar a medicación. Faga outro intento, e se o erro persiste, póñase en contacto co equipo de mantemento.",
                                "ERRO de inserción na BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bts_CRUD_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name.Contains("Gardar")) // Se o botón premido foi btGardar...
            {
                procesoGardar(); // ... iniciamos o proceso de inserción / modificación.
            }
            else if (((Button)sender).Name.Contains("Eliminar")) // Se o botón premido foi btEliminar...
            {
                procesoEliminar(); // iniciamos o proceso de eliminacion.
            }

            // Se o botón premido foi btLimpar xa non entra nos ifs e limpa de todas formas.

            limpiarCampos(); // Limpamos os campos.
            bts_CRUD_Enabler(); // Habilitamos / deshabilitamos os botóns.
            verMedicacion(); // volvemos a listar a medicación.
        }

        private void dgvResumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarDatosNosCampos();
            oMedicacion.Id = Convert.ToInt32(dsMedicacion.Tables[0].Rows[dgvMedicacion.CurrentRow.Index][clsMedicacion.INDEX_ID]);
            bts_CRUD_Enabler();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbs_Campos_TextChanged(object sender, EventArgs e)
        {
            bts_CRUD_Enabler();
        }

    }
}
