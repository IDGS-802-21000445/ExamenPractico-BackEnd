using System;
using System.Collections.Generic;

namespace Examen_Practico.Models;

public partial class Productos
{
    public int ProductoID {get; set;}
    public string NombreProducto { get; set;}
    public string Descripcion { get; set;}
    public decimal Precio { get; set;}
    public string URLImagen { get; set; }
    public int CategoriaID { get; set; }
}

