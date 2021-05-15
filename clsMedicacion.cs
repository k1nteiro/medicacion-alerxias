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
        private string _tratamento;
        #endregion

        #region "Propiedades públicas"
        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Tratamento { get => _tratamento; set => _tratamento = value; }
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

    }
}
