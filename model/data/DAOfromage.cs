using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using DEB;
using model.business;
using model.data;
using System.Data;

namespace model.data
{
    class DAOFromage 
    {
        private dbal _dbal;

        public DAOFromage(dbal mydbal)
        {
            this._dbal = mydbal;
        }

        public void insert(fromage lefromage)
        {

            string query = " fromage values " + "(" + lefromage.Id + "," + lefromage.Paysorigineid + ","+ lefromage.Nom + ","+lefromage.Creation+","+lefromage.Image+");";
            _dbal.Insert(query);
        }

        public void delete(fromage lefromage)
        {
            string query = " FROM fromage where id = " + lefromage.Id + ";";
            _dbal.Delete(query);
        }

        public void update(fromage lefromage)
        {
            string query = " fromage set nom = 'tome' where id = " + lefromage.Id + ";";
            _dbal.Update(query);
        }



        public List<fromage> SelectAll()
        {
            List<fromage> lesfromages = new List<fromage>();
            foreach (DataRow dl in _dbal.SelectAll("fromage").Rows)
            {
                lesfromages.Add(new fromage((int)dl["id"], (int)dl["paysorigineid"], (string)dl["nom"], (string)dl["creation"], (string)dl["image"]));
                Console.WriteLine(dl["id"] + " " + dl["paysorigineid"] + " " + dl["nom"] +" " +dl["creation"] +" " +dl["image"]);
            }
            return lesfromages;
        }

        public fromage SelectByName(string namefromage)
        {
            DataRow nom = _dbal.SelectByField("fromage", "nom like '" + namefromage + "'").Rows[0];
            fromage unfro = new fromage((int)nom["id"], (int)nom["paysorigineid"], (string)nom["nom"], (string)nom["creation"], (string)nom["image"]);
            Console.WriteLine(unfro.Id);

            return unfro;

        }

        public fromage SelectById(int idFromage)
        {
            DataRow id = _dbal.SelectById("fromage", idFromage);
            fromage idfro = new fromage((int)id["id"], (int)id["paysorigineid"], (string)id["nom"], (string)id["creation"], (string)id["image"]);
            Console.WriteLine(idfro.Nom);
            return idfro;
        }

    }
}