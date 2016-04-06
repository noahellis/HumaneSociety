using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Terrarium : AnimalContainer
    {
        Iguana newIguana = new Iguana();

        public Terrarium()
        {
            size = 15;
            number = 20;
            
        }
        //public void FillOneTerrarium()
        //{
        //    if (animalCages.animalType.Equals("iguana", StringComparison.CurrentCultureIgnoreCase))
        //    {
        //        if (number > 0)
        //        {
        //            if (animalCages.animalType.Equals("Iguana", StringComparison.CurrentCultureIgnoreCase))
        //            { number -= 1; }
        //        }
        //        else if (number <= 0)
        //        {
        //            Console.WriteLine("You do not have enough space for this Iguana.");
        //        }
        //    }
        //}

        public void EmptyOneTerrarium()
        {

        }
        //public DataTable DisplayTerrariums()
        //{
        //    DataTable terrariumTable = new DataTable("Terrariums");
        //    terrariumTable.Columns.Add(new DataColumn("Terrarium Number", typeof(int)));
        //    terrariumTable.Columns.Add(new DataColumn("Occupying Animal", typeof(string)));
        //    for (int terrariumIndex = 1; terrariumIndex <= number; terrariumIndex++)
        //        //foreach (DataRow terrariumRow in terrariumTable.Rows)
        //    {
        //        terrariumTable.Rows.Add("{0}", terrariumIndex);
        //    }
        //    Console.WriteLine(terrariumTable.DataSet);
        //    return terrariumTable;
        //}
    }
}
