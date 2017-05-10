using System;

public class Caso
{
    private String numeroExpediente;
    private String tipoDenuncia;
    private DateTime fechaIngreso;
    private String estado;
    private Profesional profesional;
    private Departamento departamento;
    private Oficina oficina;



	public Caso()
	{
	}

    public string NumeroExpediente { get => numeroExpediente; set => numeroExpediente = value; }
    public string TipoDenuncia { get => tipoDenuncia; set => tipoDenuncia = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public string Estado { get => estado; set => estado = value; }
    public Profesional Profesional { get => profesional; set => profesional = value; }
    public Departamento Departamento { get => departamento; set => departamento = value; }
    public Oficina Oficina { get => oficina; set => oficina = value; }
}
