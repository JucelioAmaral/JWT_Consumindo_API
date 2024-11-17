using Dapper;
using MonitoraEquipamentos.Domain;
using MonitoraEquipamentos.Repo.Context;
using MonitoraEquipamentos.Repo.Contract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MonitoraEquipamentos.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly MonitoraEquipamentosContext _context;

        public UserRepo(MonitoraEquipamentosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> SelectAllUsers()
        {
            IDbConnection conn = _context.GetConnection();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT * FROM Users";

                return await conn.QueryAsync<User>(sql: query);                
            }            
        }

        public async Task<User> SelectUserByUserID(string userid)
        {
            IDbConnection conn = _context.GetConnection();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT * FROM Users WHERE UserID = @userid";
                User user = await conn.QueryFirstOrDefaultAsync<User>
                    (sql: query, param: new { userid });
                conn.Close();
                return user;
            }
        }


        public User SelectUserAutenticacao(string userid)
        {
            IDbConnection conn = _context.GetConnection();

            using (conn)
            {
                conn.Open();
                string query = @"SELECT * FROM Users WHERE UserID = @userid";                
                return conn.QueryFirstOrDefault<User>
                    (sql: query, param: new { userid });
                 
            }
        }
    }
}
