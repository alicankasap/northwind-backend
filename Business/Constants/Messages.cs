using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi.";
        public static string ProductDeleted = "Ürün başarıyla silindi.";
        public static string ProductUpdated = "Ürün başarıyla güncellendi.";

        public static string CategoryAdded = "Kategori başarıyla eklendi.";
        public static string CategoryDeleted = "Kategori başarıyla silindi.";
        public static string CategoryUpdated = "Kategori başarıyla güncellendi.";

        public static string UserRegistered = "Kullanıcı kaydı başarıyla oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";

        public static string SuccessfulLogin = "Başarıyla giriş yaptınız.";
        public static string PasswordError = "Hatalı bir şifre tuşladınız.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
