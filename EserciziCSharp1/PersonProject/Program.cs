using System;
using System.Collections.Generic;
using System.Globalization;

namespace PersonProject
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Inserimento persone in Agenda");
                Console.WriteLine("Dove vuoi salvare i dati? [M]Memoria o [F]File. [X] per uscire dal programma");
                var userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.X) break;
                AgendaDirector director = null;
                switch (userInput.Key)
                {
                    case ConsoleKey.M:
                        director = new AgendaDirector(AgendaType.Memory);
                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        director = new AgendaDirector(AgendaType.File);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(
                            $"Hai inserito {userInput.Key} ,inserimento invalido.Premi un tasto per continuare");
                        Console.Read();
                        break;
                }

                if (director != null)
                {
                    //InsertTestData(director);
                    InsertPersonMenu(director);
                }
            }
        }

        private static void InsertTestData(AgendaDirector director)
        {
            director.AddPerson("Mario", "Rossi", new DateTime(1980, 5, 1),PersonState.Italia);
            director.AddPerson("Luigi", "Bianchi", new DateTime(1973, 7, 15), PersonState.Inghilterra);
            director.AddPerson("Gianni", "Verdi", new DateTime(1965, 12, 25), PersonState.Spagna);
        }

        private static void InsertPersonMenu(AgendaDirector director)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gestione Agenda");
                Console.WriteLine("Che operazione vuoi eseguire?");
                Console.WriteLine("[I]inserisci nuova persona in agenda");
                Console.WriteLine("[R]rimuovi persona dall'agenda");
                Console.WriteLine("[V]visualizza agenda");
                Console.WriteLine("[S]fai salutare le persone nell'agenda");
                Console.WriteLine("[X]per uscire dal programma");
                var userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.I:
                        try
                        {
                            HandleInsertPerson(director);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Eccezzione durante insert person con messaggio {e.Message}");
                            WaitForUserKeyAndClearConsole();
                        }
                        break;
                    case ConsoleKey.R:
                        try
                        {
                            HandleRemovePerson(director);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Eccezzione durante remove person con messaggio {e.Message}");
                            WaitForUserKeyAndClearConsole();
                        }
                        break;
                    case ConsoleKey.V:
                        try
                        {
                            HandleViewPeople(director);
                            WaitForUserKeyAndClearConsole();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Eccezzione durante view person con messaggio {e.Message}");
                            WaitForUserKeyAndClearConsole();
                        }
                        break;
                    case ConsoleKey.S:
                        try
                        {
                            HandlePeopleSayHello(director);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Eccezzione durante say hello con messaggio {e.Message}");
                            WaitForUserKeyAndClearConsole();
                        }
                        break;
                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(
                            $"Hai inserito {userInput.Key} ,inserimento invalido");
                        WaitForUserKeyAndClearConsole();
                        break;
                }
            }
        }

        private static void HandlePeopleSayHello(AgendaDirector director)
        {
            List<Person> personList = null;
            personList = director.GetPersonList();
            foreach (var person in personList)
            {
                var greet = person.Speaking.SayHello();
                Console.WriteLine($"{person.Name} {person.Surname} di nazionalita' {person.Nationality} dice :{greet}");
                var thanks = person.Speaking.SayThanks();
                Console.WriteLine($"{thanks}");
            }
            WaitForUserKeyAndClearConsole();
        }

        #region InsertPerson

        private static void HandleInsertPerson(AgendaDirector director)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Inserimento nuova persona in agenda");
                var nameInputString = HandleInsertPersonName(director);
                if (nameInputString.Equals("0"))
                {
                    Console.WriteLine("Uscita da inserimento persona");
                    WaitForUserKeyAndClearConsole();
                    break;
                }
                var surnameInputString = HandleInsertPersonSurname(director);
                if (surnameInputString.Equals("0"))
                {
                    Console.WriteLine("Uscita da inserimento persona");
                    WaitForUserKeyAndClearConsole();
                    break;
                }
                var dobDateTime = HandleInsertPersonDateOfBirth(director);
                if (dobDateTime == DateTime.MinValue)
                {
                    Console.WriteLine("Uscita da inserimento persona");
                    WaitForUserKeyAndClearConsole();
                    break;
                }
                Console.WriteLine(
                    $"Inserimento Persona {nameInputString} {surnameInputString} DOB: {dobDateTime.ToString(CultureInfo.CurrentCulture)}");
                if (director.AddPerson(nameInputString, surnameInputString, dobDateTime, PersonState.Italia))
                {
                    Console.WriteLine("Inserimento con successo");
                    WaitForUserKeyAndClearConsole();
                    break;
                }
                Console.WriteLine("Errore durante inserimento");
                WaitForUserKeyAndClearConsole();
                break;

            }
        }

        private static string HandleInsertPersonName(AgendaDirector director)
        {
            Console.WriteLine("Inserisci nome,ENTER per continuare,0 per uscire da inserimento");
            while (true)
            {
                var inputString = Console.ReadLine();
                if (inputString != null && inputString.Equals("0")) return inputString;
                if (director.IsNameValid(inputString)) return inputString;
                Console.WriteLine(
                    $"Hai inserito {inputString}, non valido come nome.Inserisci un nome o premi 0 per uscire");
            }
        }

        private static string HandleInsertPersonSurname(AgendaDirector director)
        {
            Console.WriteLine("Inserisci cognome,ENTER per continuare,0 per uscire da inserimento");
            while (true)
            {
                var inputString = Console.ReadLine();
                if (inputString != null && inputString.Equals("0")) return inputString;
                if (director.IsSurnameValid(inputString)) return inputString;
                Console.WriteLine(
                    $"Hai inserito {inputString}, non valido come cognome.Inserisci un cognome o premi 0 per uscire");
            }
        }

        private static DateTime HandleInsertPersonDateOfBirth(AgendaDirector director)
        {
            var dobYearInt = 0;
            var dobMonthInt = 0;
            var dobDayInt = 0;

            // inserimento anno
            while (true)
            {
                Console.WriteLine("Inserisci anno di nascita,ENTER per continuare,0 per uscire da inserimento  ");
                var dobYearInputString = Console.ReadLine();
                if (!int.TryParse(dobYearInputString, out dobYearInt))
                    Console.WriteLine($"{dobYearInputString} non e' un valore valido");
                else if (dobYearInt == 0)
                    return DateTime.MinValue;
                else if (!director.IsYearValid(dobYearInt))
                    Console.WriteLine($"{dobYearInputString} non e' un anno valido");
                else
                    break;
            }

            // inserimento mese
            while (true)
            {
                Console.WriteLine(
                    "Inserisci mese (in cifre) di nascita,ENTER per continuare,0 per uscire da inserimento ");
                var dobMonthInputString = Console.ReadLine();
                if (!int.TryParse(dobMonthInputString, out dobMonthInt))
                    Console.WriteLine($"{dobMonthInputString} non e' un valore valido");
                else if (dobMonthInt == 0)
                    return DateTime.MinValue;
                else if (!director.IsMonthValid(dobMonthInt))
                    Console.WriteLine($"{dobMonthInputString} non e' un mese valido");
                else
                    break;
            }
            // inserimento giorno
            while (true)
            {
                Console.WriteLine(
                    "Inserisci giorno (in cifre) di nascita,ENTER per continuare,0 per uscire da inserimento ");
                var dobDayInputString = Console.ReadLine();
                if (!int.TryParse(dobDayInputString, out dobDayInt))
                    Console.WriteLine($"{dobDayInputString} non e' un valore valido");
                else if (dobDayInt == 0)
                    return DateTime.MinValue;
                else if (!director.IsDayValid(dobDayInt, dobMonthInt, dobYearInt))
                    Console.WriteLine($"{dobDayInt}/{dobMonthInt}/{dobYearInt} non e' una data valida");
                else
                    break;
            }
            return new DateTime(dobYearInt, dobMonthInt, dobDayInt);
        }

        #endregion

        private static void HandleRemovePerson(AgendaDirector director)
        {
            Console.Clear();
            Console.WriteLine("Eliminazione persona dall'agenda");
            ShowPeopleList(director);
            while (true)
            {
                Console.WriteLine("Inserisci ID persona da eliminare,0 per annullare :");
                var userInputString = Console.ReadLine();
                // se user input invalido...(stringa)
              int userInputInt;
                if (!int.TryParse(userInputString, out userInputInt))
                {
                    Console.WriteLine($"Hai inserito {userInputString}.Input errato, inserire ID o 0 per annullare");
                }
                // se inserisce 0 (uscita da funzione eliminazione)
                else if (userInputInt == 0)
                {
                    break;
                }
                // se inserisce un valore valido che non esiste
                else if (!director.PersonIdExist(userInputInt))
                {
                    Console.WriteLine(
                        $"Persona con ID {userInputInt} non trovato,  inserire ID valido o 0 per annullare");
                }
                // persona trovata
                else
                {
                    var personToEliminate = director.GetPersonById(userInputInt);
                    if (personToEliminate != null)
                    {
                        Console.WriteLine($"Sto per eliminare {personToEliminate}, sei daccordo? [S/N]");
                        var userInputChoice = Console.ReadKey();
                        while (userInputChoice.KeyChar != 's' && userInputChoice.KeyChar != 'n')
                        {
                            Console.WriteLine("Input errato, inserire [S/N]");
                            userInputChoice = Console.ReadKey();
                        }
                        if (userInputChoice.KeyChar == 's')
                        {
                                if (director.RemovePersonById(userInputInt))
                                {
                                    Console.WriteLine("Persona eliminata");
                                    WaitForUserKeyAndClearConsole();
                                    break;
                                }
                            Console.WriteLine("Errore durante eliminazione");
                            WaitForUserKeyAndClearConsole();
                            break;
                        }
                        Console.WriteLine("Nessuna persona eliminata");
                        WaitForUserKeyAndClearConsole();
                        break;
                    }
                }
            }
        }

        private static void HandleViewPeople(AgendaDirector director)
        {
            Console.Clear();
            Console.WriteLine("Visualizzazione agenda ");
            Console.WriteLine("[ID] - [Nome] [Cognome] - DOB: [data di nascita]");
            ShowPeopleList(director);
            WaitForUserKeyAndClearConsole();
        }

        #region Helpers

        private static void WaitForUserKeyAndClearConsole()
        {
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
            Console.Clear();
        }
        private static void ShowPeopleList(AgendaDirector director)
        {
                Console.WriteLine("---------------------");
                Console.WriteLine("Persone nell'agenda :");
                Console.WriteLine(director.GetPeopleDescription());
                Console.WriteLine("---------------------");
        }

        #endregion
    }
}