using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person Roberto;
        private Person Gonzalo;
        private Person Sandra;


        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            Roberto= new Person("Roberto Perez", "1260230-1");
            Gonzalo= new Person("Gonzalo Ramirez", "4705240-0");
            Sandra= new Person("Sandra Benitez", "3573453-1");

        }

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            string result = Roberto.Name;
            Assert.AreEqual("Roberto Perez",result);
        }
        [Test]
        public void Test2() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            string result = Gonzalo.Name;
            Assert.AreEqual("Gonzalo Ramirez",result);
        }
        [Test]
        public void Test3() // Cambiá el nombre para indicar qué estás probando
        {
            // Insertá tu código  de pruebaaquí
            string result = Sandra.ID;
            Assert.AreEqual("3573453-1",result);
        }
    }
}