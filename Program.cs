using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using CommandLine;
using System.Runtime.InteropServices;

namespace Titanfall2_SkinTool
{
    public class Options
    {
        [Value(0, HelpText = "Path/To/Game/Directory", Required = true)]
        public string GamePath { get; set; }


        [Value(1, HelpText = "List of <path/to/skin.zip> to install.", Required = true)]
        public IEnumerable<string> InputFiles { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Enable verbose logging")]
        public bool Verbose { get; set; }

        [Option('q', "quit", Required = false, HelpText = "Don't wait for user interaction before closing console window")]
        public bool Quit { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// Used to display console if used with commandline arguments
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            if (0 < args.Length)
            {
                // args -> is commandline
                return CommandlineMain(args);
            }
            else
            {
                // no args -> default windowed application
                UiMain();
                return 0;
            }
        }

        static int CommandlineMain(string[] args)
        {
            bool wait = false;
            int code = 0; // 0 = succes; -1 = install failed; -2 = invalid arguments
            AllocConsole();

            CommandLine.Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    wait = !o.Quit;
                    Action<string> messageHandler = o.Verbose ? m => { Console.WriteLine(m); } : m => { };

                    // debug: print args
                    // messageHandler($"GamePath={o.GamePath}");
                    // messageHandler($"InputFiles=[{string.Join(", ", o.InputFiles)}]");
                    // messageHandler($"Verbos={o.Verbose}");

                    try
                    {
                        SkinTool tool = new SkinTool(o.GamePath, messageHandler);

                        foreach (string file in o.InputFiles)
                        {
                            tool.InstallSkin(file);
                        }
                    }
                    catch (Exception ex)   // Catches MyException as well
                    {
                        Console.Error.WriteLine(ex.ToString());
                        wait = true; // let user see 
                        code = -1;
                    }

                }).WithNotParsed(_ =>
                {
                    // argument parsing failed -> print error
                    Console.Error.WriteLine($"Parsing options failed. See above for more information on how to use.");
                    wait = true; // let user see error
                    code = -2;
                });

            // maybe wait for user input before closing
            if (wait)
            {
                Console.Write("Press any key to exit...");
                Console.Read();
            }

            return code;
        }

        static void UiMain()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}