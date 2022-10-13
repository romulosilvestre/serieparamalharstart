using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlinesSobrecarga
{
    
    public class Agenda
    {
        //Dados
        //variável é privada
        private string _descricao;
        private int _qtdePassageiro;


        //verbo no infinito
        //Método = ação - vai fazer algo.
        //acesso é público
        //acesso privado , acesso público, acesso protegido
        //O que é assinatura?
        public bool RegistrarVoo(string descricao)//assinatura
        {//corpo
            bool r;
            _descricao = descricao;
            if (_descricao != null)
            {
                r = true;
            }
            else
            {
                r = false;
            }
                return r;
        }//corpo
        public string RegistrarVoo(int qtdePassageiro)//assinatura
        {//corpo
            _qtdePassageiro = qtdePassageiro;
            return "quantidade registrada com sucesso";
        }//corpo
        public DateTime RegistrarVoo()
        {
            return DateTime.Today;
        }
    }
}
