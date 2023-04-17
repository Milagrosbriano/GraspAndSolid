//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using Full_GRASP_And_SOLID.Library;

class Program
{
    static void Main(string[] args)
    {
        //ejemplo receta de torta 
        // Crear los objetos Product
        Product azucar = new Product(200,"g", "azúcar", 30, "Azúcar blanca refinada");
        Product manteca = new Product(200,"g", "manteca", 97, "Manteca Conaprole");
        Product harina = new Product(200, "g", "harina", 130, "Harina 0000");
        Product huevos = new Product(4, "unidades","huevos", 40, "Huevos de gallina");
        Product chocolate = new Product(100, "g", "chocolate", 180, "Chocolate en polvo");
        Product polvoHornear = new Product(15,"g", "polvo de hornear", 10, "Polvo de hornear Royal");
        Product leche = new Product(200,"ml", "leche", 50, "Leche Conaprole");
        // Crear los objetos Equipment
        Equipment balanza = new Equipment(50, "balanza", 1, "la balanza medir la cantidad y vertir en el bowl");
        Equipment cuchara = new Equipment(20, "cuchara", 1, "la cuchara de metal medir y vertir en el bowl ");
        Equipment cuchillo = new Equipment(40, "cuchillo", 1, "el cuchillo de metal romper y vertir en el bowl");
        

        // Crear una lista de Step
        List<Step> steps = new List<Step>()
        {
            new Step(azucar, 200, balanza, 20),//crear el paso
            new Step(manteca, 200, cuchillo, 30),
            new Step(harina, 200, balanza, 30),
            new Step(huevos, 4, cuchillo, 30),
            new Step(chocolate, 100, balanza, 30),
            new Step(polvoHornear, 15, cuchara, 30),
            new Step(leche, 200, balanza, 30),

        };

        // Crear una receta y agregar los pasos
        Recipe recipe = new Recipe();
        recipe.FinalProduct = new Product(0, "unidad(es)", "Torta de chocolate", 0, "Torta de chocolate");
        foreach (Step step in steps)
        {
            recipe.AddStep(step);
        }

        // Crear las listas de productos y equipos
        List<Product> products = new List<Product>() {azucar, manteca, harina, huevos, chocolate, polvoHornear, leche, recipe.FinalProduct };
        List<Equipment> equipments = new List<Equipment>() { balanza, cuchara, cuchillo };

        // Calcular los costos
        double totalCost = CostoFinal.Calcular(products, equipments);
        double productCost = CostoFinal.Calcular(products, new List<Equipment>());
        double equipmentCost = CostoFinal.Calcular(new List<Product>(), equipments);

        // Imprimir los resultados
        Console.WriteLine("COSTOS DE LA RECETA: ");
        Console.WriteLine("==============================================================");
        Console.WriteLine($"Costo total: {totalCost}");
        Console.WriteLine($"Costo total de productos: {productCost}");
        Console.WriteLine($"Costo total de equipos: {equipmentCost}");
                
    }
}
    
