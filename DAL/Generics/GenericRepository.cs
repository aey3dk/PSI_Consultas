using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Generics
{
    public abstract class GenericRepository<T, K> : IGenericRepository<T, K>, IDisposable
        where T : class
        where K : struct
    {
        protected Conexao Conexao;

        public GenericRepository()
        {
            try
            {
                Conexao = new Conexao();
            }
            catch
            {
                throw;
            }
        }
        
        public void Inserir(T obj)
        {
            try
            {
                Conexao.Set<T>().Add(obj);
            }
            catch
            {
                throw;
            }
        }

        public void Excluir(T obj)
        {
            try
            {
                Conexao.Set<T>().Remove(obj);
            }
            catch
            {
                throw;
            }
        }

        public void Salvar()
        {
            try
            {
                Conexao.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public List<T> ListarTodos()
        {
            try
            {
                return Conexao.Set<T>().ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<T> ListarTodos(Expression<Func<T, Boolean>> filtro)
        {
            try
            {
                return Conexao.Set<T>().Where(filtro).ToList();
            }
            catch
            {
                throw;
            }
        }

        public T Obter(K chave)
        {
            try
            {
                return Conexao.Set<T>().Find(chave);                     
            }
            catch
            {
                throw;
            }
        }

        public T Obter(Expression<Func<T, Boolean>> filtro)
        {
            try
            {
                return Conexao.Set<T>().Where(filtro).SingleOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public void Dispose()
        {
            Conexao.Dispose();
        }
    }
}
