using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using System;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class CadastroService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public CadastroService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            var senha = Console.ReadLine();

            var usuario = new Usuario(nome, senha);

            _usuarioRepositorio.Add(usuario);

            Console.WriteLine("Usuário salvo com sucesso!");
        }
    }
}
