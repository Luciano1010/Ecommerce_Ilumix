using Projeto_final_Bloco1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_final_Bloco1.Repository
{
    public interface ILuminariarepository
    {
        public void ProcurarId(int id);
        public void Deletar(int id);

        public void Atualizar(Luminarias nome);

        public void CriarProduto(Luminarias nome);

        public void ListarLuminarias();

    }
}
