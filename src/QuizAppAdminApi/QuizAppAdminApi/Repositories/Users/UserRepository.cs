using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuizAppAdminApi.Data;
using QuizAppModels.Models.Informations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizAppAdminApi.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserInformation>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<IEnumerable<UserInformation>>(users);
        }

        public async Task<UserInformation> GetUserById(Guid userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            return _mapper.Map<UserInformation>(user);
        }
    }
}
