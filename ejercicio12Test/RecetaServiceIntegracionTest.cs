using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejercicio12;

namespace ejercicio12Test {
    [TestClass]
    public class RecetaServiceIntegracionTest {
        [TestMethod]
        public void TestCreate() {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();

            IRecetaService sut = container.Resolve<IRecetaService>();

            Receta receta = new Receta();
            receta.nombre = "Arroz negro";
            receta.peso = 100;
            
            Receta resultado = sut.Create(receta);

            Assert.AreEqual(2 * 100.0, resultado.peso);
        }
    }
}
