using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final_Bloco1.Model
{
    public class Luminarias
    {
        private int id;
        private string tamanho = string.Empty;
        private string formato = string.Empty;
        private string Cores = string.Empty;
       
        private int preco ;
        private string nome;
        public Luminarias(string tamanho, string formato, string cores, int preco, int id, string nome)
        {
            this.tamanho = tamanho;
            this.formato = formato;
            this.Cores = cores;
           
            this.preco = preco;
            this.id = id;
            this.nome = nome;
        }

        public string Gettamanho() 
        {
            return tamanho;
        
        }
    
        public void Settamanho(string tamanho) 
        {
            this.tamanho = tamanho;
        
        }

        public string Getformato() 
        {
            return formato;
                
        }

        public void Setformato(string formato) 
        {
            this.formato = formato;
        
        }

        public string GetCores() 
        {
            return Cores;
        
        }

        public void SetCores(string cores) 
        {

            this.Cores = cores;
        }
        
       
        public int Getpreco() 
        {
            return preco;
            
        }

        public int Getid() 
        {
        
            return id;  
        }

        public string Getnome() 
        {
            return nome;
        
        }

        public void Setnome(string nome) 
        {
            this.nome = nome;
        
        }

        public virtual void Visualizar() 
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("                   Resumo                      ");
            Console.WriteLine("O tamanho da luminaria escolhida: " + this.tamanho);
            Console.WriteLine("O Formato escolhido: " + this.formato);
            Console.WriteLine("Cor: " + this.Cores);
            
            Console.WriteLine("O nome da Luminaria: " + this.nome);
            Console.WriteLine("O Modelo escolhido: " + this.id);
            Console.WriteLine("O valor da Luminaria escolhida:R$ " + this.preco);
            Console.WriteLine("************************************************");


        }
            
    }
            
}
        

