using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Arquivo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NomeOriginal { get; set; }
        public string CaminhoArmazenado { get; set; }
        public ExtensaoArquivo Extensao { get; set; }
        public long TamanhoBytes { get; set; }
        public DateTimeOffset? DataUpload { get; set; } = DateTime.UtcNow;
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string TipoDocumento { get; set; }
        public string ChaveAcesso { get; set; }
        public string CnpjEmitente { get; set; }
        public string CnpjDestinatario { get; set; }
        public DateTimeOffset? DataEmissao { get; set; }
        public ICollection<LogProcessamento> Logs { get; set; } = new List<LogProcessamento>();
    }
}
