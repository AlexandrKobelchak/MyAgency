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
        public string Name { get; set; }

        /// <summary>
        /// Код ЕДРПОУ
        /// </summary>
        public string EDRPOU { get; set; }

        /// <summary>
        /// Имя руководителя
        /// </summary>
        public string BossName { get; set; }

        /// <summary>
        /// Должность руководителя
        /// </summary>
        public string BossFunction { get; set; }

        /// <summary>
        /// Расчетный счет
        /// </summary>
        public string PaymentAccount { get; set; }

        /// <summary>
        /// Банк
        /// </summary>
        public virtual Bank Bank { get; set; }

    }
}
