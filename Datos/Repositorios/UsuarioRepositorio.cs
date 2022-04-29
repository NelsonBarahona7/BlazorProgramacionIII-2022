using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio

{
    private string CadenaConexion;

    public UsuarioRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }

    private string MysqlConnection Conexion()
    {
        return new MysqlConnection(CadenaConexion);
    }


    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> Getlista()
    {
        IEnumerable<Usuario> usuarioList = new List<Usuario>();

        try
        {
            using MysqlConnection Conexion();
            await Conexion.OpenAsync();
            String Sql = "SELECT * FROM usuario;¨";
            usuarioList = Conexion.QueryAsync<Usuario>(Sql);

        }
        catch (Exception ex)
        {

        }
        return usuarioList;
    }

    public Task<Usuario> GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
