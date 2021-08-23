using HandsOfWork.Entities.Abstractions;
using System;

namespace HandsOfWork.Entities
{
    public class CategoriaDoProduto : BaseEntity<Guid>
    {
        public string Descricao { get; set; }
    }
}