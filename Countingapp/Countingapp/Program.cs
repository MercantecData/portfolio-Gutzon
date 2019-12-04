using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {

            appoverview();


        }
        static void appoverview()
        {
            int programnr = 1;
            string line = "";
            Console.Clear();
            Console.WriteLine("1 = Counting App");
            Console.WriteLine("2 = Magic 8-Ball");
            Console.WriteLine("3 = Number array");
            Console.WriteLine("4 = Tic Tac Toe");
            line = Console.ReadLine();
            if (Int32.TryParse(line, out programnr))
            { }
            else { programnr = 0; }
            switch (programnr)
            {
                case 1:
                    CountingApp();
                    break;
                case 2:
                    Magic8Ball();
                    break;
                case 3:
                    numberarray();
                    break;
                case 4:
                    tictactoe();
                    break;
                default:
                    appoverview();
                    break;
            }

        }
        static void CountingApp()
        {
            string line = "";
            int tal = 0;
            int count = 0;
            Console.Clear();
            Console.WriteLine("How far do you want to count?");
            Console.WriteLine("Type \"exit\" or \"Exit\" to go back.");
            line = Console.ReadLine();
            if (line == "exit" || line == "Exit")
            {
                appoverview();
            }
            if (Int32.TryParse(line, out count))
            {
                Console.Clear();
                while (tal < count)
                {
                    tal = tal + 1;
                    Console.WriteLine(tal);
                    Thread.Sleep(600);
                }
                Console.WriteLine("Press \"Enter\" to continue");
                Console.ReadLine();

            }
            Console.Clear();
            count = 0;
            CountingApp();
        }
        static void Magic8Ball()
        {
            string line = "";
            Console.Clear();
            Console.WriteLine("What is your question?");
            Console.WriteLine("Type \"exit\" or \"Exit\" to go back.");
            line = Console.ReadLine();
            Console.Clear();
            if (line == "exit" || line == "Exit") { appoverview(); }
            string[] answers = { "Yes", "No", "Maybe", "Ask again later", "Most liekly", "Of course", "Of course not", "I don't know", "Ask someone else", "Don't ask me", "YES!!!" };
            int answernr = new Random().Next(0, answers.Count());
            Console.WriteLine("The answer to the question:\"{0}\" is: {1}", line, answers[answernr]);
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
            Magic8Ball();
        }
        static void numberarray()
        {
            Console.Clear();
            Console.WriteLine("How many random numbers do you want to compare?");
            Console.WriteLine("Type \"exit\" or \"Exit\" to go back.");
            string line = Console.ReadLine();

            if (line == "exit" || line == "Exit")
            {
                appoverview();
            }
            int amount = 0;
            if (Int32.TryParse(line, out amount))
            {
                Console.Clear();
                int[] numbers = { };
                numbers = new int[amount];
                List<int> list = new List<int>();
                int count = 0;
                while (count < amount)
                {
                    count = count + 1;
                    list.Add(new Random().Next(0, 5000));
                }
                int[] array = list.ToArray();
                Console.WriteLine("These are the numbers:");
                //list.ForEach(i => Console.Write("{0}\t", i));
                //Console.WriteLine();
                count = 0;
                while (count < amount)
                {
                    Console.Write("{0}\t", array[count]);
                    count = count + 1;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Largest number:\t{0}", array.Max());
                Console.WriteLine("Smalest number:\t{0}", list.Min());
                count = 0;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press \"Enter\" to continue");
                Console.ReadLine();

            }
            numberarray();
        }
        static void tictactoe()
        {
            Console.Clear();
            string[] pieces = {"       ","  OOO  ","XX   XX",
                               "       "," OO OO "," X   X ",
                               "       ","OO   OO","  X X  ",
                               "   ",    "O  ",    "  X",
                                   "   ",    "  O",    "X  ",
                               "       ","OO   OO","  X X  ",
                               "       "," OO OO "," X   X ",
                               "       ","  OOO  ","XX   XX"};
            string[] numbersA = {"  ▄▄▄  ","   ▄▄  ","  ▄▄▄  ","  ▄▄▄  ","    ▄▄▄","▄▄▄▄▄▄▄",
                                 "▄██▀██▄"," ▄███  ","▄█▀▀▀█▄","▄█▀▀▀█▄","  ▄█▀██","██▀▀▀▀▀",
                                 "█▀   ▀█","▀▀ ██  ","     ██","     ██","▄█▀  ██","██     ",
                                 "█     █","   ██  ","    ▄█▀","   ███ ","██▄▄▄██","██▀▀▀█▄",
                                 "█▄   ▄█","   ██  ","  ▄█▀  ","     ██","▀▀▀▀▀██","     ██",
                                 "▀██▄██▀","▄▄▄██▄▄","▄██▄▄▄▄","▀█▄▄▄█▀","     ██","▀█▄▄▄█▀",
                                 "  ▀▀▀  ","▀▀▀▀▀▀▀","▀▀▀▀▀▀▀","  ▀▀▀  ","     ▀▀","  ▀▀▀  " };
            string[] MessageBoard = {
                " ▄▄▄▄▄▄▄▄                                "," ▄▄▄▄                                    ","     ▄    ▄    ▄    ▄▄    ▄▄   ▄         ","     ▄    ▄    ▄    ▄▄    ▄▄   ▄         ","                                         ","                                         ",
                " ▀▀▀██▀▀▀  ▄▄   ▄▄  ▄▄▄▄▄    ▄▄   ▄▄     "," ██▀▀█▄   ▄▄▄▄▄       ▄     ▄    ▄    ▄  ","      █▄ ▄▀▄ ▄█   ▄▀  ▀▄  █▀▄  █         ","      █▄ ▄▀▄ ▄█   ▄▀  ▀▄  █▀▄  █         ","                                         ","                                         ",
                "    ██     ██   ██  ██▀▀▀█▄  ██▄  ██     "," ██   █▄  ██▀▀▀█▄    █▀█    █▄  ▄▀▄  ▄█  ","       █▄█ █▄█    ▀▄  ▄▀  █  ▀▄█         ","       █▄█ █▄█    ▀▄  ▄▀  █  ▀▄█         ","                                         ","                                         ",
                "    ██     ██   ██  ██  ▄█▀  ██▀▄ ██     "," ██   ██  ██  ▄█▀   █▀ ▀█    █  █ █  █   ","        ▀   ▀       ▀▀    ▀   ▀▀         ","        ▀   ▀       ▀▀    ▀   ▀▀         ","                                         ","                                         ",
                "    ██     ██   ██  █████    ██ ▀▄██     "," ██   █▀  █████    ▄█████▄   ▀▄█   █▄▀   "," ▄▄▄ ▄ ▄ ▄  ▄▄   ▄▄    ▄   ▄ ▄ ▄   ▄ ▄▄  ","    ▄▄▄ ▄ ▄ ▄▄▄  ▄▄▄▄  ▄   ▄▄ ▄▄  ▄▄▄    ","                                         ","                                         ",
                "    ██     ▀█▄▄▄█▀  ██  ▀█▄  ██  ▀██     "," ██▄▄█▀   ██  ▀█▄  ██   ██    ▀█   █▀    ","  █  █▄█ ▄ ▀▄▄   █ █ ▄▀ ▀▄ █ █ █▀▄ █ █ █ ","     █  █▄█ █▄▄  █ ▄▄ █▄█ █▀▀█▀▀█ █▄▄    ","                                         ","                                         ",
                "    ▀▀       ▀▀▀    ▀▀   ▀▀  ▀▀   ▀▀     "," ▀▀▀▀     ▀▀   ▀▀  ▀▀   ▀▀     ▀   ▀     ","  █  █ █ █  ▄▄▀  █▀▄  ▀▄▀  ▀▄▀ █  ▀█ █▄▀ ","     █  █ █ █▄▄  █▄▄█ █ █ █  █  █ █▄▄    ","                                         ","                                         ",};
            string line = "═════════";
            string[] cursor = {"","","","","","","","","",""};
            string[] enterA = {"To lock in your choice","To Start Next Round","To Start a New Game","To retry the round"};
            int enterID = 0;
            int[] plads = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int cursorP = 0;
            string cursorikon = "▒";
            int Xp = 0;
            int Op = 0;
            int turn = new Random().Next(1, 3);
            int count = 0;
            int game = 1;
            int draws = 0;
            int messageid = 0;
            while (game != 0)
            {
                while (count < cursor.Count())
                {
                    if (count == cursorP) { cursor[count] = cursorikon; }
                    else if (count == cursor.Count() - 1) { if (turn == 2) { cursor[count] = "X"; } else { cursor[count] = " "; } }
                    else { if (plads[count] == 2) { cursor[count] = "X"; } else { cursor[count] = " "; } }
                    count = count + 1;
                }
                count = 0;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" ╔{0}╗\t╔{0}╦{0}╦{0}╗\t\t╔{0}╦{0}╗\t\t╔{0}╦{0}╗", line);
                Console.WriteLine(" ║  ROUND  ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0]], pieces[plads[1]], pieces[plads[2]], pieces[1], numbersA[Op], pieces[2], numbersA[Xp]);
                Console.WriteLine(" ║ {7} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0] + 3], pieces[plads[1] + 3], pieces[plads[2] + 3], pieces[1 + 3], numbersA[Op + 6], pieces[2 + 3], numbersA[Xp + 6],numbersA[game + draws]);
                Console.WriteLine(" ║ {7} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0] + 6], pieces[plads[1] + 6], pieces[plads[2] + 6], pieces[1 + 6], numbersA[Op + 12], pieces[2 + 6], numbersA[Xp + 12], numbersA[game + draws + 6]);
                Console.WriteLine(" ║ {15} ║\t║ {0}{2}{1} ║ {3}{5}{4} ║ {6}{8}{7} ║\t\t║ {9} {10} ║ {11} ║\t\t║ {12}X{13} ║ {14} ║", pieces[plads[0] + 9], pieces[plads[0] + 12], cursor[0], pieces[plads[1] + 9], pieces[plads[1] + 12], cursor[1], pieces[plads[2] + 9], pieces[plads[2] + 12], cursor[2], pieces[1 + 9], pieces[1 + 12], numbersA[Op + 18], pieces[2 + 9], pieces[2 + 12], numbersA[Xp + 18], numbersA[game + draws + 12]);
                Console.WriteLine(" ║ {7} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0] + 15], pieces[plads[1] + 15], pieces[plads[2] + 15], pieces[1 + 15], numbersA[Op + 24], pieces[2 + 15], numbersA[Xp + 24], numbersA[game + draws +18]);
                Console.WriteLine(" ║ {7} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0] + 18], pieces[plads[1] + 18], pieces[plads[2] + 18], pieces[1 + 18], numbersA[Op + 30], pieces[2 + 18], numbersA[Xp + 30], numbersA[game + draws + 24]);
                Console.WriteLine(" ║ {7} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║ {4} ║\t\t║ {5} ║ {6} ║", pieces[plads[0] + 21], pieces[plads[1] + 21], pieces[plads[2] + 21], pieces[1 + 21], numbersA[Op + 36], pieces[2 + 21], numbersA[Xp + 36], numbersA[game + draws + 30]);
                Console.WriteLine(" ║ {1} ║\t╠{0}╬{0}╬{0}╣\t\t╚{0}╩{0}╝\t\t╚{0}╩{0}╝", line,numbersA[game + draws + 36]);
                Console.WriteLine(" ╠{3}╣\t║ {0} ║ {1} ║ {2} ║", pieces[plads[3]], pieces[plads[4]], pieces[plads[5]], line);
                Console.WriteLine(" ║ OUT  OF ║\t║ {0} ║ {1} ║ {2} ║", pieces[plads[3] + 3], pieces[plads[4] + 3], pieces[plads[5] + 3],line);
                Console.WriteLine(" ║ {3} ║\t║ {0} ║ {1} ║ {2} ║", pieces[plads[3] + 6], pieces[plads[4] + 6], pieces[plads[5] + 6], numbersA [ 5]);
                Console.WriteLine(" ║ {10} ║\t║ {0}{2}{1} ║ {3}{5}{4} ║ {6}{8}{7} ║\t\t╔{9}╦{9}{9}{9}{9}═════╗", pieces[plads[3] + 9], pieces[plads[3] + 12], cursor[3], pieces[plads[4] + 9], pieces[plads[4] + 12], cursor[4], pieces[plads[5] + 9], pieces[plads[5] + 12], cursor[5], line, numbersA[5 + 6 ]);
                Console.WriteLine(" ║ {4} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{5}║", pieces[plads[3] + 15], pieces[plads[4] + 15], pieces[plads[5] + 15], pieces[turn], numbersA[5 + 12], MessageBoard[messageid]);
                Console.WriteLine(" ║ {4} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{5}║", pieces[plads[3] + 18], pieces[plads[4] + 18], pieces[plads[5] + 18], pieces[turn + 3], numbersA[5 + 18], MessageBoard[messageid + 6]);
                Console.WriteLine(" ║ {4} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{5}║", pieces[plads[3] + 21], pieces[plads[4] + 21], pieces[plads[5] + 21], pieces[turn + 6], numbersA[5 + 24], MessageBoard[messageid + 12]);
                Console.WriteLine(" ║ {4} ║\t╠{0}╬{0}╬{0}╣\t\t║ {1}{2}{3} ║{5}║", line, pieces[turn + 9], cursor[9], pieces[turn + 12], numbersA[5 + 30 ], MessageBoard[messageid + 18]);
                Console.WriteLine(" ║ {4} ║\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{5}║", pieces[plads[6]], pieces[plads[7]], pieces[plads[8]], pieces[turn + 15], numbersA[5 + 36], MessageBoard[messageid + 24]);
                Console.WriteLine(" ╚{4}╝\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{5}║", pieces[plads[6] + 3], pieces[plads[7] + 3], pieces[plads[8] + 3], pieces[turn + 18], line, MessageBoard[messageid + 30]);
                Console.WriteLine(" \t\t║ {0} ║ {1} ║ {2} ║\t\t║ {3} ║{4}║", pieces[plads[6] + 6], pieces[plads[7] + 6], pieces[plads[8] + 6], pieces[turn + 21],MessageBoard[messageid + 36]);
                Console.WriteLine("\t\t║ {0}{2}{1} ║ {3}{5}{4} ║ {6}{8}{7} ║\t\t╚{9}╩{9}{9}{9}{9}═════╝", pieces[plads[6] + 9], pieces[plads[6] + 12], cursor[6], pieces[plads[7] + 9], pieces[plads[7] + 12], cursor[7], pieces[plads[8] + 9], pieces[plads[8] + 12], cursor[8], line);
                Console.WriteLine("\t\t║ {0} ║ {1} ║ {2} ║\t\tPress \"ESC\" to quit.\t Press \"N\" to start a new game.", pieces[plads[6] + 15], pieces[plads[7] + 15], pieces[plads[8] + 15]);
                Console.WriteLine("\t\t║ {0} ║ {1} ║ {2} ║\t\tPress \"ENTER\" or \"SPACEBAR\" {3}.", pieces[plads[6] + 18], pieces[plads[7] + 18], pieces[plads[8] + 18],enterA[enterID]);
                Console.WriteLine("\t\t║ {0} ║ {1} ║ {2} ║", pieces[plads[6] + 21], pieces[plads[7] + 21], pieces[plads[8] + 21]);
                Console.WriteLine("\t\t╚{0}╩{0}╩{0}╝", line);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow) { cursorP = cursorP - 3; }
                else if (key.Key == ConsoleKey.DownArrow) { cursorP = cursorP + 3; }
                else if (key.Key == ConsoleKey.RightArrow) { cursorP = cursorP + 1; }
                else if (key.Key == ConsoleKey.LeftArrow) { cursorP = cursorP - 1; }
                else if (key.Key == ConsoleKey.Escape) { appoverview(); }
                else if (key.Key == ConsoleKey.N) { tictactoe(); }
                else if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Spacebar)
                {
                    if (plads[cursorP] == 0 & game == Xp + Op + 1 & plads.Min() == 0)
                    {
                        plads[cursorP] = turn;
                        if (turn == 1) { turn = 2; }
                        else { turn = 1; }
                    }
                    else if (Op >= 3 || Xp >= 3)
                    {
                        game = 0;
                    }
                    else if (plads.Min() != 0)
                    {
                        if (turn == 1) { turn = 2; }
                        else { turn = 1; }
                        while (count < plads.Count())
                        {
                            plads[count] = 0;
                            count = count + 1;
                        }
                        messageid = 0;
                        enterID = 0;
                        if (game == Op + Xp) { game = game + 1; }
                        count = 0;
                    }else if (game == Op + Xp)
                    {
                        if (turn == 1) { turn = 2; }
                        else { turn = 1; }
                        while (count < plads.Count())
                        {
                            plads[count] = 0;
                            count = count + 1;
                        }
                        messageid = 0;
                        enterID = 0;
                        if (game == Op + Xp) { game = game + 1; }
                        count = 0;
                    }
                    
                }
                if (cursorP > cursor.Count() - 2) { cursorP = cursor.Count() - 2; }
                else if (cursorP < 0) { cursorP = 0; }
                if (game == Op + Xp + 1)
                {
                    while (count <= 2)
                    {
                        if (plads[count * 3] > 0 & plads[count * 3] == plads[count * 3 + 1] & plads[count * 3] == plads[count * 3 + 2])
                        {
                            if (plads[count * 3] == 2) { Xp = Xp + 1; }
                            else { Op = Op + 1; }
                            messageid = 2;
                            enterID = 1;
                            if (turn == 1) { turn = 2; }
                            else { turn = 1; }
                            count = 4;
                        }
                        else if (plads[count] > 0 & plads[count] == plads[count + 3] & plads[count] == plads[count + 6])
                        {
                            if (plads[count] == 2) { Xp = Xp + 1; }
                            else if (plads[count] == 1) { Op = Op + 1; }
                            messageid = 2;
                            enterID = 1;
                            if (turn == 1) { turn = 2; }
                            else { turn = 1; }
                            count = 4;
                        }
                        else if (count != 1 & plads[count] > 0 & plads[count] == plads[4] & plads[count] == plads[8 - count])
                        {
                            if (plads[count] == 2) { Xp = Xp + 1; }
                            else if (plads[count] == 1) { Op = Op + 1; }
                            messageid = 2;
                            enterID = 1;
                            if (turn == 1) { turn = 2; }
                            else { turn = 1; }
                            count = 4;
                        }
                        count = count + 1;
                    }
                    if (plads.Min() != 0 & game != Op + Xp)
                    {
                        messageid = 1;
                        enterID = 3;
                    }
                    else if (Op == 3 || Xp == 3 )
                    {
                        messageid = 3;
                        enterID = 2;
                    }
                }
                count = 0;
            }
            tictactoe();
        }
        

    }

    
}
