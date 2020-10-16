using System;
using MySql;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Collections;
using model.data;
using model.business;
using System.ComponentModel.Design;
using System.Data;
using MySqlX.XDevAPI.Relational;

namespace DEB
{
    class Program
    {


        static void Main(string[] arg)
        {

            dbal ledbal = new dbal();
            //FP.Execquery("INSERT INTO Pays (id, nom) values (1, 'France')");
            //pays unpays = new pays(2, "France");
            DAOPays pays = new DAOPays(ledbal);
            
            //pays.insert(unpays);
            //pays.delete(unpays);
            //pays.update(unpays);


            fromage fromage = new fromage(1, 1, "'raclette'", "'09/09/2020'", "image");
            DAOFromage unfromage = new DAOFromage(ledbal);

            //lefromage.insert(fromage);
            //lefromage.delete(fromage);
            //fromage.update(lefromage);



            //pays.InsertByFile("C:\\Users\\SIO2\\Desktop\\ClubFromageCS-main\\DEB\\pays.csv");


            DataSet lesPays = ledbal.RQuery("SELECT * FROM Pays");
            foreach (DataRow r in lesPays.Tables[0].Rows)
            {
                Console.WriteLine(r["id"]);
            }



            foreach (DataRow maligne in ledbal.SelectAll("pays").Rows)
            {
                
                    
                Console.WriteLine(maligne["nom"]);
                
            }
            
            
            /*foreach (DataRow row in ledbal.SelectByFile("Pays", "nom like 'P%'").Rows)
            {
                Console.WriteLine(row["nom"]);
            }*/

            DataRow id = ledbal.SelectById("Pays", 3);
            Console.WriteLine(id["id"]+"  "+id["nom"].ToString());

            pays.SelectAll();

            pays.SelectByName("France");

            pays.SelectById(12);

            unfromage.SelectAll();

            unfromage.SelectByName("Camembert");

            unfromage.SelectById(12);
        }

    }
}