﻿using MTGManager.DataAccess.Database;
using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.Shared.Models;

namespace MTGManager.DataAccess.Repository
{
    public class CardRepository : Repository<Card>, ICardRepository
    {
        private ApplicationDbContext _db;

        public CardRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Card obj)
        {
            _db.Cards.Update(obj);
        }
    }
}
