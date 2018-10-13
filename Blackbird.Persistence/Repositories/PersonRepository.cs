﻿using System;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;
using Blackbird.Persistence.Context;

namespace Blackbird.Persistence.Repositories
{
    public class PersonRepository 
        : RepositoryAsyncBase<Guid, Person>, IPersonRepository
    {
        public PersonRepository()
        {

        }
    }
}
