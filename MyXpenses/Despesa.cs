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

        public Despesa() { }

        public Dictionary<int, int> DiasVencimento()
        {
            Dictionary<int, int> lstDiasVencimento = new Dictionary<int, int>();

            for (int i = 1; i <= 31; i++)
            {
                lstDiasVencimento.Add(i, i);
            }

            return lstDiasVencimento;
        }
    }
}
