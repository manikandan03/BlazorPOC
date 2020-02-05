using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazeAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Authenticate { get; }

        IConferenceRoomRepository ConferenceDetails { get; }
    }
}
