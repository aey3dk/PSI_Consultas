using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Generics
{
    public abstract class GenericRepository<T, K> : IGenericRepository<T, K>, IDisposable
        where T : class
        where K : struct
    {
        //protected Conexao Conexao;
        protected RepositorioContainer Repositorio;

        public GenericRepository()
        {
            try
            {
                //Conexao = new Conexao();
                //Repositorio = new RepositorioContainer();
                Repositorio = DataBaseContextSingleton.DataBaseContext;
            }
            catch { throw; }
        }

        public GenericRepository(RepositorioContainer Repositorio)
        {
            try
            {
                this.Repositorio = Repositorio;
            }
            catch { throw; }
        }

        public void Inserir(T entity)
        {
            try
            {
                if (Repositorio.Entry(entity).State != EntityState.Unchanged && Repositorio.Entry(entity).State != EntityState.Modified)
                {
                    //if (Repositorio.Entry(entity).State == EntityState.Detached)
                    //    Repositorio.Entry(entity).State = EntityState.Modified;
                    //else
                        Repositorio.Set<T>().Add(entity);
                }
            }
            catch { throw; }
        }

        public void Excluir(T entity)
        {
            try
            {
                //if (Repositorio.Entry(entity).State == EntityState.Detached)
                //    Repositorio.Set<T>().Attach(entity);
                Repositorio.Set<T>().Remove(entity);
            }
            catch { throw; }
        }

        public void Salvar()
        {
            try
            {
                Repositorio.SaveChanges();
            }
            catch { throw; }
        }

        public List<T> ListarTodos()
        {
            try
            {
                return Repositorio.Set<T>().ToList();
            }
            catch { throw; }
        }

        public List<T> ListarTodos(Expression<Func<T, Boolean>> filtro)
        {
            try
            {
                return Repositorio.Set<T>().Where(filtro).ToList();
            }
            catch { throw; }
        }

        public T Obter(K chave)
        {
            try
            {
                return Repositorio.Set<T>().Find(chave);
            }
            catch { throw; }
        }

        public T Obter(Expression<Func<T, Boolean>> filtro)
        {
            try
            {
                return Repositorio.Set<T>().Where(filtro).SingleOrDefault();
            }
            catch { throw; }
        }

        public void Dispose()
        {
            Repositorio.Dispose();
        }
    }
}
