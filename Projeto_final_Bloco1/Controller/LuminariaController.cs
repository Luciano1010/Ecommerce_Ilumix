using Projeto_final_Bloco1.Model;
using Projeto_final_Bloco1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projeto_final_Bloco1.Controller
{
    public class LuminariaController : ILuminariarepository
    {

        private readonly List<Luminarias> listaluminarias = new();

        int id = 0;

        public void Atualizar(Luminarias id)
        {
            var procuraluminarias = BuscarNaCollection(id.Getid());

            if (procuraluminarias is not null)
            {
                var index = listaluminarias.IndexOf(procuraluminarias);
                listaluminarias[index] = id;
            }
            else
            {
                Console.WriteLine($"A conta numero {id} não foi encontrado");
                Console.ResetColor();
            }

        }

        public void CriarProduto(Luminarias nome)
        {
            listaluminarias.Add(nome);
            Console.WriteLine($" A luminaria {nome.Getid()} foi criado com sucesso! ");

        }

        public void ListarLuminarias()
        {
            foreach (var luminarias in listaluminarias)
            {
                luminarias.Visualizar();
            }

        }
        public void Deletar(int id)
        {
            var procurar = BuscarNaCollection(id);

            if (procurar is not null)
            {
                if (listaluminarias.Remove(procurar) == true)
                    Console.WriteLine($"A Luminaria {id} foi apagada com Sucesso");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {id} não foi encontrado");
                Console.ResetColor();
            }
        }

        public void ProcurarId(int id)
        {
            var luminarias = BuscarNaCollection(id);

            if (luminarias is not null)
                luminarias.Visualizar();
            else
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Luminaria {id} não foi encontrado:");
                Console.ResetColor();
            }
        }

        public int GerarNumero()
        {
            return ++id;

        }


        public Luminarias? BuscarNaCollection(int id)
        {
            foreach (var luminarias in listaluminarias)
            {
                if (luminarias.Getid() == id)
                    return luminarias;

            }
            return null;
        }



    }
}