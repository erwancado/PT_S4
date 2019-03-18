using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet;
using System.Linq;

namespace TestsVETO
{
    [TestClass]
    public class TestProduits
    {
        static DB_ENTITIES _db = new DB_ENTITIES();
        static Produits toAdd;
        static Produits toAdd2;
        static Produits toRm;


        [AssemblyInitialize]
        public static void init(TestContext context)
        {
            toRm = new Produits
            {
                Nom = "ToRm",
                refProduits = "exemple",
                DateAcquisition = DateTime.Parse("05/01/1999"),
                PrixAcquisition = 15,
                PrixVente = 10,
                Description = "exemple"
            };

            toAdd = new Produits
            {
                Nom = "Exemple",
                refProduits = "exemple",
                DateAcquisition = DateTime.Parse("05/01/1999"),
                PrixAcquisition = 15,
                PrixVente = 10,
                Description = "exemple"
            };

            toAdd2 = new Produits
            {
                Nom = "Exemple2",
                refProduits = "exemple",
                DateAcquisition = DateTime.Parse("05/01/1999"),
                PrixAcquisition = 15,
                PrixVente = 10,
                Description = "exemple"
            };

            _db.Produits.Add(toRm);
            _db.SaveChanges();

        }

        [TestMethod]
        public void TestAddProduit()
        {
            _db.Produits.Add(toAdd);
            toAdd = new Produits
            {
                Nom = "Exemple",
                refProduits = "exemple",
                DateAcquisition = DateTime.Parse("05/01/1999"),
                PrixAcquisition = 15,
                PrixVente = 10,
                Description = "exemple"
            };
            _db.Produits.Add(toAdd);

            _db.Produits.Add(toAdd2);

            _db.SaveChanges();


            Assert.AreEqual(2, _db.Produits.Where(s => s != null && s.Nom.Equals(toAdd.Nom)).Count());
            Assert.AreEqual(1, _db.Produits.Where(p => p.Nom == toAdd2.Nom).Count());
        }

        [TestMethod]
        public void TestRmProduit()
        {
            _db.Produits.Remove(toRm);

            _db.SaveChanges();

            Assert.AreEqual(0, _db.Produits.Where(p => p.Nom == "ToRm").Count());
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            _db.Produits.RemoveRange(_db.Produits.Where(p => p.Nom.Equals("Exemple") || p.Nom.Equals("Exemple2")));

            _db.SaveChanges();
        }
    }
}
