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

        [Option('w', "wait", Required = false, HelpText = "Wait for user input before closing console window")]
        public bool Wait { get; set; }
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
        static void Main(string[] args)
        {
            if (0 < args.Length)
            {
                // args -> is commandline
                CommandlineMain(args);
            }
            else
            {
                // no args -> default windowed application
                UiMain();
            }
        }

        static void CommandlineMain(string[] args)
        {
            bool wait = false;
            AllocConsole();

            CommandLine.Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    wait = o.Wait;
                    Action<string> messageHandler = o.Verbose ? m => { Console.WriteLine(m); } : m => { };

                    messageHandler($"GamePath={o.GamePath}");
                    messageHandler($"InputFiles=[{string.Join(", ", o.InputFiles)}]");
                    messageHandler($"Verbos={o.Verbose}");

                    try
                    {
                        SkinTool tool = new SkinTool(o.GamePath, messageHandler);

                        foreach (string file in o.InputFiles)
                        {
                            messageHandler(Path.GetFileNameWithoutExtension(file));

                            tool.InstallSkin(file);
                        }
                    }
                    catch (Exception ex)   // Catches MyException as well
                    {
                        Console.Error.WriteLine(ex.ToString());
                        wait = true; // let user see error
                    }

                }).WithNotParsed(_ =>
                {
                    // argument parsing failed -> print error
                    Console.Error.WriteLine($"Parsing options failed. See above for more information or use --help to get help.");
                    wait = true; // let user see error
                });

            // maybe wait for user input before closing
            if (wait)
            {
                Console.Write("Press any key to exit...");
                Console.Read();
            }
        }

        static void UiMain()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}