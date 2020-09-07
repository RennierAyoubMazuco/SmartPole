using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPole.Model
{
    public class UsuarioModel
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
