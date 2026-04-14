using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberSecurity_Bot
{
    internal class BIMOUI
    {
        // Typing effect delay in milliseconds
        private const int TYPING_DELAY_MS = 30;
        private const int CHARACTER_DELAY_MS = 15;

        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string logo = @"
╔══════════════════════════════════════════════════════════════════════════════╗
║                                                                              ║
║    ██████╗ ██╗███╗   ███╗ ██████╗                                            ║
║    ██╔══██╗██║████╗ ████║██╔═══██╗                                           ║
║    ██████╔╝██║██╔████╔██║██║   ██║                                           ║
║    ██╔══██╗██║██║╚██╔╝██║██║   ██║                                           ║
║    ██████╔╝██║██║ ╚═╝ ██║╚██████╔╝                                           ║
║    ╚═════╝ ╚═╝╚═╝     ╚═╝ ╚═════╝                                            ║
║                                                                              ║
║    ░█████╗░██╗░░░██╗██████╗░███████╗██████╗░                                 ║
║    ██╔══██╗╚██╗░██╔╝██╔══██╗██╔════╝██╔══██╗                                 ║
║    ██║░░╚═╝░╚████╔╝░██████╦╝█████╗░░██████╔╝                                 ║
║    ██║░░██╗░░╚██╔╝░░██╔══██╗██╔══╝░░██╔══██╗                                 ║
║    ╚█████╔╝░░░██║░░░██████╦╝███████╗██║░░██║                                 ║
║    ░╚════╝░░░░╚═╝░░░╚═════╝░╚══════╝╚═╝░░╚═╝                                 ║
║                                                                              ║
╚══════════════════════════════════════════════════════════════════════════════╝";
            Console.WriteLine(logo);
            Console.ResetColor();
        }

        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n" + new string('═', 70));
            Console.WriteLine("     🛡️  CYBERSECURITY AWARENESS BOT - BIMO  🛡️");
            Console.WriteLine(new string('═', 70));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n⚡ Initializing security protocols... ⚡\n");
            Thread.Sleep(800);
            Console.ResetColor();
        }

        public static void DisplaySectionHeader(string title, char icon = 'i')
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n{icon} {new string('─', 68)}");
            Console.WriteLine($"   {title}");
            Console.WriteLine($"   {new string('─', 68)}");
            Console.ResetColor();
        }

        public static void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"   {new string('•', 70)}");
            Console.ResetColor();
        }

        public static void DisplayDecorativeBorder()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.ResetColor();
        }

        public static void DisplayDecorativeWelcome(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║  🌟 WELCOME, {userName.ToUpper()}! 🌟                                                      ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  🤖 I'm BIMO, your Cybersecurity Assistant!                                  ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  📚 I'm here to help you stay safe online! Here's what I can do:            ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  🔐 • Answer questions about password security                              ║");
            Console.WriteLine("║  🎣 • Explain how to spot phishing attempts                                 ║");
            Console.WriteLine("║  🌐 • Discuss safe browsing practices                                       ║");
            Console.WriteLine("║  🛡️ • Explain Two-Factor Authentication (2FA)                               ║");
            Console.WriteLine("║  ⚡ • Share tips about software updates                                     ║");
            Console.WriteLine("║  💾 • Provide backup strategies                                             ║");
            Console.WriteLine("║  🔒 • Explain VPN and public Wi-Fi safety                                   ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  💡 Type 'help' anytime to see available commands!                          ║");
            Console.WriteLine("║  ❌ Type 'exit' or 'bye' to quit                                            ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void DisplayTopics()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  📚 TOPICS I CAN HELP YOU WITH                                                ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🔐 PASSWORD SAFETY:                                                         ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     • Creating strong passwords and passphrases                              ║");
            Console.WriteLine("║     • Using password managers safely                                         ║");
            Console.WriteLine("║     • Avoiding password reuse and common patterns                           ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🎣 PHISHING AWARENESS:                                                      ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     • Recognizing phishing emails and texts                                  ║");
            Console.WriteLine("║     • Spotting fake websites and links                                       ║");
            Console.WriteLine("║     • Avoiding social engineering attacks                                    ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🌐 SAFE BROWSING:                                                           ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     • Identifying secure websites (HTTPS + padlock)                          ║");
            Console.WriteLine("║     • Avoiding malicious downloads and pop-ups                               ║");
            Console.WriteLine("║     • Managing browser privacy settings                                      ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🛡️ ADDITIONAL SECURITY TOPICS:                                              ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     • Two-Factor Authentication (2FA/MFA) benefits                           ║");
            Console.WriteLine("║     • Software updates and security patches                                  ║");
            Console.WriteLine("║     • Data backups (3-2-1 rule)                                              ║");
            Console.WriteLine("║     • VPN protection and public Wi-Fi safety                                 ║");
            Console.WriteLine("║     • Antivirus and anti-malware solutions                                   ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  💬 CONVERSATIONAL:                                                          ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║     • Ask 'how are you?' to check on BIMO                                    ║");
            Console.WriteLine("║     • Ask 'what's your purpose?' to learn my mission                         ║");
            Console.WriteLine("║     • Ask 'what can I ask you about?' to see all topics                      ║");
            Console.WriteLine("║     • Say 'hello' or 'hi' for greetings                                      ║");
            Console.WriteLine("║     • Say 'thank you' to show appreciation                                   ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        public static void DisplayHelpfulSuggestion(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  💡 QUICK START GUIDE                                                          ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  Here are some things you can ask me:                                        ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║  🔐 • 'password'     - Learn about password security                         ║");
            Console.WriteLine("║  🎣 • 'phishing'     - Recognize phishing attempts                           ║");
            Console.WriteLine("║  🛡️ • '2fa'          - Two-Factor Authentication benefits                     ║");
            Console.WriteLine("║  ⚡ • 'update'       - Importance of software updates                         ║");
            Console.WriteLine("║  💾 • 'backup'       - Data backup strategies                                 ║");
            Console.WriteLine("║  🔒 • 'vpn'          - Virtual Private Network benefits                       ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("║  💡 Just type 'help' anytime to see all available commands!                  ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            TypeWriterEffect($"\n🤖 BIMO: I'm here to help, {userName}! What would you like to know about cybersecurity?", true);
        }

        public static void DisplayHelp()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n╔══════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  📋 BIMO - AVAILABLE COMMANDS                                                 ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🔐 SECURITY COMMANDS:                                                       ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║     • password      - Learn about password security                          ║");
            Console.WriteLine("║     • phishing      - Recognize phishing attempts                            ║");
            Console.WriteLine("║     • 2fa / mfa     - Two-Factor Authentication benefits                     ║");
            Console.WriteLine("║     • update        - Importance of software updates                         ║");
            Console.WriteLine("║     • backup        - Data backup strategies                                 ║");
            Console.WriteLine("║     • vpn           - Virtual Private Network benefits                       ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  💬 CONVERSATIONAL COMMANDS:                                                 ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║     • how are you?   - Check on BIMO                                         ║");
            Console.WriteLine("║     • what's your purpose? - Learn about my mission                          ║");
            Console.WriteLine("║     • what can I ask you about? - See all topics                             ║");
            Console.WriteLine("║     • hello / hi     - Greetings                                             ║");
            Console.WriteLine("║     • thank you      - Show appreciation                                     ║");
            Console.WriteLine("║                                                                              ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║  🛠️ UTILITY COMMANDS:                                                        ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║     • help          - Show this help menu                                    ║");
            Console.WriteLine("║     • topics        - Show all available topics                              ║");
            Console.WriteLine("║     • exit / bye    - Quit the chatbot                                       ║");
            Console.WriteLine("║                                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }

        public static void TypeWriterEffect(string message, bool isBotMessage = true)
        {
            if (isBotMessage)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n🤖 BIMO: ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(CHARACTER_DELAY_MS);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void DisplayBotMessage(string message)
        {
            TypeWriterEffect(message, true);
        }

        public static void DisplayPersonalizedBotMessage(string userName, string message)
        {
            TypeWriterEffect(message, true);
        }

        public static void DisplayUserPrompt(string prompt = null)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (string.IsNullOrEmpty(prompt))
            {
                Console.Write("\n💬 You: ");
            }
            else
            {
                Console.Write($"\n{prompt}");
            }
            Console.ResetColor();
        }

        public static void DisplaySecurityTip(string tip)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n💡 SECURITY TIP: {tip}");
            Console.ResetColor();
        }

        public static void DisplaySuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n✅ {message}");
            Console.ResetColor();
        }

        public static void DisplayWarningMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n⚠️ {message}");
            Console.ResetColor();
        }

        public static void DisplayInfoMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nℹ️ {message}");
            Console.ResetColor();
        }

        public static void AnimatedLoading(string message, int durationMs = 1000)
        {
            Console.Write($"\n{message}");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(durationMs / 3);
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}