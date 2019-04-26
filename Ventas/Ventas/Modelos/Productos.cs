﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelos
{
    public class Productos
    {
        public int Id              { get; set; }
        public string Descripcion  { get; set; }
        public double Precio       { get; set; }
        public int CategoriaId     { get; set; }//Sirve para el diseño del formulario
        public Categoria Categoria { get; set; }

        public Productos()
        {
            Categoria   = new Categoria(1, "Laptops");
            CategoriaId =     Categoria.Id;
        }

        //Constructor
        public Productos (int id, string descripcion, double precio, Categoria categoria )
        {

            Id          = id;
            Descripcion = descripcion;
            Precio      = precio;
            Categoria   = categoria;
            CategoriaId = categoria.Id;


            
        }
    }
}
