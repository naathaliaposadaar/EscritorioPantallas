using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_DTO
{
   public class Usuario
    {
        private int _rutUsuario;
        private int _dv;
        private string _nombreUsuario;
        private string _apellidoP;
        private string _apellidoM;
        private DateTime _fechaNacimiento;
        private int _telefono;
        private string _correo;
        private string _credencial;
        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        
        public string Credencial
        {
            get { return _credencial; }
            set { _credencial = value; }
        }
        
        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        
        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        
        public string ApellidoM
        {
            get { return _apellidoM; }
            set { _apellidoM = value; }
        }
        
        public string ApellidoP
        {
            get { return _apellidoP; }
            set { _apellidoP = value; }
        }
        
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        

        public int Dv
        {
            get { return _dv; }
            set { _dv = value; }
        }
        

        public int RutUsuario
        {
            get { return _rutUsuario; }
            set { _rutUsuario = value; }
        }
        
    }
}
