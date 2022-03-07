using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Encadeada
{
    internal class Pilha_Livro
    {
        public Livro Topo { get; set; }

        public Pilha_Livro()
        {
            Topo = null;
            //Console.WriteLine("Pilha de Livros criada com sucesso!");
        }

        public void push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
        }

        public void print() //não preciso de paramtros, pois já estou acessando o topo
        {
            if (vazia())
            {
                Console.WriteLine("----- PILHA VAZIA -----");
            }
            else
            {
                Console.WriteLine("----- OS ELEMENTOS DA PILHA SAO -----");
                Livro aux = Topo;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("----- FIM DA IMPRESSAO -----");

            }
        }

        public bool vazia()
        {
            if(Topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("----- PILHA VAZIA -----");
            }
            else
            {
                Topo = Topo.Anterior;
            }
        }
    }
}
