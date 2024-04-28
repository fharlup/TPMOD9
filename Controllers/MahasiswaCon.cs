using Microsoft.AspNetCore.Mvc;
using System.Text.Json;


[Route("api/[controller]")]
[ApiController]
public class MahasiswaController
{


    static public List<Mahasiswa> listMhs = new List<Mahasiswa> {
            new Mahasiswa("lebron", "13022220000"),
            new Mahasiswa("curr", "130222001"),
            };

    [HttpGet]
    public IEnumerable<Mahasiswa> Get()
    {
        return listMhs;
    }

    [HttpGet("{id}")]
    public Mahasiswa Get(int id)
    {
        return listMhs[id];
    }

    [HttpPost]
    public void Post([FromBody] Mahasiswa value)
    {
        listMhs.Add(value);
    }


    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        listMhs.RemoveAt(id);
    }
}
