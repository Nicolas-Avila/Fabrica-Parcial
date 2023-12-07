using Fabrica;
using Parcial;
using System.Collections.Generic;
using Trabajador;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Actualizar_DeberiaActualizarOperario_SipervisorEnBD()
        {
            // Arrange
            int valorAleatorio = new Random().Next(0, 2);
            string nombre = (valorAleatorio == 0) ? "testOperador" : "testSupevisor";
            string apellido = (valorAleatorio == 0) ? "testOperador" : "testSupevisor";
            int id = 0; // Reemplaza con un ID existente en tu base de datos.
            string trabajos = (valorAleatorio == 0) ? "OPERADOR" : "SUPERVISOR";
            string trabajo = trabajos;
            // Act
            CrudDAO.Actualizar(nombre, apellido, id, trabajo);
                              
        }

        [TestMethod]
        public void IngresoOperario_PuedeIniciaSecion_DeberiaRetornarTrue()
        {
            Operario operario = new Operario("","",0);
            //Arrange
            bool expected = true;
            //Act
            bool actual = operario.ingreso("testOperador", "testOperador", 0, CrudDAO.LeerOperarios()) ;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CompruebaQueElColorSeaIgualAlJson_DeberiaRetornarTrue()
        {

            Archivos<Config> colorJs = new Archivos<Config>();
            Config coloresJson = colorJs.Leer_JSON<Config>();
            //Arrange
            bool expected = true;
            //Act
            bool actual = coloresJson.ColorClaro == "#58D8EC";
            //Assert
            Assert.AreEqual(expected , actual);
        }
    }
}