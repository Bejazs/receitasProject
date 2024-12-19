using System;
using System.Collections.Generic;

namespace ReceitasCulinaria
{
    public class Recipie
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Tempo { get; set; }
        public string Dificuldade { get; set; }
        public string Categoria { get; set; }
        public int Pessoas { get; set; }
        public string Descricao { get; set; }
        public List<Ingridients> Ingredientes { get; set; }
    }
}
