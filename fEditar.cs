using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicacionAlerxias
{
    public partial class fEditar : Form
    {

        private clsBd oBD; // Porque imos necesitar facer operacións sobre a BD.
        private clsMedicacion oMedicacion; // Para ter os datos da medicación, como o Nome.
        private DataSet dsMedicacion; // Para ter os datos da medicación no ComboBox.
        private DataSet dsDiarioDoses; // Para ter os datos das tomas.
        private clsDiarioDoses oDiario; // Para poder manexar as propiedades e realizar operacións de acceso á BD.
        private int tomaIndex; // Para ter o índice da fila seleccionada do DataGridView, mesmo que no dsDiarioDoses.

        public fEditar(clsBd oBD, clsMedicacion oMedicacion, DataSet dsMedicacion, DataSet dsDiarioDoses, clsDiarioDoses oDiario, int index) // Recibimos os parámetros recollemos o seu valor nos propios da clase.
        {
            InitializeComponent();
            this.oBD = oBD;
            this.oMedicacion = oMedicacion;
            this.dsMedicacion = dsMedicacion;
            this.dsDiarioDoses = dsDiarioDoses;
            this.oDiario = oDiario;
            this.tomaIndex = index;

            encherCampos(); // Enchemos os campos cos valores recibidos.
            btGardarEnabler(); // Comprobamos se o botón btGardar pode habilitarse. (Aquí inhabilitarase: ver condicións dentro do método)
        }

        

        private void encherCampos() // Enche os campos e garda os valores iniciais en variables, para máis sinxelo manexo dos mesmos máis adiante.
        {
            clsFuncionsComuns.encherCbxMedicacion(ref cbxMedicacion, ref dsMedicacion); // Enchemos o ComboBox pasando as referencias do combo e do DataSet.

            // Asignamos valor aos compoñentes, e gardamos os mesmos valores nas propiedades da clase clsDiarioDoses, para próximo uso.
            oDiario.DataHora = dtpData.Value = Convert.ToDateTime(dsDiarioDoses.Tables[0].Rows[tomaIndex][clsDiarioDoses.INDEX_DATA_HORA]);

            oMedicacion.Id = oDiario.IdMedicacion = Convert.ToInt32(dsDiarioDoses.Tables[0].Rows[tomaIndex][clsDiarioDoses.INDEX_ID_MEDICACION]);

            cbxMedicacion.SelectedItem = Convert.ToString((oMedicacion.obterNomeMedicacionPorId(oBD)).Tables[0].Rows[0][0]);

            oDiario.VecesDia = Convert.ToInt32(nudDoses.Value = Convert.ToInt32(dsDiarioDoses.Tables[0].Rows[tomaIndex][clsDiarioDoses.INDEX_VECES_DIA]));
            oDiario.Observacions = txbObservacions.Text = Convert.ToString(dsDiarioDoses.Tables[0].Rows[tomaIndex][clsDiarioDoses.INDEX_OBSERVACIONS]);
        }

        private bool valoresCambiados() // Verifica se os valores foron cambiados respecto dos iniciais.
        {
            return (dtpData.Value != oDiario.DataHora || cbxMedicacion.SelectedIndex != oDiario.IdMedicacion || 
                    nudDoses.Value != oDiario.VecesDia || txbObservacions.Text != oDiario.Observacions);
        }

        private void btGardarEnabler() // Habilita o botón se se cumpren as condicións.
        {
            btGardar.Enabled = (dtpData.Value != null && cbxMedicacion.SelectedIndex != -1 && nudDoses.Value != 0) && valoresCambiados();
            // Desta forma, sabemos que se están a introducir datos válidos e con cambios.
        }

        private void cbxMedicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxInfoResumida.Items.Clear(); // Limpamos o ListBox para 'substituir' o texto a mostrar polo antigo.
            lbxInfoResumida.Items.Add((dsMedicacion.Tables[0].Rows[cbxMedicacion.SelectedIndex][clsMedicacion.INDEX_INFO_RESUMIDA]).ToString());
            //Mostramos o novo texto, que chega dende a BD.

            btGardarEnabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }


        private void bts_Gardar_Cancelar_Click(object sender, EventArgs e) // Evento click para os botóns.
        {
            if (((Button)sender).Name.Contains("Gardar")) // Se o botón é btGardar...
            {
                actualizarBD(); // ... actualizamos a BD.
            }
            else if (((Button)sender).Name.Contains("Cancelar") || ((Button)sender).Name.Contains("Atras")) // Se o botón é btCancelar ou btAtras...
            {
                this.Close(); // ... cerramos o formulario.
            }
        }

        private void actualizarBD() // Método para facer os pasos previos á inserción dos datos na BD.
        {
            try
            {
                // Asignamos os novos valores ás propiedades da clase clsDiarioDoses.
                oDiario.Id = Convert.ToInt32(dsDiarioDoses.Tables[0].Rows[tomaIndex][clsDiarioDoses.INDEX_ID]);
                oDiario.DataHora = dtpData.Value;
                oDiario.IdMedicacion = Convert.ToInt32(dsMedicacion.Tables[0].Rows[cbxMedicacion.SelectedIndex][clsMedicacion.INDEX_ID]);
                oDiario.VecesDia = Convert.ToInt32(nudDoses.Value);
                oDiario.Observacions = txbObservacions.Text;

                // Actualizamos a BD cos datos recollidos anteriormente.
                oDiario.actualizarToma(oBD);

                //Se nada falla, mostramos unha mensaxe de confirmación.
                MessageBox.Show("Toma actualizada correctamente.", "ACTAULIZACIÓN DE TOMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Se algo falla, mostramos o erro por consola e imprimimos unha mensaxe de erro.
                Console.Write("--- Excepción na clase 'clsDiarioDoses'. MENSAXE: " + ex.Message);
                MessageBox.Show("Houbo un erro inesperado mentres se intentaba actualizar a toma. Inténteo de novo, e póñase en contacto co servizo de mantemento se o erro persiste.",
                                "ACTUALIZACIÓN DE TOMA. ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void nudDoses_ValueChanged(object sender, EventArgs e)
        {
            btGardarEnabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

        private void txbObservacions_TextChanged(object sender, EventArgs e)
        {
            btGardarEnabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            btGardarEnabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

    }
}
