using API_CRUD_Departamentos.Data;
using API_CRUD_Departamentos.Models;

namespace API_CRUD_Departamentos.Repositories
{
    public class RepositoryDepartamentos
    {
        DepartamentosContext context;
        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            return context.Departamentos.ToList();
        }

        public Departamento BuscarDepartamento(int deptno)
        {
            return context.Departamentos.SingleOrDefault(x => x.Numero == deptno);
        }

        public void InsertarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = new Departamento();
            dept.Numero = num;
            dept.Nombre = nom;
            dept.Localidad = loc;
            context.Departamentos.Add(dept);
            context.SaveChanges();
        }

        public void ModificarDepartamento(int num, String nom, String loc)
        {
            Departamento dept = this.BuscarDepartamento(num);
            dept.Nombre = nom;
            dept.Localidad = loc;
            context.SaveChanges();
        }

        public void EliminarDepartamento(int num)
        {
            Departamento dept = this.BuscarDepartamento(num);

            context.Departamentos.Remove(dept);
            context.SaveChanges();
        }
    }
}
