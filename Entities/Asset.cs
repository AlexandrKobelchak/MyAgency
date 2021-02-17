using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Asset:IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        [Column("fileName")]
        [MaxLength(260)]
        public string FileName { get; set; }

        [Column("original")]
        [MaxLength(260)]
        public string OriginalFileName { get; set; }

        [Column("mime")]
        [MaxLength(64)]
        public string MimeType { get; set; }
        
        [Column("ext")]
        [MaxLength(32)]
        public string FileExtention { get; set; }
    }
}
