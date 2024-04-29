using Microsoft.AspNetCore.Mvc;

namespace Modul10_1302223123.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerMahasiswa : Controller
    {
        private static List<Mahasiswa> MahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa ("Faris Azhar Dwiputra","1302223123",["PBO","ADPL,KPL"],2022),
            new Mahasiswa ("Farah Amalia Putri","1302223137",["PBO","ADPL","KPL"],2022),
            new Mahasiswa ("Wildan Syukri Ni'am","1302220005",["PBO","ADPL","English"],2022),
            new Mahasiswa ("Muhammad Bintang Al-fath","1302223099",["PBO","KWU","KPL"],2022),
            new Mahasiswa ("Arga Adolf Lumunon","1302223038",["IMK","ADPL","KPL"],2022),
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return MahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return MahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            MahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void Delete(int id) 
        {
            MahasiswaList.RemoveAt(id);
        }
    }
}
