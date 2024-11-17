using AutoMapper;
using MonitoraEquipamentos.Application.Dto;
using MonitoraEquipamentos.Domain;
using MonitoraEquipamentos.Repo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var arrayUsuarios = new List<User>();

                var usuarios = await _userRepo.SelectAllUsers();
                if (usuarios == null) return null;

                foreach (var usuario in usuarios)
                {
                    var user = new User()
                    {
                        UserID = usuario.UserID,
                        AccessKey = usuario.AccessKey
                    };
                    arrayUsuarios.Add(user);
                }

                return arrayUsuarios;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> GetUserByUserId(string userid)
        {
            try
            {
                var usuario = await _userRepo.SelectUserByUserID(userid);
                if (usuario == null) return null;

                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
