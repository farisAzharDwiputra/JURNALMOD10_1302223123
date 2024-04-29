using System;

public class Mahasiswa
{ 
		public string Name { get; set; }
	public string Nim { get; set; }
	public List <string> Course { get; set; }
	public int Year { get; set; }

	public Mahasiswa(string Nama,string nim,List<string> course,int year){
			Name = Nama;
			Nim = nim;
			Course = course;
			Year = year;
		}
	}
}
