using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Domain.Entities;

public class Profissional : Entity
{
    public Guid TenantId { get; private set; }
    public string Nome { get; private set; }

    public Profissional(Guid tenantId, string nome) : base()
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);

        if (tenantId == Guid.Empty)
        {
            throw new ArgumentException("A empresa não pode estar vazia", nameof(tenantId));
        }

        TenantId = tenantId;  
        Nome = nome.Trim();
    }

    private Profissional() { }
}