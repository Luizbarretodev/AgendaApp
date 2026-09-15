using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaApp.Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public DateTime DataCriacao { get; protected set; }
    public bool Ativo { get; protected set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.UtcNow;
        Ativo = true;
    }

    public void Desativar()
    {
        Ativo = false;
    }
}