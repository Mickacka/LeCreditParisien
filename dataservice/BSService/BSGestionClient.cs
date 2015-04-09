using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataService.BSDataObjects;

namespace DataService.BSService
{
    public class BSGestionClient
    {

        public IList<Client> RechercherClient(CritereRechercheClient critere)
        {
            return null;
        }

        public IList<Compte> RechercherCompteClient(CritereRechercheCompte critere)
        {
            return null;
        }

        public IList<Operation> RechercherOperations(CritereRechercheOperation critere)
        {
            return null;
        }

        public bool CreerModifierClient(Client c)
        {
            return false;
        }

        public long CreerModifierCompte(Compte compte)
        {
            return 1;
        }

        public Contrat RechercherContrat(CritereRechercheContrat contrat)
        {
            return null;
        }
    }
}
