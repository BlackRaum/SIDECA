using System;

public class Departamento
{
    private int codigoDepartamento;
    private string nombreDepartamento;
    private string telefono;
    private string fax;
    private string correo;
    private Oficina oficina;
    
	public Departamento()
	{
	}

    public int CodigoDepartamento { get => codigoDepartamento; set => codigoDepartamento = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Fax { get => fax; set => fax = value; }
    public string Correo { get => correo; set => correo = value; }
    public Oficina Oficina { get => oficina; set => oficina = value; }
    public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento = value; }
}
