using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Domain.Entities;

public class Tenant : Entity
{
    public string Nome { get; private set; }

    public Tenant(string nome) : base()
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(nome);
        Nome = nome.Trim();
    }
    private Tenant()  { }
}