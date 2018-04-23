using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//*Load the text file 
//*Convert the text to List<PrizeModel>
//Find the max ID 
//Add the new record with the new ID (max * 1) 
//Convert the prizes to list<string>
//Save the list<string> to the text file 

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModel.csv
        {
            return $@"{ConfigurationManager.AppSettings["filePath"] }\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                //each line is going to be comma delimited
                string[] cols = line.Split(',');
                PrizeModel pz = new PrizeModel();

                //int.Parse takes the string and converts into integer
                pz.Id = int.Parse(cols[0]);
                pz.PlaceNumber = int.Parse(cols[1]);
                pz.PlaceName = cols[2];
                pz.PrizeAmount = decimal.Parse(cols[3]);
                pz.PrizePercentage = double.Parse(cols[4]);
                output.Add(pz);
            }
            return output;
        }
        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();

                p.FirstName = cols[0];
                p.LastName = cols[1];
                p.EmailAddress = cols[2];
                p.CellphoneNumber = cols[3];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            
            List<string> lines = new List<string>();

            foreach (PrizeModel pz in models)
            {
                lines.Add($"{ pz.Id },{ pz.PlaceNumber },{ pz.PlaceName },{ pz.PrizeAmount },{ pz.PrizePercentage }");
            }
            //System.IO.Directory.CreateDirectory(newFolder.FullFilePath());
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach(PersonModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
