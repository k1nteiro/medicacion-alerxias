using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MedicacionAlerxias
{
    public class clsDiarioDoses
    {

        /* Clase que xestiona o CRUD da táboa DiarioDoses.
         * 
         * Columnas: Id, IdMedicacion, VecesDia, Observacions, DataHora
         * 
         */

        #region "Propiedades privadas"
        private int _id;
        private int _idMedicacion;
        private int _vecesDia;
        private string _observacions;
        private DateTime _dataHora;
        #endregion

        #region "Propiedades públicas"
        public int Id { get => _id; set => _id = value; }
        public int IdMedicacion { get => _idMedicacion; set => _idMedicacion = value; }
        public int VecesDia { get => _vecesDia; set => _vecesDia = value; }
        public string Observacions { get => _observacions; set => _observacions = value; }
        public DateTime DataHora { get => _dataHora; set => _dataHora = value; }
        #endregion

        #region "Constantes"
        public const int INDEX_ID = 0;
        public const int INDEX_ID_MEDICACION = 1;
        public const int INDEX_VECES_DIA = 2;
        public const int INDEX_OBSERVACIONS = 3;
        public const int INDEX_DATA_HORA = 4;
        #endregion

        // Lista toda a insformación da táboa.
        public DataSet lerTodoTomas(clsBd oBD)
        {
            string sql = string.Format("SELECT * FROM DiarioDoses");
            return oBD.operacionsSelect(sql);
        }

        // Insire unha fila á taboa.
        public void inserirToma(clsBd oBD)
        {
            string sql = string.Format("INSERT INTO DiarioDoses (IdMedicacion, VecesDia, Observacions, DataHora) VALUES ({0},{1},'{2}',Mid('{3}',1,10));",
                                        this._idMedicacion, this._vecesDia, this._observacions, this._dataHora);
            oBD.operacionsNonSelect(sql);
        }

        // Actualiza unha fila da táboa.
        public void actualizarToma(clsBd oBD)
        {

            string sql = string.Format("UPDATE DiarioDoses SET IdMedicacion = {0}, VecesDia = {1}, Observacions = '{2}', DataHora = '{3}' WHERE Id = {4}",
                                        this._idMedicacion, this._vecesDia, this._observacions, this._dataHora, this._id);

            oBD.operacionsNonSelect(sql);

        }

        // Elimina unha fila da táboa.
        public void eliminarToma(clsBd oBD)
        {
            string sql = string.Format("DELETE FROM DiarioDoses WHERE Id = {0}", this._id);
            oBD.operacionsNonSelect(sql);
        }

        // Elimina todas as filas que conteñan o idMedicación indicado.
        public void eliminarTomasPorIdMedicacion(clsBd oBD)
        {
            string sql = string.Format("DELETE FROM DiarioDoses WHERE IdMedicacion = {0}", this._idMedicacion);
            oBD.operacionsNonSelect(sql);
        }

    }
}
