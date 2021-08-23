using HandsOfWork.Entities.Abstractions;
using System;

namespace HandsOfWork.Repositories.CategoriaDoProdutos.Models
{
    public class CategoriaDoProdutoModel : BaseEntity<Guid>
    {
        public string Descricao { get; set; }
    }
}