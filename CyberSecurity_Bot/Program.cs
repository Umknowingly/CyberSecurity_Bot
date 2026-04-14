using System;
using System.Media;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace CyberSecurity_Bot
{
    internal class Program
    {
        private static string userName = "";
        private static int invalidInputCount = 0;

        static void Main(string[] args)
        {
            Console.Title = "BIMO - Cybersecurity Awareness Bot";

            // Displays the Users Interface elements from BIMOUI class
            BIMOUI.DisplayLogo();
            BIMOUI.DisplayHeader();

            // Plays the voice greeting with a visual indicator
            BIMOUI.AnimatedLoading("🎵 Loading voice greeting", 1200);
            PlayGreetingIfExists();

            // Welcome and get user name with decorative border
            GetUserName();

            // Reset invalid input counter for the session
            invalidInputCount = 0;

            // The welcome message with typing effect
            BIMOUI.DisplayDecorativeWelcome(userName);

            BIMOUI.TypeWriterEffect($"Welcome aboard, {userName}! I'm excited to help you learn about cybersecurity.", true);
            Thread.Sleep(500); // Brief pause before showing the next message
            BIMOUI.DisplaySecurityTip("Always think before you click! 🛡️");

            // Starts chatbot 
            RunChatbot();
        }

        static void PlayGreetingIfExists() // Plays the embedded WAV file if it exists, otherwise shows a warning message
        {
            string resourceName = "CyberSecurity_Bot.greeting.wav";
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (SoundPlayer player = new SoundPlayer(stream))
                    {
                        player.Play(); // Async playback
                    }
                    BIMOUI.DisplaySuccessMessage("Voice greeting playing!");
                }
                else
                {
                    // Fallback if WAV file not found
                    BIMOUI.DisplayWarningMessage("Voice greeting not found. Text mode only.");
                }
            }
        }

        static void GetUserName()
        {
            BIMOUI.DisplayDecorativeBorder();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("║  👋 WELCOME TO BIMO - CYBERSECURITY AWARENESS BOT           ║");
            Console.WriteLine("║                                                             ║");
            Console.ResetColor();

            BIMOUI.DisplayUserPrompt("What is your name?:  ");
            userName = Console.ReadLine()?.Trim();

            while (string.IsNullOrWhiteSpace(userName))
            {
                BIMOUI.DisplayBotMessage("I didn't catch that. Could you please tell me your name?");
                BIMOUI.DisplayUserPrompt("What is your name? ");
                userName = Console.ReadLine()?.Trim();
            }



            // Capitalize first letter of name
            userName = char.ToUpper(userName[0]) + userName.Substring(1).ToLower();

            BIMOUI.DisplaySuccessMessage($"Nice to meet you, {userName}! 🎉");
            Thread.Sleep(800);
        }

        static void RunChatbot()
        {
            bool running = true;
            BIMOUI.DisplayDivider();

            while (running)
            {
                BIMOUI.DisplayUserPrompt();
                string input = Console.ReadLine();

                // Validate and clean input
                input = ValidateAndCleanInput(input);

                if (string.IsNullOrEmpty(input))
                {
                    HandleEmptyInput();
                    continue;
                }

                // Reset invalid input counter on successful valid input
                invalidInputCount = 0;

                // Convert to lowercase for comparison
                input = input.ToLower();

                // Process the input
                ProcessUserInput(input, ref running);
            }
        }

        static string ValidateAndCleanInput(string input)
        {
            if (input == null)
                return "";

            // Trim whitespace
            input = input.Trim();

            // Remove excessive whitespace
            input = Regex.Replace(input, @"\s+", " ");

            // Remove potentially dangerous characters (basic sanitization)
            input = Regex.Replace(input, @"[<>]", "");

            return input;
        }

        static void HandleEmptyInput()
        {
            invalidInputCount++;

            if (invalidInputCount >= 3)
            {
                BIMOUI.DisplayHelpfulSuggestion(userName);
                invalidInputCount = 0; // Reset after showing help
            }
            else if (invalidInputCount == 2)
            {
                BIMOUI.DisplayBotMessage($"I notice you're not typing anything, {userName}. Is there something specific about cybersecurity you'd like to know? Try asking about passwords, phishing, or safe browsing!");
            }
            else
            {
                BIMOUI.DisplayBotMessage($"I didn't receive any input, {userName}. Please type a question or command. Type 'help' to see what I can do!");
            }
        }

        static void ProcessUserInput(string input, ref bool running)
        {
            // Check for excessive length
            if (input.Length > 200)
            {
                BIMOUI.DisplayBotMessage($"That's a very long message, {userName}! Could you please keep your questions shorter so I can help you better? Try breaking it down into smaller questions.");
                return;
            }

            // Basic conversational responses
            if (input == "how are you" || input == "how are you?" || input == "how r u" || input == "how're you" || input == "how are you doing")
            {
                string[] responses = {
                    $"I'm doing great, {userName}! Thanks for asking! I'm fully operational and ready to help you stay safe online.",
                    $"I'm excellent, {userName}! All cybersecurity systems are running smoothly. How can I assist you today?",
                    $"I'm fantastic, {userName}! Just analyzing security threats and keeping users like you informed. What's on your mind?"
                };
                Random rand = new Random();
                BIMOUI.DisplayBotMessage(responses[rand.Next(responses.Length)]);
                return;
            }

            if (input == "what's your purpose" || input == "what is your purpose" || input == "why do you exist")
            {
                BIMOUI.DisplayBotMessage($"My purpose, {userName}, is to educate and protect users like you from cybersecurity threats. I'm here to help you understand password safety, recognize phishing attempts, practice safe browsing habits, and much more. Think of me as your digital bodyguard! 🛡️");
                return;
            }

            if (input == "what can i ask you about" || input == "what can I ask" || input == "topics" || input == "what do you know")
            {
                BIMOUI.DisplayTopics();
                return;
            }

            if (input == "who made you" || input == "who created you" || input == "your creator")
            {
                BIMOUI.DisplayBotMessage($"I was created by cybersecurity experts to help raise awareness about online safety, {userName}! My mission is to make the digital world safer for everyone.");
                return;
            }

            if (input == "thank you" || input == "thanks" || input == "thx")
            {
                BIMOUI.DisplayBotMessage($"You're very welcome, {userName}! Stay safe out there! 😊");
                return;
            }

            // Check for questions the bot doesn't understand
            if (input.EndsWith("?") || input.StartsWith("what") || input.StartsWith("how") || input.StartsWith("why") ||
                input.StartsWith("when") || input.StartsWith("where") || input.StartsWith("who"))
            {
                BIMOUI.DisplayBotMessage($"That's an interesting question, {userName}, but I'm specialized in cybersecurity topics. Could you ask me about password safety, phishing protection, safe browsing, or other security practices instead? Type 'help' to see what I can do!");
                return;
            }

            // Handle the original switch cases
            switch (input)
            {
                case "exit":
                case "quit":
                case "bye":
                    BIMOUI.DisplayDivider();
                    BIMOUI.TypeWriterEffect($"Stay safe online, {userName}! Remember, cybersecurity is everyone's responsibility. Goodbye! 👋", true);
                    BIMOUI.DisplaySuccessMessage("Session ended. Keep protecting your digital world!");
                    running = false;
                    break;

                case "help":
                case "commands":
                    BIMOUI.DisplayHelp();
                    break;

                case "password":
                case "passwords":
                    BIMOUI.DisplayBotMessage($"Great question about passwords, {userName}! 🔐\n\nUse strong passwords with 12+ characters, mix of letters, numbers, and symbols. Never reuse passwords across sites! Consider using a password manager like Bitwarden or 1Password to generate and store unique passwords for each account.");
                    BIMOUI.DisplaySecurityTip("Enable 2FA on all accounts that support it for an extra layer of protection!");
                    break;

                case "phishing":
                    BIMOUI.DisplayBotMessage($"Excellent topic, {userName}! 🎣\n\nWatch for suspicious emails, texts, or calls. Never click unknown links or download attachments from untrusted sources. Always verify the sender's email address carefully! Look for red flags like urgent language, spelling errors, and requests for personal information.");
                    BIMOUI.DisplaySecurityTip("When in doubt, don't click! Contact the company directly using official channels.");
                    break;

                case "2fa":
                case "mfa":
                    BIMOUI.DisplayBotMessage($"You're thinking ahead, {userName}! 🛡️\n\nAlways enable Two-Factor Authentication (2FA) or Multi-Factor Authentication (MFA) when available. It adds an extra layer of security by requiring a second verification method like:\n• Authenticator app code\n• Text message code\n• Biometric scan\n• Hardware security key");
                    BIMOUI.DisplaySuccessMessage("2FA blocks 99.9% of automated account takeover attacks!");
                    break;

                case "update":
                case "updates":
                    BIMOUI.DisplayBotMessage($"Smart thinking, {userName}! ⚡\n\nKeep your software, operating system, and antivirus updated. Security patches fix vulnerabilities that hackers might exploit. Enable automatic updates when possible and don't delay installing them!");
                    BIMOUI.DisplayWarningMessage("Delaying updates leaves your system vulnerable to known exploits!");
                    break;

                case "backup":
                case "backups":
                    BIMOUI.DisplayBotMessage($"Great point, {userName}! 💾\n\nAlways maintain regular backups of important files. Use the 3-2-1 rule:\n• 3 copies of your data\n• 2 different media types\n• 1 offsite backup (cloud storage works great!)");
                    BIMOUI.DisplaySecurityTip("Test your backups regularly to ensure they can be restored successfully!");
                    break;

                case "vpn":
                    BIMOUI.DisplayBotMessage($"Good question about VPNs, {userName}! 🔒\n\nUse a VPN when on public Wi-Fi to encrypt your internet traffic. It protects your data from being intercepted by others on the same network. Choose a reputable VPN provider with a strict no-logs policy.");
                    BIMOUI.DisplaySecurityTip("Free VPNs often sell your data - invest in a trusted paid service!");
                    break;

                case "hello":
                case "hi":
                case "hey":
                case "greetings":
                    string[] greetings = {
                        $"Hello again, {userName}! Ready to learn about cybersecurity? 🛡️",
                        $"Hi {userName}! How can I help protect your digital life today? 🔒",
                        $"Hey {userName}! Remember, staying safe online starts with awareness! 💡"
                    };
                    Random rand = new Random();
                    BIMOUI.DisplayBotMessage(greetings[rand.Next(greetings.Length)]);
                    break;

                default:
                    // Default response for unrecognized input
                    string[] defaultResponses = {
                        $"I don't seem to understand what you're trying to say, {userName}. Could you please rephrase? Try asking about passwords, phishing, safe browsing, or type 'help' for all options.",
                        $"Hmm, I'm not sure I follow, {userName}. I'm a cybersecurity awareness bot. Could you ask me about online safety topics instead?",
                        $"I don't recognize that query, {userName}. Feel free to ask me about cybersecurity topics like passwords, phishing, 2fa, updates, backups, or vpn. Type 'help' to see all options!"
                    };
                    Random randDefault = new Random();
                    BIMOUI.DisplayBotMessage(defaultResponses[randDefault.Next(defaultResponses.Length)]);
                    break;
            }
        }
    }
}