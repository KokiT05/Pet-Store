using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Common
{
    public static class CardInfoValidationConstants
    {
        public const int CardInfoNumberMaxLength = 19;
        public const int ExpirationDateMaxLength = 11;

        public const int CardHolderMaxLength = 100;

        public const int CVCMaxLength = 4;
    }
}
