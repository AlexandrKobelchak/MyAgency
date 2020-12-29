using Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    /// <summary>
    /// Юридическое лицо
    /// </summary>
    /// 
    public class LegalPerson : IDbEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        public TouristProfile Profile { get; set; }


        /// <summary>
        /// Название плательщика
        /// </summary>
        [Column("name")]  
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Код ЕДРПОУ
        /// </summary>
        [Column("edrpou")]
        [MaxLength(64)]
        [Required]
        public string EDRPOU { get; set; }

        /// <summary>
        /// Имя руководителя
        /// </summary>
        [Column("bossName")]
        [MaxLength(128)]
        [Required]
        public string BossName { get; set; }

        /// <summary>
        /// Должность руководителя
        /// </summary>
        [Column("bossFunction")]
        [MaxLength(128)]
        [Required]
        public string BossFunction { get; set; }

        /// <summary>
        /// Расчетный счет
        /// </summary>
        [Column("paymentAccount")]
        [MaxLength(64)]
        [Required]
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Банк
        /// </summary>      
        public Bank Bank { get; set; }

        [Column("bankId")] 
        [Required]
        public Guid BankId { get; set; }
    }
}
