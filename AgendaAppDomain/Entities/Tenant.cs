using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Domain.Entities;

public class Tenant
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public bool Ativo { get; private set; }

    public Tenant(string nome)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);

        Id = Guid.NewGuid();
        Nome = nome.Trim();
        DataCriacao = DateTime.UtcNow;
        Ativo = true;
    }
    private Tenant()
    { }

    public void Desativar()
    {
        Ativo = false;
    }
}