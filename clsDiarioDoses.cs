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


        public const int INDEX_ID = 0;
        public const int INDEX_ID_MEDICACION = 1;
        public const int INDEX_VECES_DIA = 2;
        public const int INDEX_OBSERVACIONS = 3;
        public const int INDEX_DATA_HORA = 4;

        public DataSet obterTodoDiario(clsBd oBD)
        {
            // Id, IdMedicacion, Observacions, DataHora
            string sql = "SELECT * FROM DiarioDoses;";

            return oBD.operacionsSelect(sql);
        }


        public void inserirToma(clsBd oBD)
        {
            string sql = string.Format("INSERT INTO DiarioDoses (IdMedicacion, VecesDia, Observacions, DataHora) VALUES ({0},{1},'{2}',Mid('{3}',1,10));",
                                        this._idMedicacion, this._vecesDia, this._observacions, this._dataHora);
            oBD.operacionsNonSelect(sql);
        }


        public DataSet lerTodoTomas(clsBd oBD)
        {
            string sql = string.Format("SELECT * FROM DiarioDoses");
            return oBD.operacionsSelect(sql);
        }

        public void actualizarToma(clsBd oBD)
        {

            string sql = string.Format("UPDATE DiarioDoses SET IdMedicacion = {0}, VecesDia = {1}, Observacions = '{2}', DataHora = '{3}' WHERE Id = {4}",
                                        this._idMedicacion, this._vecesDia, this._observacions, this._dataHora, this._id);

            oBD.operacionsNonSelect(sql);

        }

        public void eliminarToma(clsBd oBD)
        {
            string sql = string.Format("DELETE FROM DiarioDoses WHERE Id = {0}", this._id);
            oBD.operacionsNonSelect(sql);
        }

    }
}
