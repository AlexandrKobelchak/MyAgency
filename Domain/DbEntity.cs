using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class DbEntity : IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
    }
}
