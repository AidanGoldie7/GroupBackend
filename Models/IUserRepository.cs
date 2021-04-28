

using System;
using System.Collections.Generic;

namespace GroupBackend.Models


{
    public interface IUserRepository
    {
        IEnumerable<userDetails> GetAll();
        
        userDetails Add(userDetails user);
    }
}