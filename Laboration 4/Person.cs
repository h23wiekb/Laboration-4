using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_4
{
    public class Person
    {
        public Gender TheGender { get; set; }
        public Hair HairStyle { get; set; }
        public string Eyecolor { get; set; }
        public DateTime Birthday { get; set; }

       
       
        public Person(Gender gender, Hair hair, string eyecolor, DateTime birthday)
        {
            TheGender = gender;
            HairStyle = hair;
            Eyecolor = eyecolor;
            Birthday = birthday;
           
        }

       public override string ToString()
        {
            return $"\nGender: {TheGender}" +
                $"\nBirthday: {Birthday: yyyy/MM/dd}" +
                $"\nHair length: {HairStyle.Hairlength} cm | Hair color: {HairStyle.Haircolor}" +
                $"\nEye color: {Eyecolor}";
        }


        

        


    }

    //public class AddPerson
}
