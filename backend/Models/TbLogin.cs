using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("tb_login")]
    public partial class TbLogin
    {
        public TbLogin()
        {
            TbCliente = new HashSet<TbCliente>();
            TbNotificacao = new HashSet<TbNotificacao>();
        }

        [Key]
        [Column("id_login")]
        public int IdLogin { get; set; }
        [Column("nr_nivel")]
        public int NrNivel { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(255)")]
        public string DsSenha { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(255)")]
        public string DsEmail { get; set; }
        [Column("nr_codigo_alteracao")]
        public int? NrCodigoAlteracao { get; set; }

        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbCliente> TbCliente { get; set; }
        [InverseProperty("IdLoginNavigation")]
        public virtual ICollection<TbNotificacao> TbNotificacao { get; set; }
    }
}
