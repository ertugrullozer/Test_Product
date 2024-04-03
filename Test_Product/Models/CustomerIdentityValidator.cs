﻿using Microsoft.AspNetCore.Identity;

namespace Test_Product.Models
{
    public class CustomerIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parala en az 6 karakter olmalıdır"
            };

        
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 büyük harf içermelidir."
            };
        }
         public override IdentityError PasswordRequiresLower() 
        {

            return new IdentityError
            {
                Code = "PasswordRequiresLower",
                Description = "Parola en az 1 çüçük harf içermelidir."

            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 alfanümerik karakter içermelidir"

            };

        }
    }
}
