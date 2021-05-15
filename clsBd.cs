using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MedicacionAlerxias
{
    public class clsBd
    {
        OleDbConnection conexion;
        public clsBd(string nomeBD)
        {
            string cadenaConexion = string.Format("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = '{0}'",nomeBD);
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void abrirBd()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    MessageBox.Show("BD Aberta", "Estado BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OleDbException erroBd)
            {
                MessageBox.Show("Erro Abrindo BD: " + erroBd.Message, "Erro de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        public void cerrarBd()
        {
            try
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    MessageBox.Show("BD Cerrada", "Estado BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (OleDbException erroBd)
            {
                MessageBox.Show("Erro Cerrando BD: " + erroBd.Message, "Erro de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void operacionsNonSelect(string operacion)
        {
            try
            {
                OleDbCommand command = new OleDbCommand(operacion, conexion);
                command.ExecuteNonQuery();
            }
            catch (OleDbException erroBd)
            {
                MessageBox.Show("Erro Intentando Operación NON Select: " + erroBd.Message, "Erro de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet operacionsSelect(string operacion)
        {
            DataSet ds = new DataSet();

            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(operacion, conexion);
                adapter.Fill(ds);
            }
            catch (OleDbException erroBd)
            {
                MessageBox.Show("Erro Intentando Operación Select: " + erroBd.Message, "Erro de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds;
        }

    }
}
