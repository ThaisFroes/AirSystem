using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;


        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    Codigo = 1,
                    Nome = "Thais",
                    Sobrenome = "S. S. Froes",
                    Endereco = "Rua bla bla bla",
                    Nascimento = Convert.ToDateTime("01/01/2000"),
                    Numero = 100,
                    usuario = "ThaisF",
                    Senha = "12345abc",
                    ConfirmarSenha = "1234abc",
                    ID = "adm"
                });
                contador++;

                usuarios.Add(new Usuario
                {
                    Codigo = 2,
                    Nome = "Livia",
                    Sobrenome = "Sibinelli",
                    Endereco = "Av. BlaBla",
                    Nascimento = Convert.ToDateTime("03/11/1999"),
                    Numero = 558,
                    usuario = "livia",
                    Senha = "1234",
                    ConfirmarSenha = "1234",
                    ID = "comum"
                });
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.Codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.Codigo == usuario.Codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int Codigo)
        {
            Usuario usuario = usuarios.Find(x => x.Codigo == Codigo);

            usuarios.Remove(usuario);

        }
    }
}
