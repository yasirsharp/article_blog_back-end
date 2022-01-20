using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class ErrorMessages
    {
        public static string ErrorUsersListed = "Kullanıcılar listelenemedi!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Hatalı parola!";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut!";
    }
}
