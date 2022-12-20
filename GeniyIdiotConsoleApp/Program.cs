using System;
using System.Collections.Generic;
using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Гений или идиот. Главное меню";

            string[] menuItems = new string[]
            {
                "1. Начать тестирование",
                "2. Статистика",
                "3. Добавить новый вопрос",
                "4. Удаление вопроса",
                "5. Выход"
            };

            int rowCursor = Console.CursorTop;
            int colCursor = Console.CursorLeft;
            var indexPosition = 0;

            while (true)
            {
                DrawMenuChange(menuItems, rowCursor, colCursor, indexPosition);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (indexPosition < menuItems.Length - 1)
                        {
                            indexPosition++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (indexPosition > 0)
                        {
                            indexPosition--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (indexPosition)
                        {
                            case 0:
                                Console.Clear();
                                TestingUser();
                                break;
                            case 1:
                                Console.Clear();
                                StatisticMenu();
                                break;
                            case 2:
                                Console.Clear();
                                UserAddNewQuestion();
                                Console.Clear();
                                break;
                            case 3:
                                Console.Clear();
                                UserRemoveQuestion();
                                Console.Clear();
                                break;
                            default:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            }
        }

        static void StatisticMenu()
        {
            Console.Title = "Гений или идиот. Меню статистики";

            string[] menuItems = new string[]
            {
                "1. Посмотреть результаты прошлых тестирований",
                "2. Топ 3 пользователей",
                "3. Статистика по вопросам",
                "4. Назад"
            };

            int rowCursor = Console.CursorTop;
            int colCursor = Console.CursorLeft;
            var indexPosition = 0;
            var userChangePrevMenu = false;

            while (!userChangePrevMenu)
            {
                DrawMenuChange(menuItems, rowCursor, colCursor, indexPosition);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (indexPosition < menuItems.Length - 1)
                        {
                            indexPosition++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (indexPosition > 0)
                        {
                            indexPosition--;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (indexPosition)
                        {
                            case 0:
                                Console.Clear();
                                ShowAllPreviousResults();
                                break;
                            case 1:
                                Console.Clear();
                                UsersThreeTop();
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                RightAnswerQuestionStatistic();
                                Console.Clear();
                                break;
                            default:
                                userChangePrevMenu = true;
                                Console.Clear();
                                break;
                        }
                        break;
                }
            }
        }

        static void RightAnswerQuestionStatistic()
        {
            Console.Title = "Гений или идиот. Статистика ответов на вопросы.";
            Console.WriteLine("Статистика ответов на вопросы:\n");

            var allQuestions = Game.GetQuestions();

            if (allQuestions.Count != 0)
            {
                foreach (var item in allQuestions)
                {
                    if (item.AskTotal != 0)
                    {
                        var percentRightAnswers = item.RightAnwerTotal * 100 / item.AskTotal;

                        Console.WriteLine($"На вопрос \"{item.Text}\" верно ответили {item.RightAnwerTotal} из {item.AskTotal} " +
                                          $"что составляет {percentRightAnswers}%");
                    }
                    else
                    {
                        Console.WriteLine($"Вопрос \"{item.Text}\" ещё не задавался.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Отсутствует статистика ответов на вопросы");
            }

            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");

            Console.ReadKey();
        }

        static void UsersThreeTop()
        {
            var allUsers = Game.GetUserResults();

            if (allUsers.Count != 0)
            {
                var testingUsers = Game.SortingUsers(allUsers);
                var usersTop = testingUsers.Count;

                if (testingUsers.Count > 3)
                {
                    usersTop = 3;
                }

                if (usersTop == 0)
                {
                    Console.WriteLine("Нет сохранённых результатов, пожалуйста пройдите тестирование.");
                }
                else
                {
                    for (int i = 0; i < usersTop; i++)
                    {
                        Console.WriteLine($"{i + 1} место: {testingUsers[i].Name}, общее количество баллов: {testingUsers[i].RightAnswer}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Нет сохранённых результатов, пожалуйста пройдите тестирование.");
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");

            Console.ReadKey();
        }

        static void UserRemoveQuestion()
        {
            Console.WriteLine("Удаление вопроса");

            var allQuestions = Game.GetQuestions();

            var questionsCount = allQuestions.Count;

            if (questionsCount != 0)
            {
                Console.WriteLine("Выберите номер вопроса для удаления:");

                for (int i = 0; i < questionsCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {allQuestions[i].Text}");
                }

                Console.CursorVisible = true;

                var userAnswer = CheckUserAnswer(1, questionsCount);

                Game.RemoveQuestion(allQuestions[userAnswer - 1].Text);

                Console.WriteLine("Вопрос успешно удалён.");
                Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");

                Console.CursorVisible = false;

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Список вопросов пуст. Пожалуйста пройдите тестирование либо добавьте вопрос.");
                Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");

                Console.CursorVisible = false;
                Console.ReadKey();
            }
        }

        static int CheckUserAnswer(int userChoiceMinimal, int userChoiceMaximal)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine().Trim(), out int x) && x <= userChoiceMaximal && x >= userChoiceMinimal)
                {
                    return x;
                }
                else
                {
                    Console.WriteLine($"Овет должен быть числом и быть в диапозоне {userChoiceMinimal} ... {userChoiceMaximal}");
                }
            }
        }

        static string isEmptyUserAnswer()
        {
            while (true)
            {
                var tempUserAnswer = Console.ReadLine().Trim();

                if (tempUserAnswer.Length == 0)
                {
                    Console.WriteLine("Вы забыли ввести вопрос. Пожалуйста повторите ввод.");
                }
                else
                {
                    return tempUserAnswer;
                }
            }
        }

        static bool RepeatTestQuestion()
        {
            Console.WriteLine("Хотите продолжить тестирование? (Да/Нет)");

            string continueUserAnswer = Console.ReadLine().ToLower();

            while (continueUserAnswer != "да" && continueUserAnswer != "нет")
            {
                Console.WriteLine("Пожалуйста введите \"Да\" или \"Нет\"");
                continueUserAnswer = Console.ReadLine().ToLower();
            }

            return continueUserAnswer == "да";
        }

        static string CheckUserName()
        {
            string userName;

            while (true)
            {
                userName = Console.ReadLine();

                if (userName != "")
                {
                    return userName;
                }

                Console.WriteLine("Пожалуйста введите имя.");
            }
        }

        static void TestingUser()
        {
            Console.Title = "Гений или идиот. Тестирование";

            Game.CheckRequaredQuestions();

            var questions = Game.GetQuestions();
            var questionsCount = questions.Count;

            Console.WriteLine("Введите Ваше имя:");

            var user = new User(CheckUserName());

            do
            {
                List<int> randomIndexes = Game.GetRandomIndexes(questionsCount);

                user.RightAnswer = 0;

                for (int i = 0; i < questionsCount; i++)
                {
                    Console.WriteLine($"Вопрос №{randomIndexes[i] + 1}");
                    Console.WriteLine(questions[randomIndexes[i]].Text);

                    var userAnswer = CheckUserAnswer(Int32.MinValue, Int32.MaxValue);
                    questions[randomIndexes[i]].IsAnswerCorrect = 0;
                    questions[randomIndexes[i]].AskTotal++;

                    if (userAnswer == questions[randomIndexes[i]].RightAnswer)
                    {
                        user.RightAnswer++;
                        questions[randomIndexes[i]].IsAnswerCorrect++;
                        questions[randomIndexes[i]].RightAnwerTotal++;
                    }
                }

                user.Diagnose = Game.GetDiagnose(questionsCount, user.RightAnswer);

                Game.Save(questions);
                Game.SaveResultTesting(user);

                Console.WriteLine($"Количество верных ответов: {user.RightAnswer}");
                Console.WriteLine($"{user.Name}, Ваш дигноз: {user.Diagnose}");

            } while (RepeatTestQuestion());
            Console.Clear();
        }

        static string ShortenLongName(string userName)
        {
            return userName.Substring(0, 27) + "...";
        }

        static void ShowAllPreviousResults()
        {
            var userResults = Game.GetUserResults();

            if (userResults.Count != 0)
            {
                var formatSet = "|{0, -30}|{1, -15}|{2, -15}|";
                var currentLine = String.Format($"{formatSet}", "ФИО", "Верных ответов", "Диагноз");
                var lenghtStr = currentLine.Length;

                Console.WriteLine(new string('-', lenghtStr));
                Console.WriteLine(currentLine);
                Console.WriteLine(new string('-', lenghtStr));

                foreach (var line in userResults)
                {
                    if (line.Name.Length > 30)
                    {
                        line.Name = ShortenLongName(line.Name);
                    }

                    currentLine = String.Format($"{formatSet}", line.Name, line.RightAnswer, line.Diagnose);

                    Console.WriteLine(currentLine);
                }
                Console.WriteLine(new string('-', lenghtStr));
                Console.WriteLine();
                Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Отсутствуют сохранённые результаты прошлых тестирований. Пройдите тестирование.");
                Console.WriteLine();
                Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");
                Console.ReadKey();
            }
            Console.Clear();
        }

        static void DrawMenuChange(string[] menuItems, int rowCursor, int colCursor, int indexPosition)
        {
            Console.SetCursorPosition(colCursor, rowCursor);
            Console.CursorVisible = false;

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == indexPosition)
                {
                    Console.BackgroundColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }
        }

        static void UserAddNewQuestion()
        {
            Game.CheckRequaredQuestions();

            Console.WriteLine("Добавление нового вопроса.");
            Console.WriteLine("Пожалуйста напишите новый вопрос:");
            Console.CursorVisible = true;

            var newQuestion = isEmptyUserAnswer();

            Console.WriteLine("Пожалуйста введите правильный ответ на ваш вопрос:");
            Console.WriteLine($"Ответ на новый вопрос может содержать только цифры в дипазоне {Int32.MinValue}...{Int32.MaxValue}");

            var newAnswer = CheckUserAnswer(Int32.MinValue, Int32.MaxValue);

            Game.AddQuestion(new Question(newQuestion, newAnswer));

            Console.WriteLine("\nНовый вопрос успешно добавлен!");
            Console.WriteLine($"Новый вопрос: {newQuestion}\nОтвет к новому вопросу: {newAnswer}\n");
            Console.WriteLine("Для возврата в главное меню нажмите любую клавишу...");

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}