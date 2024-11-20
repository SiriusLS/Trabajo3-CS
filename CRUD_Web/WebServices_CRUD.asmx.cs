using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.Services;

namespace CRUD_Web
{
    /// <summary>
    /// Descripción breve de WebServices_CRUD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServices_CRUD : System.Web.Services.WebService
    {
        [WebMethod(Description ="Guardar Alumnos Nuevos, \n si el email no comple el formato nombre@dominio.algo arroja false," +
            " no agregara nada, retorna false si algun correo o umero de matricula se repite ")]
        public bool GuardarAlumnos(String Nombre, String ApellidoPAt, String ApellidoMat, String Email,String NumeroMatricula)
        {
            try
            {
                CRUDWebEntities ctx = new CRUDWebEntities();
                if (!IsValidEmail(Email))
                {
                    return false; // Retorna false si el correo no es válido
                }
                if (ctx.Alumnos.Any(a=> a.NumeroMatricula == NumeroMatricula))
                {
                    return false;
                }
                if (ctx.Alumnos.Any(a=> a.Email == Email))
                {
                    return false;
                }
             
                Alumnos alumnos = new Alumnos();
                alumnos.Nombre = Nombre;
                alumnos.ApellidoPAt = ApellidoPAt;
                alumnos.ApellidoMat = ApellidoMat;
                alumnos.Email = Email;  
                alumnos.NumeroMatricula = NumeroMatricula;
                ctx.Alumnos.Add(alumnos);
                ctx.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex para formato de correo básico
            return System.Text.RegularExpressions.Regex.IsMatch(email, pattern);
        }
        [WebMethod(Description ="Listar los alumnos")]
        public List<Alumnos> listarAlumnos()
        {
            CRUDWebEntities ctx = new CRUDWebEntities();
            return ctx.Alumnos.ToList();
        }
        [WebMethod(Description = "Guardar Asignaturas, retornara false si la el nombre asignatura ya existe")]
        public bool GuardarAsignaturas(String NombreAsignatura, int Creditos)
        {
            try
            {
                CRUDWebEntities ctx = new CRUDWebEntities();
                if (ctx.Asignaturas.Any(a=> a.NombreAsignatura==NombreAsignatura))
                {
                    return false;
                }
                Asignaturas asignaturas= new Asignaturas();
                asignaturas.NombreAsignatura = NombreAsignatura;
                asignaturas.Creditos = Creditos;
                ctx.Asignaturas.Add(asignaturas);
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                return false;
            }
            return true;   
        }
        [WebMethod(Description ="Listar Asignaturas guardadas")]
        public List<Asignaturas> listarAsignaturas()
        {
            CRUDWebEntities ctx = new CRUDWebEntities();
            return ctx.Asignaturas.ToList();
        }
    }
}
