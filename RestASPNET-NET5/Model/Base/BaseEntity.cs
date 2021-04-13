using System.ComponentModel.DataAnnotations.Schema;

namespace RestASPNET_NET5.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
