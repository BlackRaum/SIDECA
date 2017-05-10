using System;

public class Denuncia
{
    private String numeroExpediente;
    private String tipoDenuncia;
    private Niño nino;

	public Denuncia()
	{
	}

    public string NumeroExpediente { get => numeroExpediente; set => numeroExpediente = value; }
    public string TipoDenuncia { get => tipoDenuncia; set => tipoDenuncia = value; }
    public Niño Nino { get => nino; set => nino = value; }
}
