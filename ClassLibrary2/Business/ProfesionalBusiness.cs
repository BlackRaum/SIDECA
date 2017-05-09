using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProfesionalBusiness
    {
     ProfesionalData profesionalData;
        
     public ProfesionalBusiness()
     {
         profesionalData = new ProfesionalData();
     }

    public Profesional ObtenerProfesional(int cedula)
        {
            return profesionalData.ObtenerProfesional(cedula);
        }
    public LinkedList<Profesional> ObtenerProfesionalbyNombre(string nombreProfesional)
    {
        return profesionalData.ObtenerProfesionalbyNombre(nombreProfesional);
    }
    public string insertarProfesional(Profesional profesional, int departamento)
    {
        return profesionalData.insertarProfesional(profesional,departamento);
    }
    public string eliminarProfesional(int cedula)
    {
        return profesionalData.eliminarProfesional(cedula);
    }
    public string actualizarProfesional(Profesional profesional,int departamento)
    {
        return profesionalData.actualizarProfesional(profesional,departamento);
    }

    }

