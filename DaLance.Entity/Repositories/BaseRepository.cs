using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using DaLance.Domain;
using DaLance.Domain.Models;

namespace DaLance.Entity.Repositories
{
    public class BaseRepository<T> where T : BaseEntity
    {
        private readonly DaLanceContext context;
        string errorMessage = string.Empty;

        public BaseRepository(DaLanceContext context)
        {
            this.context = context;
        }

        //Nomeclatura "virtual" para sobrepor o metodo
        //Em suas suas classes "filhas"
        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }
        public virtual List<T> GetAll<TEntity>()
        {
            return context.Set<T>().Where(e => e.situacao == ESituacao.Ativo).ToList();
        }

        public virtual int Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                entity.data_alteracao = DateTime.Now;
                entity.data_criacao = DateTime.Now;
                entity.situacao = ESituacao.Ativo;

                context.Set<T>().Add(entity);
                return context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }

                throw new Exception(errorMessage, dbEx);
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {

                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errorMessage += Environment.NewLine + string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(errorMessage, dbEx);
            }
        }

    }
}

