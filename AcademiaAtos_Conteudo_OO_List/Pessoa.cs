using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_Conteudo_OO_List
{
    internal class Pessoa
    {
        private string _nome;
        private Endereco _endereco;
        private string _email;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Endereco Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
