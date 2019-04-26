using System;
using System.Collections.Generic;
using System.Data;
using BAgeciaViajes;
using BAgeciaViajes.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Csharp.Clases;

namespace UnitTestAgenciaV
{
    [TestClass]
    public class UnitTest1
    {
       

        [TestMethod]
        public void TestMethodViaje()
        {
            //Telefono mTelefon = new Telefono();

            Viaje viajeM = new Viaje();
            DataTable viajeLista = viajeM.Listar();


            foreach (var item in viajeLista.Rows)
            {
                var result = item;
                ViajeEntity entidad = new ViajeEntity();

                entidad.destino = result.ToString();
                
            }

        }


    }
}
