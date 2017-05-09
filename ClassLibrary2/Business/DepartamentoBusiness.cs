using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepartamentoBusiness
    {
    private DepartamentoData departamentoData;
    
    public DepartamentoBusiness()
    {
        departamentoData = new DepartamentoData();
       
    }
    public Departamento ObtenerDepartamento(int departamento)
    {
        return departamentoData.ObtenerDepartamento(departamento);
    }
    public LinkedList<Departamento> ObtenerDepartamentobyOficina(int oficina)
    {
        return departamentoData.ObtenerDepartamentobyOficina(oficina);
    }
    public string insertarDepartamento(Departamento departamento)
    {
         return departamentoData.insertarDepartamento(departamento);
    }
    public string eliminarDepartamento(int departamento)
    {
         return departamentoData.eliminarDepartamento(departamento);
    }
    public string actualizarDepartamento(Departamento departamento)
    {
       return departamentoData.actualizarDepartamento(departamento);
    }
}

