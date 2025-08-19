using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain
{
    public class Arquivo
    {
        protected Arquivo() { } // Necessário para EF Core

        public Arquivo(string nomeOriginal, ExtensaoArquivo extensao, long tamanhoBytes, Guid usuarioId, string tipoDocumento)
        {
            Id = Guid.NewGuid();
            NomeOriginal = nomeOriginal ?? throw new ArgumentNullException(nameof(nomeOriginal));
            Extensao = extensao;
            TamanhoBytes = tamanhoBytes;
            UsuarioId = usuarioId;
            TipoDocumento = tipoDocumento ?? throw new ArgumentNullException(nameof(tipoDocumento));
            DataUpload = DateTimeOffset.UtcNow;
        }

        public Guid Id { get; private set; }
        public string NomeOriginal { get; private set; }
        public ExtensaoArquivo Extensao { get; private set; }
        public long TamanhoBytes { get; private set; }
        public DateTimeOffset DataUpload { get; private set; }

        public Guid UsuarioId { get; private set; }
        public Usuario Usuario { get; private set; }

        public string TipoDocumento { get; private set; }
        public string ChaveAcesso { get; set; }
        public string CnpjEmitente { get; set; }
        public string CnpjDestinatario { get; set; }
        public DateTimeOffset? DataEmissao { get; private set; } = DateTime.UtcNow;

        public ICollection<LogProcessamento> Logs { get; private set; } = new List<LogProcessamento>();

        public string CaminhoArmazenado
        {
            get
            {
                string ano = DataUpload.Year.ToString();
                string mes = DataUpload.Month.ToString("D2");
                string extensao = Extensao.ToString().ToLower();
                string nomeArquivo = $"{NomeOriginal}.{extensao}";

                return $"{TipoDocumento}/{ano}/{mes}/{nomeArquivo}";
            }
        }
    }
}
