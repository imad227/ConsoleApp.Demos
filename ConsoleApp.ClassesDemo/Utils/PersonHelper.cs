using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Utils {
    public static class PersonHelper {
        public static string GenerateIdNumber(string prefix) {
            return $"{prefix}-{RandomNumberGenerator
                                        .GetInt32(100000, 9999999)
                                        .ToString()}";

        }
    }
}