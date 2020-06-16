using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Models
{
    class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public DateTime Nascimento { get; set; }
        public int Numero { get; set; }
        public string usuario { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string ID { get; set; }
    }
}
