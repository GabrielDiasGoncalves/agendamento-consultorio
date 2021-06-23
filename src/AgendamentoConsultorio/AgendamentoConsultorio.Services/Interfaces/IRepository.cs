﻿namespace AgendamentoConsultorio.Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
    }
}