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
    public partial class fIndex : Form
    {
        public fIndex()
        {
            InitializeComponent();
        }

        private clsBd oBD = new clsBd("..\\..\\res\\BD\\medicacion.mdb"); // Instanciamos a clsBD e pasámoslle a ruta relativa á BD.

        private clsMedicacion oMedicacion = new clsMedicacion(); // Para manexar os datos da medicación.
        private clsDiarioDoses oDiario = new clsDiarioDoses(); // Para manexar os datos do diario.

        private DataSet dsMedicacion; // Para recoller os datos da medicación.
        private DataSet dsDiarioDoses; // Para recoller os datos do diario.

        private void fIndex_Load(object sender, EventArgs e)
        {
            oBD.abrirBd(); // Abrimos a BD.

            listarMedicacion(); // Listamos a medicación obtida da BD.

            mostrarTodoTomas(); // Mostramos os datos no DataGridView.

            bts_CRUD_Enabler(); // Habilitamos/inhabilitamos os botóns.
        }

        public void asignarPropiedadesDiario() // Asignamos os valores axeitados a estas propiedades na clase DiarioDoses, para próximo uso dos mesmos.
        {
            oDiario.DataHora = dtpData.Value;
            oDiario.IdMedicacion = Convert.ToInt32(dsMedicacion.Tables[0].Rows[cbxMedicacion.SelectedIndex][clsMedicacion.INDEX_ID]);
            oDiario.VecesDia = Convert.ToInt32(nudDoses.Value);
            oDiario.Observacions = txbObservacions.Text;
        }

        private void comprobarDatosCorrectos() // Pedimos confirmación de inserción
        {
            DialogResult resposta = MessageBox.Show("RESUME: Tomou '" + cbxMedicacion.Text + "' o día " + dtpData.Value.ToShortDateString() + ", " + nudDoses.Value + " dose/s.\n" +
                    "É correcto?",
                    "Información a gardar na base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes) // Se os datos son correctos...
            {
                asignarPropiedadesDiario(); // Dámoslle valor ás propiedades de DiarioDoses para inserilas na BD.
                oDiario.inserirToma(oBD); // Inserimos as propiedades na BD.
                mostrarTodoTomas(); // 'Refrescamos' o DataGridView.
            }
            else // Se os datos non son correctos, mostramos unha mensaxe e non continuamos coa operación.
            {
                MessageBox.Show("Ningunha toma foi inserida.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            limparCampos(); // Limpamos os campos.
        }

        private void mostrarTodoTomas() // Mostramos o historial de tomas da BD.
        {
            dgvDiario.Rows.Clear(); // Limpamos o DataGridView.
            dsDiarioDoses = oDiario.lerTodoTomas(oBD); // Lemos as tomas rexistradas na BD.
            for (int i = 0; i < dsDiarioDoses.Tables[0].Rows.Count; i++) // Percorremos as tomas.
            {
                int idMedicacion = Convert.ToInt32(dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_ID_MEDICACION]);
                // Gardamos o id da Medicación nunha variable, para empregalo á hora de mostrar o nome da mesma.
                oMedicacion.Id = idMedicacion;
                string nomeMedicacion = Convert.ToString((oMedicacion.obterNomeMedicacionPorId(oBD)).Tables[0].Rows[0][0]);
                // O DataSet so devolve o nome, casteamolo e gardámolo nunha variable.

                // O resto dos datos son directamente da taboa DiarioDoses.
                dgvDiario.Rows.Add( dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_ID],
                                    dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_ID_MEDICACION],
                                    nomeMedicacion,
                                    dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_VECES_DIA],
                                    dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_OBSERVACIONS],
                                    dsDiarioDoses.Tables[0].Rows[i][clsDiarioDoses.INDEX_DATA_HORA]);
                // Engadimos todas as filas ao DataGridView. Recordemos que o Id e o IdMedicación non están visibles..
            }
            dgvDiario.CurrentCell = null;
        }

        private void bts_CRUD_Enabler() // Habilita o botón se se cumpren as condicións.
        {
            btGardar.Enabled = (dtpData.Value != null && cbxMedicacion.SelectedIndex != -1 && nudDoses.Value != 0);
            btEditar.Enabled = btEliminar.Enabled = dgvDiario.CurrentRow != null;
            // Desta forma, sabemos que se están a introducir datos válidos, xa que de non ser así o botón estaría inhabilitado.
        }

        private void limparCampos() // Deixamos os campos no seu valor por defecto.
        {
            dtpData.Value = DateTime.Now;
            cbxMedicacion.SelectedIndex = 0;
            nudDoses.Value = 0;
            txbObservacions.Clear();
            dgvDiario.CurrentCell = null;
        }

        private void abrirFormEditar() // Comproba se é posible abrir o formulario fEditar.
        {
            if (dgvDiario.CurrentRow != null) // Se hai unha fila seleccionada...
            {
                fEditar fEditar = new fEditar(oBD, oMedicacion, dsMedicacion, dsDiarioDoses, oDiario, dgvDiario.CurrentRow.Index); // ... instanciamos o formulario fEditar.
                this.Hide(); // Ocultamos o formulario inicial.
                fEditar.ShowDialog(); // Mostramos o formulario para editar.

                this.Show(); // Unha vez se cerre o fEditar, mostramos o fIndex.
                mostrarTodoTomas(); // Actualizamos os posibles cambios sobre a BD no DataGridView.
            }
            else // Se non hai unha fila seleccionada... 
            {
                // ... mostramos unha mensaxe de erro explicativa.
                MessageBox.Show("Debe seleccionar unha fila da táboa para poder editala.", "ERRO. Seleccione unha fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarMedicacion()
        {
            dsMedicacion = oMedicacion.obterTodaMedicacion(oBD); // Lemos a medicación da que dispomos na BD, e gardámos a información nun DataSet.
            clsFuncionsComuns.encherCbxMedicacion(ref cbxMedicacion, ref dsMedicacion); // Enchemos o ComboBox pasando as referencias do combo e do DataSet.
        }

        private void eliminarToma() // Para eliminar a toma.
        {
            try
            {
                if (dgvDiario.CurrentRow != null) // Se hai unha fila seleccionada...
                {
                    // Pedimos confirmación para asegurarnos de que o usuario quere eliminar un rexistro.
                    DialogResult result = MessageBox.Show("Está seguro de que deseña eliminar a toma seleccionada?", "Eliminación de Rexistro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) // Se confirma...
                    {
                        // ... Gardamos o Id na clase clsDiarioDoses e procedemos coa eliminación.
                        oDiario.Id = Convert.ToInt32(dsDiarioDoses.Tables[0].Rows[dgvDiario.CurrentRow.Index][clsDiarioDoses.INDEX_ID]);
                        oDiario.eliminarToma(oBD);
                        // Se todo foi correcto, actualizamos os cambios sobre a BD no DataGridView, e mostramos unha mensaxe de satisfacción.
                        mostrarTodoTomas();
                        MessageBox.Show("A toma seleccionada foi eliminada con éxito. Operación realizada correctamente.",
                            "Eliminación de Rexistro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Se o usuario rexeita o borrado...
                    {
                        // ... mostramos a indicación de que nada foi borrado da BD.
                        MessageBox.Show("Ningunha toma foi eliminada. Operación cancelada a tempo.", "Eliminación de Rexistro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // Se non hai unha fila seleccionada...
                {
                    // ... mostramos unha mensaxe de erro explicativa.
                    MessageBox.Show("Debe seleccionar unha fila da táboa para poder editala.", "ERRO. Seleccione unha fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception ex) // Se ocorreu algún erro...
            {
                // Rexistramos o erro por consola e mostrámoslle unha mensaxe ao usuario.
                Console.Write("--- Excepción en clase '" + this.Name + "'. MENSAXE: " + ex.Message);
                MessageBox.Show("Houbo un erro inesperado mentes se intentaba borrar o rexistro da Base de Datos. Inténteo de novo, e póñase en contacto co servizo " +
                                "de mantemento se o erro persiste", "ERRO borrando rexistro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bts_CRUD_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Name.Contains("Gardar")) // Se o botón premido foi btGardar...
            {
                comprobarDatosCorrectos(); // ... pedímoslle confirmación ao usuario, por se tivo unha equivocación.
            }
            else if (((Button)sender).Name.Contains("Editar")) // Se o botón premido foi btEditar...
            {
                abrirFormEditar(); // ... abrimos o formulario fEditar, previa comprobación.
            }
            else if (((Button)sender).Name.Contains("Eliminar")) // Se o botón premido foi btEliminar...
            {
                // ... eliminamos a toma seleccionada, previa comprobación.
                eliminarToma();
            }
            bts_CRUD_Enabler(); // Comprobamos a dispoñibilidade dos botóns.
        }

        private void btEditarMedicacion_Click(object sender, EventArgs e) // Para abrir o formulario fEditarMedicacion.cs
        {
            fEditarMedicacion fEditarMedicacion = new fEditarMedicacion(oBD, oMedicacion, oDiario); // Instanciamos o formulario.
            this.Hide(); // Ocultamos o formulario actual.
            fEditarMedicacion.ShowDialog(); // Mostramos o novo formulario en forma de diálogo.
            this.Show(); // Unha vez cerrado o novo, mostramos o anterior formulario.

            listarMedicacion(); // Recargamos o ComboBox coa nova medicación (se fose o caso).
            mostrarTodoTomas(); // Facemos o mesmo para as tomas.
        }

        private void cbxMedicacion_SelectedIndexChanged(object sender, EventArgs e) // Evento controlado para mostrar un resume sobre a medicación escollida no ComboBox.
        {
            lbxInfoResumida.Items.Clear(); // Limpamos o ListBox para 'substituir' o texto a mostrar polo antigo.
            lbxInfoResumida.Items.Add((dsMedicacion.Tables[0].Rows[cbxMedicacion.SelectedIndex][clsMedicacion.INDEX_INFO_RESUMIDA]).ToString()); 
            //Mostramos o novo texto, que chega dende a BD.

            bts_CRUD_Enabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

        private void nudDoses_ValueChanged(object sender, EventArgs e)
        {
            bts_CRUD_Enabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

        private void FormClosing_Event(object sender, FormClosingEventArgs e) // Aprobeitamos este evento para cerrar a BD.
        {
            oBD.cerrarBd(); // Cerramos a BD.
        }

        private void dgvResumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bts_CRUD_Enabler(); // Verificamos se se cumpren os requisitos para habilitar o boton btGardar.
        }

        private void dgvDiario_Sorted(object sender, EventArgs e) // Para controlar que o dsDiarioDoses se ordene acorde á ordenación do DataGridView.
        {
            dsDiarioDoses.Clear(); // Limpamos o DataSet
            for (int i = 0; i < dgvDiario.Rows.Count; i++) // Percorremos as filas do DataGridView
            {
                oDiario.Id = Convert.ToInt32(dgvDiario.Rows[i].Cells[0].Value); // Introducimos os valore do DGV nas propiedades da clase clsDiarioDoses, a excepción no nome da medicación.
                oDiario.IdMedicacion = Convert.ToInt32(dgvDiario.Rows[i].Cells[1].Value);
                // A posición 2 é o nome da medicación, por tanto non a collemos.
                oDiario.VecesDia = Convert.ToInt32(dgvDiario.Rows[i].Cells[3].Value);
                oDiario.Observacions = Convert.ToString(dgvDiario.Rows[i].Cells[4].Value);
                oDiario.DataHora = Convert.ToDateTime(dgvDiario.Rows[i].Cells[5].Value);

                // Enchemos o DS con estos valores.
                dsDiarioDoses.Tables[0].Rows.Add(oDiario.Id, oDiario.IdMedicacion, oDiario.VecesDia, oDiario.Observacions, oDiario.DataHora);
            }

            // Chegados a este punto, o dsDiario está ordenado tal e como o está o dgvDiario.
        }
    }
}
