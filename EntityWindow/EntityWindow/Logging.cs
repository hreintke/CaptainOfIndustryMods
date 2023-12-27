using Mafi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityWindowMod
{
    [GlobalDependency(RegistrationMode.AsSelf, false)]
    public static class LogWrite
    {
        private const string Prefix = "EntityWindow : ============> ";

        public static void Info(string message) => Mafi.Log.Info($"{Prefix}{message}");

        public static void InfoDebug(string message) => Mafi.Log.InfoDebug($"{Prefix}{message}");

        public static void Warning(string message) => Mafi.Log.Warning($"{Prefix}{message}");

        public static void WarningOnce(string message) => Mafi.Log.WarningOnce($"{Prefix}{message}");

        public static void Error(string message) => Mafi.Log.Error($"{Prefix}{message}");

        public static void Exception(Exception e, string message) => Mafi.Log.Exception(e, $"{Prefix}{message}");
    }
}
