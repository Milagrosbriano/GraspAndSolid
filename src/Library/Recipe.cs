//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            int count=0;
            Console.WriteLine("PASOS DE LA RECETA: ");
            Console.WriteLine("==============================================================");
            foreach (Step step in this.steps)
            {
                count++;
                Console.WriteLine($"Paso {count}: {step.Quantity} {step.Input.Unidad} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} segundos.");
                Console.WriteLine(" ");
            }
        }
    }
}