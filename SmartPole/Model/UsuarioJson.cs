using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPole.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Metadata
    {
    }

    public class Email
    {
        public string type;
        public string value;
        public Metadata metadata;
    }

    public class Metadata2
    {
    }

    public class Login
    {
        public string type;
        public string value;
        public Metadata2 metadata;
    }

    public class Metadata3
    {
    }

    public class Nome
    {
        public string type;
        public string value;
        public Metadata3 metadata;
    }

    public class Metadata4
    {
    }

    public class Senha
    {
        public string type;
        public string value;
        public Metadata4 metadata;
    }

    public class UsuarioJson
    {
        public string id;
        public string type;
        public Email email;
        public Login login;
        public Nome nome;
        public Senha senha;
    }
}
