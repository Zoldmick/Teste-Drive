using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbAgendamento = new HashSet<TbAgendamento>();
        }

        [Key]
        [Column("id_cliente", TypeName = "int(11)")]
        public int IdCliente { get; set; }
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }
        [Required]
        [Column("nm_cliente", TypeName = "varchar(100)")]
        public string NmCliente { get; set; }
        [Column("dt_nascimeto", TypeName = "date")]
        public DateTime? DtNascimeto { get; set; }
        [Column("ds_imagem", TypeName = "varchar(255)")]
        public string DsImagem { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(255)")]
        public string DsEndereco { get; set; }
        [Column("nr_residencia", TypeName = "int(11)")]
        public int NrResidencia { get; set; }
        [Column("bt_deficiente")]
        public bool BtDeficiente { get; set; }
        [Column("nr_telefone", TypeName = "varchar(11)")]
        public string NrTelefone { get; set; }
        [Column("nr_celular", TypeName = "varchar(11)")]
        public string NrCelular { get; set; }
        [Column("nr_cnh", TypeName = "varchar(11)")]
        public string NrCnh { get; set; }
        [Column("nr_cpf", TypeName = "varchar(11)")]
        public string NrCpf { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbCliente))]
        public virtual TbLogin IdLoginNavigation { get; set; }
        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbAgendamento> TbAgendamento { get; set; }
    }
}
