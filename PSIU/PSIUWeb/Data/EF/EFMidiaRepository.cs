﻿using PSIUWeb.Data.Interface;
using PSIUWeb.Models;
using System.Linq;

namespace PSIUWeb.Data.EF
{
    public class EFMidiaRepository : IMidiaRepository
    {
        private AppDbContext context;

        public EFMidiaRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public Midia? Create(Midia m)
        {
            try
            {
                context.Midias?.Add(m);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return m;
        }

        public Midia? Delete(int id)
        {
            Midia? m = GetMidiaById(id);

            if (m == null)
                return null;

            context.Midias?.Remove(m);
            context.SaveChanges();

            return m;
        }

        public Midia? GetMidiaById(int id)
        {
            Midia? m =
                context
                    .Midias?
                    .Where(m => m.MidiaId == id)
                    .FirstOrDefault();

            return m;
        }

        public IQueryable<Midia>? GetMidias()
        {
            return context.Midias;
        }

        public Midia? Update(Midia m)
        {
            try
            {
                context.Midias?.Update(m);
                context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return m;
        }
    }
}
