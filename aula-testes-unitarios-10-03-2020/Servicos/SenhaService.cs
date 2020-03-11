using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class SenhaService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public SenhaService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Digite o usuário");
            var usuario = Console.ReadLine();

            var encontrado = _usuarioRepositorio.GetAll().FirstOrDefault(u => u.Nome.Equals(usuario));

            if (encontrado != null)
            {
                Console.WriteLine("Digite a nova senha:");
                var senha = Console.ReadLine();

                Console.WriteLine("Digite novamente a senha para confirmar:");
                var contrasenha = Console.ReadLine();

                if (senha == contrasenha)
                {
                    encontrado.SetSenha(senha);

                    _usuarioRepositorio.Update(encontrado);

                    Console.WriteLine("Senha alterada com sucesso!");
                }

            }
        }
    }
}
