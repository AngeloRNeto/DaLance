using DaLance.Domain.Models;
using DaLance.Domain.Repositories;
using DaLance.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaLance.Service.Services
{
    public class LanceService : ILanceService
    {
        private readonly ILanceRepository lanceRepository;
        public LanceService(ILanceRepository repository)
        {
            lanceRepository = repository;
        }

        public void Delete(int id)
        {
            lanceRepository.Delete(lanceRepository.GetById(id));
        }

        public List<Lance> GetAll<TEntity>()
        {
            var a = lanceRepository.GetAll<Lance>();
            return lanceRepository.GetAll<Lance>();
        }

        public Lance GetById(int id)
        {
            return lanceRepository.GetById(id);
        }

        public int Insert(Lance entity)
        {
            return lanceRepository.Insert(entity);
        }

        public void Update(Lance entity)
        {
            lanceRepository.Update(entity);
        }
    }
}
