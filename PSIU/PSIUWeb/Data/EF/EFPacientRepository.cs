using PSIUWeb.Data.Interface;
using PSIUWeb.Models;
using System.Linq;

namespace PSIUWeb.Data.EF
{
    public class EFPacientRepository : IPacientRepository
    {
        private AppDbContext Context;
        public EFPacientRepository(AppDbContext ctx)
        {
            Context = ctx;
        }
        

        public Pacient? Create(Pacient p)
        {
            try
            {
                Context.Pacients?.Add(p);
                Context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return p;
        }

        public Pacient? Delete(int id)
        {
            Pacient? p = GetPacientById(id);

            if (p == null)
                return null;

            Context.Pacients?.Remove(p);
            Context.SaveChanges();

            return p;
        }

        public Pacient? GetPacientById(int id)
        {
            Pacient? p =
                Context
                .Pacients?
                .Where(p => p.Id == id).FirstOrDefault();
            return p;
        }

        public IQueryable<Pacient>? GetPacients()
        {
            return Context.Pacients;
        }

        public Pacient? Update(Pacient? p)
        {
            try
            {
                Context.Pacients?.Update(p);
                Context.SaveChanges();
            }
            catch
            {
                return null;
            }

            return p;
        }
    }
    
}
