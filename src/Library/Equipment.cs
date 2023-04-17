//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public int Costo { get; set; }
        public string Equipo { get; set; }
        public int Cantidad { get; set; }
        public string Description {get; set;} 


        public Equipment(int costo, string equipo, int cantidad, string description)
        {
            Costo = costo;
            Equipo = equipo;
            Cantidad = cantidad;
            Description = description;

        }
    }
}
