using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Domain.Entities;

public class Servico : Entity
{
    public Guid TenantId { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public int DuracaoEmMinutos { get; private set; }

    public Servico(Guid tenantId, string nome, decimal preco, int duracaoEmMinutos) : base()
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);

        if (tenantId == Guid.Empty)
        {
            throw new ArgumentException("Empresa não pode ficar vazia", nameof(tenantId));
        }

        if (preco <= 0)
        {
            throw new ArgumentException("Preço deve ser maior que 0", nameof(preco));
        }

        if (duracaoEmMinutos <= 0)
        {
            throw new ArgumentException("Duração do serviço deve ser maior que 0", nameof(duracaoEmMinutos));
        }

        TenantId = tenantId;
        Nome = nome.Trim();
        Preco = preco;
        DuracaoEmMinutos = duracaoEmMinutos;
    }
    private Servico() { }
}