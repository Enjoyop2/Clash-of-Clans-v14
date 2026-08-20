using System;
using System.IO;

using NLog;

namespace ClashofClans
{
	public partial class Logger
	{
#if DEBUG
		private static readonly object ConsoleSync = new object();
#endif

		private static NLog.Logger _logger;

		public Logger()
		{
			Directory.CreateDirectory("Logs");

			_logger = LogManager.GetCurrentClassLogger();
		}

		public static void Log(object message, Type type, LogErrorType logType = LogErrorType.INFO)
		{
			switch (logType)
			{
				case LogErrorType.INFO:
					{
						_logger.Info(message);

						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write($"[{logType.ToString()}] ");
						Console.ResetColor();
						Console.WriteLine(message);
						break;
					}

				case LogErrorType.WARNING:
					{
						_logger.Warn(message);
#if DEBUG
						lock (ConsoleSync)
						{
							Console.ForegroundColor = ConsoleColor.DarkMagenta;
							Console.Write($"[{logType.ToString()}] ");
							Console.ResetColor();
							Console.WriteLine(message);
						}
#endif
						break;
					}

				case LogErrorType.ERROR:
					{
						_logger.Error(message);
#if DEBUG

						lock (ConsoleSync)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.Write($"[{logType.ToString()}] ");
							Console.ResetColor();
							Console.WriteLine(message);
						}
#endif
						break;
					}

				case LogErrorType.DEBUG:
					{
#if DEBUG
						_logger.Debug(message);

						lock (ConsoleSync)
						{
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write($"[{logType.ToString()}] ");
							Console.ResetColor();
							Console.WriteLine(message);
						}
#endif
						break;
					}
			}
		}
	}
}