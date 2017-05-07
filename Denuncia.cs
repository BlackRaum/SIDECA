using System;

public class Denuncia
{
    private String numeroExpediente;
    private String tipoDenuncia;

	public Denuncia()
	{
	}

    public string NumeroExpediente { get => numeroExpediente; set => numeroExpediente = value; }
    public string TipoDenuncia { get => tipoDenuncia; set => tipoDenuncia = value; }
}
