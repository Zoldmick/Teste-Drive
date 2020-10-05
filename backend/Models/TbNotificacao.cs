using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_notificacao")]
    public partial class TbNotificacao
    {
        [Key]
        [Column("id_notificacao", TypeName = "int(11)")]
        public int IdNotificacao { get; set; }
        [Column("id_login", TypeName = "int(11)")]
        public int IdLogin { get; set; }
        [Required]
        [Column("ds_mensagem", TypeName = "varchar(255)")]
        public string DsMensagem { get; set; }
        [Column("dt_envio", TypeName = "datetime")]
        public DateTime DtEnvio { get; set; }
        [Required]
        [Column("ds_status", TypeName = "varchar(255)")]
        public string DsStatus { get; set; }

        [ForeignKey(nameof(IdLogin))]
        [InverseProperty(nameof(TbLogin.TbNotificacao))]
        public virtual TbLogin IdLoginNavigation { get; set; }
    }
}
