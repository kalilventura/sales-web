using System;

namespace SalesWeb.Domain.Entities
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(BaseEntity other) => Id == other.Id;
    }
}
