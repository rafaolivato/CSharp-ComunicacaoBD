using System;

namespace AT02_RafaelOlivato_UC04.Models
{
    public class Usuario
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Login {get;set;}
        public string Senha {get;set;}
        public DateTime DataNascimento {get;set;}
    }
}