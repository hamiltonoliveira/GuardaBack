using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Arquivo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NomeOriginal { get; set; }
        public string CaminhoArmazenado { get; set; }
        public string Extensao { get; set; }
        public long TamanhoBytes { get; set; }
        public DateTime DataUpload { get; set; } = DateTime.UtcNow;

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public string TipoDocumento { get; set; }
        public string ChaveAcesso { get; set; }
        public string CnpjEmitente { get; set; }
        public string CnpjDestinatario { get; set; }
        public DateTime? DataEmissao { get; set; }

        public ICollection<LogProcessamento> Logs { get; set; } = new List<LogProcessamento>();
    }
}
