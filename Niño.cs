using System;

public class Niño
{
    private int cedulaNiño;
    private String nombreNiño;
    private Char sexo;
    private int edad;
    private DateTime fechaNacimiento;
    private int cedulaEncargado;
    private String nombreEncargado;

    public Niño()
    {
    }

    public int CedulaNiño
    {
        get => cedulaNiño;
        set => cedulaNiño = value;
    }
    public string NombreNiño
    {
        get => nombreNiño;
        set => nombreNiño = value;
    }
    public char Sexo
    {
        get => sexo;
        set => sexo = value;
    }
    public int Edad
    {
        get => edad;
        set => edad = value;
    }
    public DateTime FechaNacimiento
    {
        get => fechaNacimiento;
        set => fechaNacimiento = value;
    }
    public int CedulaEncargado
    {
        get => cedulaEncargado;
        set => cedulaEncargado = value;
    }
    public string NombreEncargado
    {
        get => nombreEncargado;
        set => nombreEncargado = value;
    }
}
