//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Product
    {
        public int Cantidad {get; set;}

        public string Unidad {get; set;}
        public string Ingredientes {get; set;}
        public double Costo {get; set;}
        public string Description {get; set;}
        public object UnitOfMeasurement { get; set; }

        public Product (int cantidad, string unidad, string ingredientes, double costo, string description)
        {
            Cantidad = cantidad;
            Unidad = unidad;
            Ingredientes = ingredientes;
            Costo = costo;
            Description = description;
        }
    }
}