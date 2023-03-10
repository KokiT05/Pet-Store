using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Common
{
    public static class PetValidationConstants
    {
        //public const int PetNameMinLength = 3;
        public const int NameMaxLength = 50;

        public const int MinAge = 0;
        public const int MaxAge = 1000;

        public const int BreedMaxLength = 30;

        public const int MinPrice = 0;
        public const int MaxPrice = 1000;
    }
}
