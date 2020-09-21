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
        [Column("id_agendamento", TypeName = "int(11)")]
        public int IdAgendamento { get; set; }
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("id_veiculo", TypeName = "int(11)")]
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
        [Column("hr_final", TypeName = "time")]
        public TimeSpan HrFinal { get; set; }
        [Column("nr_avaliacao", TypeName = "int(11)")]
        public int? NrAvaliacao { get; set; }
        [Column("ds_feedback", TypeName = "varchar(255)")]
        public string DsFeedback { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbAgendamento))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdVeiculo))]
        [InverseProperty(nameof(TbVeiculo.TbAgendamento))]
        public virtual TbVeiculo IdVeiculoNavigation { get; set; }
    }
}
