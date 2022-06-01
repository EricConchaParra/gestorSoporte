using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSoporte
{
    class Datos
    {
    }

    public class Clientes
    {
        int Id;
        string Rut;
        string Razon_social;
        string Fantasia;
        string C_comercial;
        string C_tecnico;
        string C_adm_sistema;
        string Notas;

        public Clientes(int id, string rut, string razon_social, string fantasia, string c_comercial, string c_tencico,
            string c_adm_sistema, string notas)
        {
            Id = id;
            Rut = rut;
            Razon_social = razon_social;
            Fantasia = fantasia;
            C_comercial = c_comercial;
            C_tecnico = c_tencico;
            C_adm_sistema = c_adm_sistema;
            Notas = notas;
        }

        public Clientes()
        {

        }
        public int ID { get => Id; set => Id = value; }
        public string Rut1 { get => Rut; set => Rut = value; }
        public string Razon_Social1 { get => Razon_social; set => Razon_social = value; }
        public string Fantasia1 { get => Fantasia; set => Fantasia = value; }
        public string C_comercial1 { get => C_comercial; set => C_comercial = value; }
        public string C_tecnico1 { get => C_tecnico; set => C_tecnico = value; }
        public string C_adm_sistema1 { get => C_adm_sistema; set => C_adm_sistema = value; }
        public string Notas1 { get => Notas; set => Notas = value; }

    }
}