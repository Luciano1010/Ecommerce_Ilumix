using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final_Bloco1.Model
{
    public class Led : Luminarias
    {
        private int leds;
        public Led(string tamanho, string formato, string cores,  int preco, int leds, int id,string nome) : base(tamanho, formato, cores, preco,id,nome)
        {
            this.leds = leds;
        }

        public int Getleds() 
        {
            return leds;
        }

        public void Setleds(int leds) 
        {
            this.leds = leds;
           
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("A Fonte de luz é " + this.leds);
        }

    }
}
