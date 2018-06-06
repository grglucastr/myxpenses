using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyXpenses
{
    public class Despesa
    {
        public String Descricao { get; set; }
        public String Valor { get; set; }
        public String DataPago { get; set; }

        public Despesa(String Descricao, String Valor, String DataPago)
        {
            this.DataPago = DataPago;
            this.Descricao = Descricao;
            this.Valor = Valor;
        }
    }
}
