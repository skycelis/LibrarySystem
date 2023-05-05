using LibrarySystem.Debugging;

namespace LibrarySystem
{
    public class LibrarySystemConsts
    {
        public const string LocalizationSourceName = "LibrarySystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "519e4fc2b3aa401a805e3ace081fe1eb";
    }
}
