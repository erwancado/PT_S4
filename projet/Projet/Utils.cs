using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Utils
    {
        public static void removeClient(int id, DB_ENTITIES _db)
        {
            Clients selectedClient = _db.Clients.Find(id);
            var rdv = _db.RendezVous;
            foreach (RendezVous myRdv in rdv)
            {
                if (myRdv.Clients_idClients == selectedClient.idClients)
                {
                    Utils.removeRdv(myRdv.idRendezVous, _db);
                }
            }
            var animals = _db.Animaux;
            foreach (Animaux animal in animals)
            {
                if (animal.Clients_idClients == selectedClient.idClients)
                {
                    Utils.removeAnimal(animal.idAnimaux, _db);
                }
            }
            var ordonnances = _db.Ordonnance;
            foreach (Ordonnance ordonnance in ordonnances) {
                if (ordonnance.Clients_idClients == selectedClient.idClients) {
                    Utils.removeOrdonnance(ordonnance.idOrdonnance, _db);
                }
            }
            _db.Clients.Remove(selectedClient);
            _db.SaveChanges();
        }

        public static void removeRdv(int id, DB_ENTITIES _db) {
            RendezVous myRdv = _db.RendezVous.Find(id);
            var factures = _db.Factures;
            foreach (Factures facture in factures) {
                if(facture.RendezVousId == myRdv.idRendezVous )
                Utils.removefacture(facture.RendezVousId, _db);
            }
            _db.RendezVous.Remove(_db.RendezVous.Find(id));
            _db.SaveChanges();
        }

        public static void removeAnimal(int id, DB_ENTITIES _db)
        {
            Animaux myAnimal = _db.Animaux.Find(id);
            var rappels = _db.Rappel;
            foreach (Rappel rappel in rappels)
            {
                if (rappel.Animaux_idAnimaux == myAnimal.idAnimaux)
                {
                    Utils.removeRappel(rappel.idRappel, _db);
                }
            }
            var ordonnances = _db.Ordonnance;
            foreach (Ordonnance ordonnance in ordonnances)
            {
                if (ordonnance.Animaux_idAnimaux == myAnimal.idAnimaux)
                {
                   Utils.removeOrdonnance(ordonnance.idOrdonnance, _db);
                }
            }
            myAnimal.Soins =null;
            myAnimal.Race = null;
            _db.Animaux.Remove(myAnimal);
            _db.SaveChanges();
        }

        public static void removeRappel(int id, DB_ENTITIES _db) {
            _db.Rappel.Remove(_db.Rappel.Find(id));
            _db.SaveChanges();
        }

        public static void removeOrdonnance(int id, DB_ENTITIES _db) {
            _db.Ordonnance.Remove(_db.Ordonnance.Find(id));
            _db.SaveChanges();
        }

        public static void removeSoin(int id, DB_ENTITIES _db)
        {
            var factures = _db.Factures;
            foreach (Factures facture in factures) {
                Utils.removefacture(facture.idFactures, _db);
            }
            _db.Soins.Remove(_db.Soins.Find(id));
            _db.SaveChanges();
        }

        private static void removefacture(int idFactures, DB_ENTITIES _db)
        {
            _db.Factures.Remove(_db.Factures.Find(idFactures));
            _db.SaveChanges();
        }
    }
}
