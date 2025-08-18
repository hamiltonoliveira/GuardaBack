using System;
using System.Collections.Generic;

namespace Domain
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public bool Ativo { get; set; } = true;
        public ICollection<Arquivo> Arquivos { get; set; } = new List<Arquivo>();
    }

}