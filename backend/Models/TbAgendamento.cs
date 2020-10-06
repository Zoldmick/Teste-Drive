using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_agendamento")]
    public partial class TbAgendamento
    {
        [Key]
        [Column("id_agendamento")]
        public int IdAgendamento { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_veiculo")]
        public int IdVeiculo { get; set; }
        [Column("dt_agendamento", TypeName = "datetime")]
        public DateTime DtAgendamento { get; set; }
        [Required]
        [Column("ds_rota_inicial", TypeName = "varchar(255)")]
        public string DsRotaInicial { get; set; }
        [Required]
        [Column("ds_rota_final", TypeName = "varchar(255)")]
        public string DsRotaFinal { get; set; }
        [Required]
        [Column("ds_status", TypeName = "varchar(255)")]
        public string DsStatus { get; set; }
        [Column("dt_final", TypeName = "datetime")]
        public DateTime DtFinal { get; set; }
        [Column("nr_avaliacao")]
        public int? NrAvaliacao { get; set; }
        [Column("ds_feedback", TypeName = "varchar(255)")]
        public string DsFeedback { get; set; }
        [Column("ds_acompanhante", TypeName = "varchar(255)")]
        public string DsAcompanhante { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbAgendamento))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdVeiculo))]
        [InverseProperty(nameof(TbVeiculo.TbAgendamento))]
        public virtual TbVeiculo IdVeiculoNavigation { get; set; }
    }
}
