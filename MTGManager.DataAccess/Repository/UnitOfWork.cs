﻿using MTGManager.DataAccess.Database;
using MTGManager.DataAccess.Repository.IRepository;

namespace MTGManager.DataAccess.Repository
{
    public class UnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Card = new CardRepository(_db);
        }

        public ICardRepository Card { get; private set; }
    }
}