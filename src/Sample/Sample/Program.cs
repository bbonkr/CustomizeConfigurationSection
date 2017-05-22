using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var section=Config.AuthorizationConfigHelper.ReadSection();

                if (section == null)
                {
                    Console.WriteLine("Failed to load UrlsSection.");
                }
                else
                {
                    Console.WriteLine("Collection elements contained in the custom section collection:");
                    for (int i = 0; i < section.AuthorizationProcedures.Count; i++)
                    {
                        Output.Info("   Name={0} PROCEDURE={1}",
                            section.AuthorizationProcedures[i].Name,
                            section.AuthorizationProcedures[i].ProcedureName);
                    }
                }
            }
            catch(Exception ex)
            {
                Output.Error(ex);
            }
            finally
            {
                Output.Default("Press a any key to exit.");
                Console.ReadLine();
            }
        }
    }

    public class Output
    {
        public readonly static ConsoleColor ErrorForeColor = ConsoleColor.Red;
        public readonly static ConsoleColor InfoForeColor = ConsoleColor.Green;
        public readonly static ConsoleColor WarningForeColor = ConsoleColor.Yellow;
        public readonly static ConsoleColor DebugForeColor = ConsoleColor.Gray;

        public static void Default(string format, params object[] args)
        {
            Console.ResetColor();
            Console.WriteLine(FormatMessage(format, args));
        }

        public static void Default(string message) => Default("{0}", message);

        public static void Error(string format, params object[] args)
        {
            Console.ForegroundColor = ErrorForeColor;
            Console.WriteLine(FormatMessage(format, args));
            Console.ResetColor();
        }

        public static void Error(string message) => Error("{0}", message);

        public static void Error(Exception ex) =>Error(FormatMessage(ex));


        public static void Info(string format, params object[] args)
        {
            Console.ForegroundColor = InfoForeColor;
            Console.WriteLine(FormatMessage(format, args));
            Console.ResetColor();
        }

        public static void Warn(string format, params object[] args)
        {
            Console.ForegroundColor = WarningForeColor;
            Console.WriteLine(FormatMessage(format, args));
            Console.ResetColor();
        }

        public static void Debug(string format, params object[] args)
        {
            Console.ForegroundColor = DebugForeColor;
            Console.WriteLine(FormatMessage(format, args));
            Console.ResetColor();
        }

        private static string FormatMessage(string format, params object[] args)
        {
            return String.Format(format, args);
        }

        private static string FormatMessage(string message)
        {
            return FormatMessage("{0}", message);
        }

        private static string FormatMessage(Exception ex)
        {
            StringBuilder message = new StringBuilder();

            message.AppendFormat("Message: {0}", ex.Message);
            message.AppendLine();

            message.AppendLine(ex.StackTrace);

            if (ex.InnerException != null)
            {
                message.AppendFormat("InnerException Message: {0}", ex.InnerException.Message);
                message.AppendLine();

                message.AppendLine(ex.InnerException.StackTrace);
            }

            return FormatMessage(message.ToString());
        }

    }
}
