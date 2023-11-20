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
        public void IngresoOperario_PuedeIniciaSecion_DeberiaRetornarTrue()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Operario.Ingreso("tomas","gauto",1,CrudDAO.LeerOperarios()) ;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IngresoSupervisor_PuedeIniciaSecion_DeberiaRetornarTrue()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Supervisor.Ingreso("facundo", "pepe", 10, CrudDAO.LeerSupervisor());
            //Assert
            Assert.AreEqual(expected, actual);
        }

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

            // Assert: Agrega aserciones para verificar que el operario fue actualizado correctamente en la base de datos.
        }

    }
}