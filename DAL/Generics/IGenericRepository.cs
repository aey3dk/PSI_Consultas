using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Generics
{
    public interface IGenericRepository<T, K>
        where T : class
        where K : struct
    {
        void Inserir(T obj);
        void Excluir(T obj);
        void Salvar();
        List<T> ListarTodos();
        List<T> ListarTodos(Expression<Func<T, Boolean>> filtro);
        T Obter(K chave);
        T Obter(Expression<Func<T, Boolean>> filtro);

    }
}
