using DaLance.Domain.Models;
using DaLance.Domain.Repositories;
using DaLance.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaLance.Service.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository produtoRepository;
        public ProdutoService(IProdutoRepository repository)
        {
            produtoRepository = repository;
        }

        public void Delete(int id)
        {
            produtoRepository.Delete(produtoRepository.GetById(id));
        }

        public List<Produto> GetAll<TEntity>()
        {
            return produtoRepository.GetAll<Produto>();
        }

        public Produto GetById(int id)
        {
            return produtoRepository.GetById(id);
        }

        public int Insert(Produto entity)
        {
            return produtoRepository.Insert(entity);
        }

        public void Update(Produto entity)
        {
            produtoRepository.Update(entity);
        }
    }
}
