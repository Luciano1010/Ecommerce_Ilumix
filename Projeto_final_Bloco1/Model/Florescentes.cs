using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final_Bloco1.Model
{
    public class Florescentes : Luminarias
    {
        private string florescente = string.Empty;

        public Florescentes(string tamanho, string formato, string cores, string fontedeluz, int preco, string florescente, int id) : base(tamanho, formato, cores, fontedeluz, preco,id)
        {
            this.florescente = florescente;
        
        }
        public string Getflorescentes() 
        {
            return florescente;
        
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("A fonte de Luz é " + this.florescente);
        }

    }
}
