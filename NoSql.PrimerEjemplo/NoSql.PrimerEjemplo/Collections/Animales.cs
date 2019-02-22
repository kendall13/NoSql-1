using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoSql.PrimerEjemplo.Collections
{

    /*
{
    "_id" : 1,
    "nombre" : "saulito",
    "fechaNacimiento" : ISODate("2019-01-01T21:21:20.201Z"),
    "tipo" : "perro",
    "tratamiento" : [
        {
            "tipo" : "operacion",
            "fecha" : ISODate("2019-02-01T22:21:20.201Z"),
            "precio" : 500
        }
    ]
}

         */

    public class Animales
    {
        ObjectId _id;
        string nombre;
        DateTime fechaNacimiento;
        string tipo;
        IList <Tratamiento> tratamiento;      

    }

    public class Tratamiento
    {

        string tipo;
        DateTime fecha;
        decimal precio;
    }
}