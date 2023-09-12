using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final_Bloco1.Model
{
    public class Led : Luminarias
    {
        private string leds;
        public Led(string tamanho, string formato, string cores, string fontedeluz, int preco, string leds, int id) : base(tamanho, formato, cores, fontedeluz, preco,id)
        {
            this.leds = leds;
        }

        public string Getleds() 
        {
            return leds;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("A Fonte de luz é " + this.leds);
        }

    }
}
