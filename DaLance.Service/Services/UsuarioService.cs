using DaLance.Domain.Models;
using DaLance.Domain.Repositories;
using DaLance.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DaLance.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository repository)
        {
            usuarioRepository = repository;
        }

        public void Delete(int id)
        {
            usuarioRepository.Delete(usuarioRepository.GetById(id));
        }

        public List<Usuario> GetAll<TEntity>()
        {
            return usuarioRepository.GetAll<Usuario>();
        }

        public Usuario GetById(int id)
        {
            return usuarioRepository.GetById(id);
        }

        public int Insert(Usuario entity)
        {
            return usuarioRepository.Insert(entity);
        }

        public void Update(Usuario entity)
        {
            usuarioRepository.Update(entity);
        }
    }
}
