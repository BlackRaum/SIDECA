using System;

public class Departamento
{
    private int codigoDepartamento;
    private String nombreDepartamento;
    private String telefono;
    private String fax;
    private String correo;
    private int codigoOficina;
    
	public Departamento()
	{
	}

    public int CodigoDepartamento { get => codigoDepartamento; set => codigoDepartamento = value; }
    public string NombreDepartamento { get => nombreDepartamento; set => nombreDepartamento  = value; }
    public string Telefono { get => telefono; set => telefono = value; }
    public string Fax { get => fax; set => fax = value; }
    public string Correo { get => correo; set => correo = value; }
    public int CodigoOficina { get => codigoOficina; set => codigoOficina = value; }
}
