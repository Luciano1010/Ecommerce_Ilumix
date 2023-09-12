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

        public Florescentes(string tamanho, string formato, string cores,  int preco, string florescente, int id,string nome) : base(tamanho, formato, cores, preco,id, nome)
        {
            this.florescente = florescente;
        
        }
        public string Getflorescentes() 
        {
            return florescente;
        
        }

        public void Setflorescentes(string florescentes) 
        {
        
            this.florescente = florescentes;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("A fonte de Luz é " + this.florescente);
        }

    }
}
