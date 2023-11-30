using System;

namespace Core.Entidades
{
    public class Voto
    {
        public int Id { get; set; }

        public string OpcaoEscolhida { get; set; }

        public DateTime DataCriacao { get; set; }

        public Usuario Usuario { get; set; }

        public Voto(int id, string opcaoEscolhida, DateTime dataCriacao, Usuario usuario)
        {
            Id = id;
            OpcaoEscolhida = opcaoEscolhida;
            DataCriacao = dataCriacao;
            Usuario = usuario;
        }

        public override string ToString()
        {
            return $"Voto Id {Id}, Opção escolhida {OpcaoEscolhida}, Data de criação: {DataCriacao:dd/MM/yyyy}";
        }
    }
}
