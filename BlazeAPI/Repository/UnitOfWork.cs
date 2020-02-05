using BlazeAPI.Context;
using BlazeAPI.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeAPI.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HRMS_TestingContext _context;
        public UnitOfWork(HRMS_TestingContext context)
        {
            _context = context;
            Authenticate = new UserRepository(_context);
            ConferenceDetails = new ConferenceRoomRepository(_context);
        }

        public IUserRepository Authenticate { get; private set; }

        public IConferenceRoomRepository ConferenceDetails { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
