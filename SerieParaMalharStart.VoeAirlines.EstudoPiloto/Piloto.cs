using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlines.EstudoPiloto
{
    //Classe:conjunto de objetos
    /*
     * Propriedades
     * 
     */
    internal class Piloto
    {
        //Propriedade automática
        //Encapsulamento
        //set     get
        //Propriedade é privada
        //get e set é público
        //Encapsulamento
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Piloto()
        {

        }

        //void - retorno vazio (procedimento - lógica de programação)
        /*
         * lógica de programação
         *   void - procedimento (retorno vazio)
         *   return - função (retorna)
         *   
         *   
         *   bloco de programação
         *   
         *   procedimento somar(inteiro x, inteiro y)
         *   inicio
         *       
         *       escrevaNoBlocoDeNotas(x+y)
         *   
         *   fim
         *   
         *   
         */ 
        public String GerarNomeCompletoMaiusculo()
        {
            return $"{Nome}{Sobrenome}".ToUpper();
        }
        public String GerarNomeCompletoMinusculo()
        {
            return $"{Nome}{Sobrenome}".ToLower();
        }
        /*
         * Lógica de Programação
         * Orientação a Objetos (turva-Flavio)
         * Código estruturado
         * A+B= C
         *                            PONTE
         * Caminho Estruturado ===================== Caminho Orientado a Objetos
         *                            PONTE
         * Serie para Malhar   ===================== ?
         * if
         * for
         * while
         * do while
         * estrutura de dados
         * funções/procedimentos 
         * 
         * 28 ao 33
         * ============================
         * Classe:
         * Propriedades/Atributos:Características
         * Métodos: Funcionalidades do Objeto
         * 
         * Set - propriedades
         * Get -propriedades
         * 
         *Funcionalidade = Funções e Procedimentos - Lógica.
         *
         * void VerificarAPI(){
         * 
         * }
         * 
         * modificador tipo-de-retorno nomeMetodo( ){
         *     
         * 
         * }
         * 
         *ValueTypes =    x=10
         *ReferenceType 
         *public void Decolar(Aeronave aero){
         *
         *}
         * 
         * 
         * 
         */





    }
}
