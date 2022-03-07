using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Encadeada
{
    internal class Livro
    {
        public int ISBN { get; set; }
        public String Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Anterior { get; set; }

        public Livro(int iSBN, string titulo, int anoPublicacao)
        {
            ISBN = iSBN;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Anterior = null;
        }

        public override string ToString()
        {
            return "=========DADOS DO LIVRO=========\n"+"ISBN:\t\t"+ISBN+"\nTitulo:\t\t"+Titulo+"\nPublicacao:\t"+AnoPublicacao; 
        }
    }
}
