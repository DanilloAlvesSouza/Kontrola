﻿using KontrolaPoc.Models;

namespace KontrolaPoc.Repositories.Interfaces
{
    public interface IEnderecoRepository
    {
        IEnumerable<Endereco> Enderecos {  get; }
    }
}
