using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_wf.Classes
{

    internal class Locacao
    {
        int IdLocacao { get; set; }
        DateTime DtLocacao { get; set; }
        DateTime DtDevolucao { get; set; }
        double ValorLocacao { get; set; }
        static List<Locacao> LocacaoList { get; set; }
        string Modelo { get; set; }

        public Locacao(int idLocacao, DateTime dtLocacao, DateTime dtDevolucao, double valorLocacao)
        {
            IdLocacao = idLocacao;
            DtLocacao = dtLocacao;
            DtDevolucao = dtDevolucao;
            ValorLocacao = valorLocacao;
        }

        public static double CalcularValor(int dtLocacao, int dtDevolucao, double valor)
        {
            int dias = dtDevolucao - dtLocacao;
            return valor * dias;
        }
    }
}
