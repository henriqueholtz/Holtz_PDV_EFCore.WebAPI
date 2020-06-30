using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repo
{
    public class EFCoreRepo : IEFCoreRepo //EntityFrameworkCoreRepository
    {
        private readonly EmpresaContext _context;
        public EFCoreRepo(EmpresaContext context)
        {
            _context = context;
        }

        public void Add<t>(t entity) where t : class
        {
            _context.Add(entity);
        }
        public void Update<t>(t entity) where t : class
        {
            _context.Update(entity);
        }
        public void Delete<t>(t entity) where t : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0; //waiting while this context saving changes, return after. 
        }

        public async Task<Empresa[]> GetAllEmpresas()
        {
            IQueryable<Empresa> query = _context.Empresa;
                                //.Include(e => e.EmpFan);
            query = query.AsNoTracking().OrderBy(e => e.EmpCod);
            return await query.ToArrayAsync();
        }

        public async Task<Empresa> GetEmpresaByCod(int cod)
        {
            IQueryable<Empresa> query = _context.Empresa;
            //.Include(e => e.EmpFan);
            query = query.AsNoTracking().OrderBy(e => e.EmpCod);
            return await query.FirstOrDefaultAsync(e => e.EmpCod == cod);
        }

        public async Task<Empresa[]> GetEmpresaByRaz(string raz)
        {
            IQueryable<Empresa> query = _context.Empresa;
            //.Include(e => e.EmpFan);
            query = query.AsNoTracking()
                .Where(e => e.EmpRaz.Contains(raz))
                .OrderBy(e => e.EmpCod);
            return await query.ToArrayAsync();
        }
        public async Task<Usuario> GetUsuarioByCod(int cod)
        {
            IQueryable<Usuario> query = _context.Usuario;
            query = query.AsNoTracking()
                .Where(x => x.UsuCod == cod)
                .OrderBy(y => y.UsuCod);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Usuario[]> GetAllUsuarios()
        {
            IQueryable<Usuario> query = _context.Usuario;
            query = query.AsNoTracking()
                .OrderBy(order => order.UsuCod);
            return await query.ToArrayAsync();

        }

        public async Task<Filial[]> GetAllFiliais(int ParEmpCod)
        {
            IQueryable<Filial> query = _context.Filial;
            query = query.AsNoTracking()
                .OrderBy(order => order.EmpCod)
                .OrderBy(order => order.FilCod)
                .Where(where => where.EmpCod == ParEmpCod);
            return await query.ToArrayAsync();
        }

        public async Task<Filial> GetFilialByCod(int ParEmpCod, int ParFilCod)
        {
            IQueryable<Filial> query = _context.Filial;
            query = query.AsNoTracking()
                .OrderBy(order => order.EmpCod)
                .OrderBy(order => order.FilCod)
                .Where(where => where.EmpCod == ParEmpCod)
                .Where(where => where.FilCod == ParFilCod);
            return await query.FirstOrDefaultAsync();
        }
    }
}
