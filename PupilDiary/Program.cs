using System;
using System.Collections.Generic;
using System.Linq;

namespace PupilDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            string pupilName = Menu.AskPupiName();
            
            
            
            
            List<int> pupilScores = new List<int>();
            List<string> Journal = new List<string>();
            List<int> maths = new List<int>();
            List<int> reading = new List<int>();
            List<int> naturalHistory = new List<int>();
            List<int> physicalEducationurnal = new List<int>();
            List<int> letter = new List<int>();
           


            while (true)
            {
                string menuPoint = Menu.AskMainMenuPoint();
                switch (menuPoint)
                {
                    case "1":
                        int lesson = Menu.AskLesson();
                        Console.WriteLine(lesson);
                        switch (lesson)
                        {
                            case 1:
                                int readScope = Menu.ReadScope();
                                maths.Add(readScope);
                                break;
                            case 2:
                                readScope = Menu.ReadScope();
                                reading.Add(readScope);
                                break;
                            case 3:
                                readScope = Menu.ReadScope();
                                naturalHistory.Add(readScope);
                                break;
                            case 4:
                                readScope = Menu.ReadScope();
                                physicalEducationurnal.Add(readScope);
                                break;
                            case 5:
                                readScope = Menu.ReadScope();
                                letter.Add(readScope);
                                break;
                            default:
                                Console.WriteLine("Please provide a valid menu point: 1-5.");
                                break;
                        }
                        break;
                    case "2":

                        Console.WriteLine("1 - Общая статистика ученика");
                        Console.WriteLine("2 - Статистика ученика по предмету");


                        int statistics = Convert.ToInt32(Console.ReadLine());
                        switch (statistics)
                        {

                            case 1:
                                int sum = maths.Count + reading.Count + naturalHistory.Count + physicalEducationurnal.Count + letter.Count;
                                int sumTmp = maths.ToArray().Sum() + reading.ToArray().Sum() + naturalHistory.ToArray().Sum() + physicalEducationurnal.ToArray().Sum() + letter.ToArray().Sum();

                                Console.WriteLine($"{pupilName}', average score is {sumTmp / sum}");
                                break;
                            case 2:
                                Console.WriteLine("По какому предмету статистика");

                                foreach (var person in Journal)
                                {
                                    Console.WriteLine(person);
                                }

                                int les = Convert.ToInt32(Console.ReadLine());

                                switch (les)
                                {
                                    case 1:
                                        maths.Sort();
                                        maths.ToArray().Sum();
                                        Console.WriteLine($"{pupilName}'s minimum score is {maths[0]}, maximum score is {maths[maths.Count - 1]}, average score is {maths.ToArray().Sum() / maths.Count}");

                                        break;
                                    case 2:
                                        reading.Sort();
                                        reading.ToArray().Sum();
                                        Console.WriteLine($"{pupilName}'s minimum score is {reading[0]}, maximum score is {reading[reading.Count - 1]}, average score is {reading.ToArray().Sum() / reading.Count}");

                                        break;
                                    case 3:
                                        naturalHistory.Sort();
                                        naturalHistory.ToArray().Sum();
                                        Console.WriteLine($"{pupilName}'s minimum score is {naturalHistory[0]}, maximum score is {naturalHistory[naturalHistory.Count - 1]}, average score is {naturalHistory.ToArray().Sum() / naturalHistory.Count}");


                                        break;
                                    case 4:
                                        physicalEducationurnal.Sort();
                                        physicalEducationurnal.ToArray().Sum();
                                        Console.WriteLine($"{pupilName}'s minimum score is {physicalEducationurnal[0]}, maximum score is {physicalEducationurnal[physicalEducationurnal.Count - 1]}, average score is {physicalEducationurnal.ToArray().Sum() / physicalEducationurnal.Count}");


                                        break;
                                    case 5:
                                        letter.Sort();
                                        letter.ToArray().Sum();
                                        Console.WriteLine($"{pupilName}'s minimum score is {letter[0]}, maximum score is {letter[letter.Count - 1]}, average score is {letter.ToArray().Sum() / letter.Count}");

                                        break;
                                    default:
                                        Console.WriteLine("Please provide a valid menu point: 1-5.");
                                        break;
                                }
                                break;

                        }

                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Please provide a valid menu point: 1, 2 or 3.");
                        break;
                }
            }
        }
    }
}
