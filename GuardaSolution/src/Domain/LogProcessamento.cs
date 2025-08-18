using System;

namespace Domain
{
    public class LogProcessamento
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ArquivoId { get; set; }
        public Arquivo Arquivo { get; set; }
        public DateTimeOffset? Data { get; set; } = DateTime.UtcNow;
        public string Mensagem { get; set; }
        public bool Sucesso { get; set; }
    }

}