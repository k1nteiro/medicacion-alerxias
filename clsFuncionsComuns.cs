using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MedicacionAlerxias
{
    public class clsFuncionsComuns
    {
        /*
         * 
         * O OBXETO DESTA CLASE É MANEXAR CERTOS COMPOÑENTES NUN OU NOUTRO FORMULARIO, CUXO CÓDIGO É EXACTAMENTE O MESMO OU PARECIDO, SEN TER QUE REPETILO.
         * POR PARÁMETROS NOS MÉTODOS PASARANSE REFERENCIAS AOS OBXETOS NECESITADOS, PARA APLICAR DIRECTAMENTE DENDE AQUÍ OS CAMBIOS. SE NON FOSEN REFERENCIAS,
         * OS CAMBIOS FEITOS AQUÍ NON SE VERÍAN REFREXADOS NOS COMPOÑENTES ORIXINAIS.
         * 
         */


        public static void encherCbxMedicacion(ref ComboBox cbxMedicacion, ref DataSet dsMedicacion) // ENCHE OS ComboBox DOS NOMES DA MEDICACIÓN (ver referencias ás chamadas).
        {
            cbxMedicacion.Items.Clear();
            for (int i = 0; i < dsMedicacion.Tables[0].Rows.Count; i++)
            {
                cbxMedicacion.Items.Add(dsMedicacion.Tables[0].Rows[i][clsMedicacion.INDEX_NOME]); // Percorremos o DataSet e engadimos o nome de cada medicación ao ComboBox.
            }
        }

        

    }
}
