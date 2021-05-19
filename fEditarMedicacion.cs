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
        private clsBd oBD; // Para enviarlle este obxeto aos métodos do CRUD, e non instancialo de cada vez.
        private clsMedicacion oMedicacion; // Para ter acceso ás propiedades de clsMedicacion e aos métodos do CRUD.
        private clsDiarioDoses oDiario; // O mesmo para clsDiarioDoses.
        private DataSet dsMedicacion; // Para ter os valores da medicación recollidos.

        public fEditarMedicacion(clsBd oBD, clsMedicacion oMedicacion, clsDiarioDoses oDiario) // Recibimos estes parámetros e asignámolos.
        {
            InitializeComponent(); // Inicializamos os compoñentes.

            // Asignamos os parámetros ás variables da clase.
            this.oBD = oBD;
            this.oMedicacion = oMedicacion;
            this.oDiario = oDiario;

        }

        private void fEditarMedicacion_Load(object sender, EventArgs e) // No momento de cargar o formulario...
        {
            bts_CRUD_Enabler(); // ... habilitamos / inhabilitamos os botóns, ...
            verMedicacion(); // ... e listamos a medicación.
        }

        private void verMedicacion() // Para listar a medicación.
        {
            dgvMedicacion.Rows.Clear(); // Limpamos o DGV
            dsMedicacion = oMedicacion.obterTodaMedicacion(oBD); // Gardamos no DataSet a medicación recollida na Base de Datos.
            for (int i = 0; i < dsMedicacion.Tables[0].Rows.Count; i++) // Percorremos o DS...
            {
                dgvMedicacion.Rows.Add( dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_ID],
                                        dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_NOME],
                                        dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_LABORATORIO],
                                        dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_TRATAMENTO],
                                        dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_INFO_RESUMIDA]);
                // ... e engadimos a cada fila as propiedades correspondentes do DataSet. (recordemos que o Id está oculto)
            }
            dgvMedicacion.CurrentCell = null; // de-seleccionamos calquere posible fila.
        }

        private void bts_CRUD_Enabler() // Para habilitar / deshabilitar os botóns en función de varias condicións:
        {
            // Se os campos non están vacíos e o valor que teñen cambia respecto ao que había na BD.
            btGardar.Enabled = (txbNome.Text != "" && txbLaboratorio.Text != "" && txbTratamento.Text != "" && txbInfoResumida.Text != "") && valoresCambiados();

            //Se  hai unha fila seleccionada
            btLimpar.Enabled = btEliminar.Enabled = dgvMedicacion.CurrentRow != null;
        }

        private bool valoresCambiados() // Verifica se os valores foron cambiados respecto dos iniciais.
        {
            return (txbNome.Text != oMedicacion.Nome || txbLaboratorio.Text != oMedicacion.Laboratorio ||
                    txbTratamento.Text != oMedicacion.Tratamento || txbInfoResumida.Text != oMedicacion.InfoResumida);
        }

        private void limpiarCampos() // Deixa os campos aos valores por defecto, e de-selecciona calquera fila do DGV.
        {
            txbNome.Clear();
            txbLaboratorio.Clear();
            txbTratamento.Clear();
            txbInfoResumida.Clear();
            dgvMedicacion.CurrentCell = null;
        }

        private void cargarDatosNosCampos() // Mostramos os datos nos campos e pasámolos a clsMedicacion, para poder eliminalos, por exemplo.
        {
            int index = dgvMedicacion.CurrentRow.Index; // Gardamos o índice da fila seleccionada. Empregámolo para escoller a fila correcta do
            // dsMedicación, que foi previamente ordenado no evento "dgvMedicacion_Sorted()".

            // Gardamos os valores nos campos.
            txbNome.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_NOME]);
            txbLaboratorio.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_LABORATORIO]);
            txbTratamento.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_TRATAMENTO]);
            txbInfoResumida.Text = Convert.ToString(dsMedicacion.Tables[0].Rows[index][clsMedicacion.INDEX_INFO_RESUMIDA]);
            asignarPropiedadesMedicacion(); // Gardamos os valores dos campos nas propiedades da clase clsMedicacion.
        }

        private void asignarPropiedadesMedicacion() // Asignamos os valores ás propiedades para futura inserción / modificación.
        {
            oMedicacion.Nome = txbNome.Text;
            oMedicacion.Laboratorio = txbLaboratorio.Text;
            oMedicacion.Tratamento = txbTratamento.Text;
            oMedicacion.InfoResumida = txbInfoResumida.Text;
        }


        private void procesoGardar() // Para o relativo á inserción na BD.
        {
            try
            {
                if (dgvMedicacion.CurrentRow != null) // Se hai unha fila seleccionada...
                {
                    // ... preguntamos se se quere actualizar a fila ou engadir un rexistro.
                    DialogResult result = MessageBox.Show("DESEXA MODIFICAR A MEDICACIÓN SELECCIONADA?\n\n" +
                                                          "Se o que desexa é engadir unha nova, prema '" + DialogResult.No.ToString() + "', e será engadida.\n" +
                                                          "Cancele para saír.",
                                                          "MODIFICACIÓN OU INSERCIÓN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) // Se o resultado é que se quere modificar a fila...
                    {
                        asignarPropiedadesMedicacion(); // ... asígnanse os novos valores ás propiedades, ...
                        oMedicacion.actualizarMedicacion(oBD); // ... inténtase actualizar a fila, ...
                        // ... e se todo foi correcto, mostramos a mensaxe de satisfacción.
                        MessageBox.Show("A medicación seleccionada foi actualizada con éxito.", "ACTUALIZACIÓN de Medicación",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(result == DialogResult.No) // Se o resultado é que se quere engadir unha nova fila...
                    {
                        asignarPropiedadesMedicacion(); // ... asígnanse os novos valores ás propiedades, ...
                        oMedicacion.gardarMedicacion(oBD); // ... inténtase gardar a nova medicación, ...
                        // ... e se se consigue, mostramos a mensaxe de satisfacción.
                        MessageBox.Show("A medicación foi engadida con éxito.", "INSERCIÓN de nova Medicación",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (result == DialogResult.Cancel) // Se o resultado é que se quere cancelar a operación ...
                    {
                        // ... mostramos unha mensaxe de éxito de cancelación.
                        MessageBox.Show("Ningunha medicación foi modificada nin engadida. Operación cancelada con éxito", "CANCELACIÓN",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else // Se non hai ningunha fila seleccionada...
                {
                    // ... directamente ...
                    asignarPropiedadesMedicacion(); // ... asignamos os novos valores ás propiedades da clase, ...
                    oMedicacion.gardarMedicacion(oBD); // ... intentamos insertar os valores na BD, ...
                    // ... e se se consigue, mostramos a mensaxe de satisfacción.
                    MessageBox.Show("A medicación foi engadida con éxito.", "INSERCIÓN de nova Medicación",
                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // Se houbese algún erro nalgunha operación, ...
            {
                // ... mostramos unha mensaxe co erro por consola, e notificamos do mesmo ao usuario.
                Console.Write("--- Excepción en clase '" + this.Name + "'. MENSAXE: " + ex.Message);
                MessageBox.Show("Ocorreu un erro inesperado ao intentar gardar a medicación. Faga outro intento, e se o erro persiste, póñase en contacto co equipo de mantemento.",
                                "ERRO de inserción na BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void procesoEliminar() // Para todo o relativo ao proceso de eliminar.
        {
            try
            {
                // Pedimos confirmación por se o usuario se equivocou.
                DialogResult result = MessageBox.Show("Está seguro de que desexa eliminar a medicación seleccionada? Tamén se eliminarán todas as tomas relacionadas.", 
                                                      "ELIMINACIÓN de Medicación e Tomas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes) // Se quere eliminar...
                {
                    // Asignamos o Id da medicación ás propiedades de clsDiarioDoses, para eliminar as tomas da medicación que tamén imos eliminar (simulamos efecto cascada).
                    oDiario.IdMedicacion = oMedicacion.Id; // Asignado ao facer click nunha celda do DataGridView, evento "dgvMedicacion_Sorted()".
                    oDiario.eliminarTomasPorIdMedicacion(oBD); // Eliminamos todas as tomas relacionadas coa medicación en cuestión.
                    oMedicacion.eliminarMedicacionPorId(oBD); // Eliminamos dita medicación.
                    // Se todo foi ben, mostramos unha mensaxe de satisfacción.
                    MessageBox.Show("A medicación seleccionada, e as tomas relacionadas, foron eliminadas con éxito.", "ELIMINACIÓN de Medicación e Tomas",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Se quere cancelar a eliminación...
                {
                    // Mostramos unha mensaxe de confirmación de cancelación.
                    MessageBox.Show("Ningunha medicación nin tomas foron eliminadas. Operación cancelada satisfactoriamente.", "ELIMINACIÓN de Medicación e Tomas",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // Se houbese algún erro nalgunha operación, ...
            {
                // ... mostramos unha mensaxe co erro por consola, e notificamos do mesmo ao usuario.
                Console.Write("--- Excepción en clase '" + this.Name + "'. MENSAXE: " + ex.Message);
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

        private void dgvMedicacion_CellClick(object sender, DataGridViewCellEventArgs e) // Cando se fai click nunha celda do DGV...
        {
            cargarDatosNosCampos(); // ... cargamos os datos nos campos, ...
            // ... gardamos o Id da medicación nas propiedades da clase, ...
            oMedicacion.Id = Convert.ToInt32(dsMedicacion.Tables[0].Rows[dgvMedicacion.CurrentRow.Index][clsMedicacion.INDEX_ID]);
            bts_CRUD_Enabler(); // ... e habilitamos / inhabilitamos os botóns.
        }

        private void dgvMedicacion_Sorted(object sender, EventArgs e) // Cando ordenamos o DGV (click na cabeceira das columnas que o permiten)...
        {
            dsMedicacion.Clear(); // ... limpamos o DataSet dsMedicacion, ...
            for (int i = 0; i < dgvMedicacion.Rows.Count; i++) // ... percorremos as filas do DGV, ...
            {
                // ... e gardamos as os valores de cada fila nas propiedades da clase clsMedicación.
                oMedicacion.Id = Convert.ToInt32(dgvMedicacion.Rows[i].Cells[clsMedicacion.INDEX_ID].Value);
                oMedicacion.Nome = Convert.ToString(dgvMedicacion.Rows[i].Cells[clsMedicacion.INDEX_NOME].Value);
                oMedicacion.Laboratorio = Convert.ToString(dgvMedicacion.Rows[i].Cells[clsMedicacion.INDEX_LABORATORIO].Value);
                oMedicacion.Tratamento = Convert.ToString(dgvMedicacion.Rows[i].Cells[clsMedicacion.INDEX_TRATAMENTO].Value);
                oMedicacion.InfoResumida = Convert.ToString(dgvMedicacion.Rows[i].Cells[clsMedicacion.INDEX_INFO_RESUMIDA].Value);

                // Por último, engadimos a fila ao DataSet cos valores gardados anteriormente en oMedicacion.
                dsMedicacion.Tables[0].Rows.Add(oMedicacion.Id, oMedicacion.Nome, oMedicacion.Laboratorio, oMedicacion.Tratamento, oMedicacion.InfoResumida);
            }
        }

        private void btAtras_Click(object sender, EventArgs e) // Evento Click do botón btAtras.
        {
            this.Close(); // Cerramos o formulario.
        }

        private void txbs_Campos_TextChanged(object sender, EventArgs e) // Cando o texto dalgún dos TexBoxes cambia, ...
        {
            bts_CRUD_Enabler(); // ... comprobamos se hai que habilitar os botóns.
        }
    }
}
