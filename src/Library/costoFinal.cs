using System;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;
/*En esta clase se esta utilizando el principio de SOLID, ya que la clase 
CostoFinal tiene una única responsabilidad, la cual es calcular el 
costo total de los productos y los equipos por separados y el total
de ambos.

Tabien cumple con el patrón GRASP porque se asigna la responsabilidad a la clase 
Product y Equipment las cuales tienen la informacion del costo del 
equipo y del producto. La cual se va a utilizar en la clase CostoFinal
para calcular el costo de los productos y equipos, y el total. Gacias al uso de los
atributos Costo de cada clase.*/
public class CostoFinal
{
    public static double Calcular(List<Product> products, List<Equipment> equipments)
    {
        double totalCost = 0;
        double productCost = 0;
        double equipmentCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.Costo;
            productCost +=product.Costo;
        }

        foreach (Equipment equipment in equipments)
        {
            totalCost += equipment.Costo;
            equipmentCost += equipment.Costo;
        }

        return totalCost;
        
    
    }
}

