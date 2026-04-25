using CODE_TP_MODUL9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CODE_TP_MODUL9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("ARIEL", "103082430001"),
            new Mahasiswa("ANDRA", "10302000002"),
            new Mahasiswa("LEVI", "10302000003")
        };

        // A. GET: api/Mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        // B. POST: api/Mahasiswa
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            dataMahasiswa.Add(mhs);
        }

        // C. GET: api/Mahasiswa/{id}
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        // D. DELETE: api/Mahasiswa/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}