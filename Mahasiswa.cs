using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Mahasiswa
{
    public string Nama {  get; set; }
    public string Nim {  get; set; }
    public Mahasiswa()
    {
    }
    public Mahasiswa(string Nama,string Nim)
    {
        this.Nama = Nama; this.Nim = Nim;
    }
}
