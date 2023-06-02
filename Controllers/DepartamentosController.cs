using API_CRUD_Departamentos.Models;
using API_CRUD_Departamentos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD_Departamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        RepositoryDepartamentos repo;
        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Departamento>> GetDepartamentos()
        {
            return this.repo.GetDepartamentos();
        }

        [HttpGet("{id}")]
        public ActionResult<Departamento> GetDepartamento(int id)
        {
            return this.repo.BuscarDepartamento(id);
        }

        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarDepartamento(Departamento departamento)
        {
            this.repo.InsertarDepartamento
                (departamento.Numero, departamento.Nombre, departamento.Localidad);
        }

        [HttpPut]
        public void ModificarDepartamento(Departamento departamento)
        {
            this.repo.ModificarDepartamento(departamento.Numero, departamento.Nombre, departamento.Localidad);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarDepartamento(int id)
        {
            this.repo.EliminarDepartamento(id);
        }
    }

}
