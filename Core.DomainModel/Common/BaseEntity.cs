using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.DomainModel.Common
{
    public interface IEntity
    {
    }

    public abstract class BaseEntity<TKey> : IEntity
    {
        protected BaseEntity()
        {
            InsertDateTime = DateTime.Now;
        }
        [Key]
        [ScaffoldColumn(false)]
        public TKey Id { get; set; }
        public DateTime InsertDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteDateTime { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
