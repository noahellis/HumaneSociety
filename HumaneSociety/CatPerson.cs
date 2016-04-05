using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CatPerson : Person
    {
        Random catRandom = new Random();
        bool likesCats;
        bool hasCatAllergy;
        public CatPerson()
        {
            likesCats = TestLikesCats();
            hasCatAllergy = TestCatAllergy();
            preferredAnimal = "Cats";
            
        }

        public bool TestLikesCats()
        {
            int likeCatDeterminer = catRandom.Next(0, 50);
            if (likeCatDeterminer <= 15)
            {
                Console.WriteLine("After watching this person interact with one of the Cats, it seems they don't really like Cats.");
                likesCats = false;
                //Don't test for allergy, return to input?
            }
            else if (likeCatDeterminer > 15)
            {
                Console.WriteLine("After watching this person interact with one of the Cats, it is apparent that they love cats.");
                likesCats = true;
                TestCatAllergy();
            }
            return likesCats;
        }

        public bool TestCatAllergy()
        {
            int catAllergyDeterminer = catRandom.Next(0, 50);
            if (catAllergyDeterminer <= 20)
            {
                Console.WriteLine("Shortly after starting to interact with a Cat, the person begins sneezing and wheezing.");
                Console.WriteLine("They are allergic to Cats...");
                hasCatAllergy = true;
            }
            else if (catAllergyDeterminer > 20)
            {
                Console.WriteLine("The person has been interacting with the cat with no apparent adverse reactions.");
                Console.WriteLine("They do not seem to be allergic to Cats...");
                hasCatAllergy = false;
            }
            return hasCatAllergy;
        }

       
    }
}
