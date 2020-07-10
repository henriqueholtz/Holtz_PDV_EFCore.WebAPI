using EFCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repo
{
    public interface IEFCoreRepo //Interface EntityFrameworkCore Respository
    { //Accept all entity/type
        void Add<t>(t entity) where t : class;
        void Update<t>(t entity) where t : class;
        void Delete<t>(t entity) where t : class;
        void Clear();
        Task<bool> SaveChangeAsync();
        //Empresa
        Task<Empresa[]> GetAllEmpresas();
        Task<Empresa> GetEmpresaByCod(int cod);
        Task<Empresa[]> GetEmpresaByRaz(string raz);

        //Usuario
        Task<Usuario> GetUsuarioByCod(int cod);
        Task<Usuario[]> GetAllUsuarios();

        //Filial
        Task<Filial[]> GetAllFiliais(int ParEmpCod);
        Task<Filial> GetFilialByCod(int ParEmpCod, int ParFilCod);
    }
}
