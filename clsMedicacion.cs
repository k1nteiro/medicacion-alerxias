using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MedicacionAlerxias
{
    public class clsMedicacion
    {
        #region "Propiedades privadas"
        private int _id;
        private string _nome;
        private string _laboratorio;
        private string _tratamento;
        private string _infoResumida;
        #endregion

        #region "Propiedades públicas"
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Laboratorio { get => _laboratorio; set => _laboratorio = value; }
        public string Tratamento { get => _tratamento; set => _tratamento = value; }
        public string InfoResumida { get => _infoResumida; set => _infoResumida = value; }
        #endregion

        public const int INDEX_ID = 0;
        public const int INDEX_NOME = 1;
        public const int INDEX_LABORATORIO = 2;
        public const int INDEX_TRATAMENTO = 3;
        public const int INDEX_INFO_RESUMIDA = 4;

        

        public DataSet obterTodaMedicacion(clsBd oBD)
        {
            // Id, Nome, Laboratorio, Tratamento, InfoResumida
            string sql = "SELECT * FROM Medicacion";

            return oBD.operacionsSelect(sql);
        }

        public DataSet obterNomeMedicacionPorId(clsBd oBD)
        {
            string sql = string.Format("SELECT Nome FROM Medicacion WHERE Id = {0}", this._id);
            return oBD.operacionsSelect(sql);
        }

        public void gardarMedicacion(clsBd oBD)
        {
            string sql = string.Format("INSERT INTO Medicacion (Nome, Laboratorio, Tratamento, InfoResumida) VALUES ('{0}','{1}','{2}','{3}')",
                                        this._nome, this._laboratorio, this._tratamento, this._infoResumida);
            oBD.operacionsNonSelect(sql);
        }

        public void actualizarMedicacion(clsBd oBD)
        {
            string sql = string.Format("UPDATE Medicacion SET Nome = '{0}', Laboratorio = '{1}', Tratamento = '{2}', InfoResumida = '{3}' WHERE Id = {4}",
                                        this._nome, this._laboratorio, this._tratamento, this._infoResumida, this._id);
            oBD.operacionsNonSelect(sql);
        }

        public void eliminarMedicacionPorId(clsBd oBD)
        {
            string sql = string.Format("DELETE FROM Medicacion WHERE Id = {0}", this._id);
            oBD.operacionsNonSelect(sql);
        }

    }
}
