using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet;

namespace TestsVETO
{
    [TestClass]
    public class TestsClients
    {
        static DB_ENTITIES _db = new DB_ENTITIES();
        static Clients toAdd;
        static Clients toAdd2;
        static Clients toRm;


        [AssemblyInitialize]
        public static void init(TestContext context)
        {
            toRm = new Clients
            {
                Nom = "ToRm",
                Prenom = "exemple",
                DateNaissance = DateTime.Parse("05/01/1999"),
                Adresse = "exemple d'adresse",
                Email = "Exemple@exemple.com",
                Téléphone = 0601020301,
            };

            toAdd = new Clients
            {
                Nom = "Exemple",
                Prenom = "exemple",
                DateNaissance = DateTime.Parse("05/01/1999"),
                Adresse = "exemple d'adresse",
                Email = "Exemple@exemple.com",
                Téléphone = 0601020301,
            };

            toAdd2 = new Clients
            {
                Nom = "Exemple2",
                Prenom = "exemple",
                DateNaissance = DateTime.Parse("05/01/1999"),
                Adresse = "exemple d'adresse",
                Email = "Exemple@exemple.com",
                Téléphone = 0601020301,
            };

            _db.Clients.Add(toRm);
            _db.SaveChanges();
        }

        [TestMethod]
        public void ClientAdd()
        {
            _db.Clients.Add(toAdd);
            toAdd = new Clients
            {
                Nom = "Exemple",
                Prenom = "exemple",
                DateNaissance = DateTime.Parse("05/01/1999"),
                Adresse = "exemple d'adresse",
                Email = "Exemple@exemple.com",
                Téléphone = 0601020301,
            };
            _db.Clients.Add(toAdd);

            _db.Clients.Add(toAdd2);

            _db.SaveChanges();


            Assert.AreEqual(2, _db.Clients.Where(s => s != null && s.Nom.Equals(toAdd.Nom)).Count());
            Assert.AreEqual(1, _db.Clients.Where(p => p.Nom == toAdd2.Nom).Count());
        }

        [TestMethod]
        public void TestRmClient()
        {
            _db.Clients.Remove(toRm);

            _db.SaveChanges();

            Assert.AreEqual(0, _db.Clients.Where(p => p.Nom == "ToRm").Count());
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            _db.Clients.RemoveRange(_db.Clients.Where(p => p.Nom.Equals("Exemple") || p.Nom.Equals("Exemple2")));

            _db.SaveChanges();
        }
    }
}
