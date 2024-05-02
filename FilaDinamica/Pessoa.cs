using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class Pessoa
    {
        string nome; // |?| - Modificador de tipo, indica que talvez, o atributo seja nulo em algum momento.
        Pessoa? proximo; //Recebe a próxima pessoa da fila referente aquele objeto, por isso é do tipo "Pessoa". pessoa1.proximo = pessoa2 | pessoa2.proximo = pessoa3

        public Pessoa(string nome)
        {
            this.nome = nome;
            proximo = null;
        }

       

        public void setNext(Pessoa aux) //Recebe uma pessoa no parâmetro
        {
            this.proximo = aux; // O próximo do tail da fila recebe a pessoa que estava no aux.
        }

        public Pessoa? getNext()
        {
            return this.proximo;
        }

        public override string? ToString()
        {
            return "\n\nNome da Pessoa: " + nome;
        }


    }
}
