using System;

public class Usuario
{
    private string nombreUsuario;
    private string contrasena;

	public Usuario()
	{
	}
   
    public string Contrasena { get => contrasena; set => contrasena = value; }
    public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
}
