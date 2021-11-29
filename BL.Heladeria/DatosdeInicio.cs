using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Heladeria.SeguridadBL;

namespace BL.Heladeria
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var usuariocaja = new Usuario();
            usuariocaja.Nombre = "caja";
            usuariocaja.Contrasena = "1234";
            contexto.Usuarios.Add(usuariocaja);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Cono Chocolate";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Cono Vainilla";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Cono Fresa";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "MilkShake de Chocolate";
            contexto.Categorias.Add(categoria4);

            var categoria5 = new Categoria();
            categoria5.Descripcion = "MilkShake de Vainilla";
            contexto.Categorias.Add(categoria5);

            var categoria6 = new Categoria();
            categoria6.Descripcion = "MilkShake de Fresa";
            contexto.Categorias.Add(categoria6);

            var categoria7 = new Categoria();
            categoria7.Descripcion = "Nevada Limón";
            contexto.Categorias.Add(categoria7);

            var categoria8 = new Categoria();
            categoria8.Descripcion = "Medio Galón Fresa";
            contexto.Categorias.Add(categoria8);

            var categoria9 = new Categoria();
            categoria9.Descripcion = "Litro Chocolate";
            contexto.Categorias.Add(categoria9);

            var categoria10 = new Categoria();
            categoria10.Descripcion = "Medio Litro Vainilla";
            contexto.Categorias.Add(categoria10);

            var categoria11 = new Categoria();
            categoria11.Descripcion = "Chocotoffee";
            contexto.Categorias.Add(categoria11);

            var categoria12 = new Categoria();
            categoria12.Descripcion = "Galleta";
            contexto.Categorias.Add(categoria12);

            var categoria13 = new Categoria();
            categoria13.Descripcion = "Mocachino";
            contexto.Categorias.Add(categoria13);

            var categoria14 = new Categoria();
            categoria14.Descripcion = "Napolitano";
            contexto.Categorias.Add(categoria14);

            var categoria15 = new Categoria();
            categoria15.Descripcion = "Monkey Waffle";
            contexto.Categorias.Add(categoria15);

            var categoria16 = new Categoria();
            categoria16.Descripcion = "Berry Waffle";
            contexto.Categorias.Add(categoria16);

            var categoria17 = new Categoria();
            categoria17.Descripcion = "Brownie y Helado";
            contexto.Categorias.Add(categoria17);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Conos";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Bebidas";
            contexto.Tipos.Add(tipo2);

            var tipo3 = new Tipo();
            tipo3.Descripcion = "Envasados";
            contexto.Tipos.Add(tipo3);

            var tipo4 = new Tipo();
            tipo4.Descripcion = "Pasteles";
            contexto.Tipos.Add(tipo4);

            var tipo5 = new Tipo();
            tipo5.Descripcion = "Waffles y Brownies";
            contexto.Tipos.Add(tipo5);


            var cliente1 = new Cliente();
            cliente1.Nombre = "Keilin Zelaya";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Sofia Lanza";
            contexto.Clientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Nombre = "Marcos Mejia";
            contexto.Clientes.Add(cliente3);


            base.Seed(contexto);
        }
    }
}
