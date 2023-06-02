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
            return repo.GetDepartamentos();
        }

        [HttpGet("{id}")]
        public ActionResult<Departamento> GetDepartamento(int id)
        {
            return repo.BuscarDepartamento(id);
        }

        //api/Departamentos --> POST
        [HttpPost]
        public void InsertarDepartamento(Departamento departamento)
        {
            repo.InsertarDepartamento(departamento.Numero, departamento.Nombre, departamento.Localidad);
        }

        [HttpPut]
        public void ModificarDepartamento(Departamento departamento)
        {
            repo.ModificarDepartamento(departamento.Numero, departamento.Nombre, departamento.Localidad);
        }

        //api/Departamentos/{id}
        [HttpDelete("{id}")]
        public void EliminarDepartamento(int id)
        {
            repo.EliminarDepartamento(id);
        }
    }

}
