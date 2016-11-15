using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Human
    {
        //private bool maleOrFemale;
        //private String eyeColor;
        //private String hairColor;
        //private int heightCategory;
        public enum Gender { Male, Female }
        public enum EyeColor { Brown, Green, Blue }
        public enum HairColor { Black, Blond, Brown, Purple}
        public enum Height { Short, Averege, High}

        public Gender MyGender { get; set; }
        public EyeColor MyEyeColor { get; set; }
        public HairColor MyHairColor { get; set; }
        public Height MyHeight { get; set; }


        public Human(Gender maleOrFemale, EyeColor eyeColor, HairColor hairColor, Height heightCategory)
        {
            this.MyGender = maleOrFemale;
            this.MyEyeColor = eyeColor;
            this.MyHairColor = hairColor;
            this.MyHeight = heightCategory;
        }

        public String GetDescription()
        {
            String description = "You got a " + MyGender;
            description = description + ", with " + MyEyeColor + " eyes";
            description = description + ", " + MyHairColor + " hair";
            description = description + ", who is " + MyHeight;

            return description;
        }

        //public String GetGenderDescription()
        //{
        //    if (MyGender)
        //    {
        //        return "man";
        //    }
        //    else
        //    {
        //        return "woman";
        //    }
        //}

        //public String GetHeightDescription()
        //{
        //    switch (MyHeight)
        //    {
        //        case 0:
        //            return "Very short";
        //        case 1:
        //            return "Short";
        //        case 2:
        //            return "Medium height";
        //        case 3:
        //            return "Tall";
        //        case 4:
        //            return "Very tall";
        //        default:
        //            return "Unknown height";
        //    }
        }
    }

