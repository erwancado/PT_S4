using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet;

namespace TestsVETO
{
    [TestClass]
    public class TestAnimaux
    {
        static DB_ENTITIES _db = new DB_ENTITIES();
        static Animaux toAdd;
        static Animaux toAdd2;
        static Animaux toRm;


        [AssemblyInitialize]
        public static void init(TestContext context)
        {
           

            toRm = new Animaux
            {
                Nom = "ToRm",
                Poids = 18,
                DateNaissance = DateTime.Parse("05/01/1999"),
                Caractéristiques = "exemple de caracteristique",
                Clients_idClients = 1,
                Sexe = "M",
            };

            toAdd = new Animaux
            {
                Nom = "Exemple",
                Poids = 18,
                DateNaissance = DateTime.Parse("05/01/1999"),
                Caractéristiques = "exemple de caracteristique",
                Clients_idClients = 1,
                Sexe = "M",
            };

            toAdd2 = new Animaux
            {
                Nom = "Exemple2",
                Poids = 18,
                DateNaissance = DateTime.Parse("05/01/1999"),
                Caractéristiques = "exemple de caracteristique",
                Clients_idClients = 1,
                Sexe = "M",
            };

            _db.Animaux.Add(toRm);
            _db.SaveChanges();
        }

        [TestMethod]
        public void AnimauxAdd()
        {
            _db.Animaux.Add(toAdd);
            toAdd = new Animaux
            {
                Nom = "Exemple",
                Poids = 18,
                DateNaissance = DateTime.Parse("05/01/1999"),
                Caractéristiques = "exemple de caracteristique",
                Clients_idClients = 1,
                Sexe = "M",
            };
            _db.Animaux.Add(toAdd);

            _db.Animaux.Add(toAdd2);

            _db.SaveChanges();


            Assert.AreEqual(2, _db.Animaux.Where(s => s != null && s.Nom.Equals(toAdd.Nom)).Count());
            Assert.AreEqual(1, _db.Animaux.Where(p => p.Nom == toAdd2.Nom).Count());
        }

        [TestMethod]
        public void TestRmAnimaux()
        {
            _db.Animaux.Remove(toRm);

            _db.SaveChanges();

            Assert.AreEqual(0, _db.Animaux.Where(p => p.Nom == "ToRm").Count());
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            _db.Animaux.RemoveRange(_db.Animaux.Where(p => p.Nom.Equals("Exemple") || p.Nom.Equals("Exemple2")));

            _db.SaveChanges();
        }
    }
}
