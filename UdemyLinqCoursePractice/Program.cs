public class Exercise
{
    //Implement the CountAllLongWords method, which will count all words longer than 10 letters.
    public static int CountAllLongWords(IEnumerable<string> words)
    {
        return words.Count(word => word.Length > 10);
    }

    /*Using LINQ, implement the AreThereFewerOddThanEvenNumbers method
     which will check if in the collection of numbers there are fewer odd than even numbers.*/
    public class Exercise
    {
        public static bool AreThereFewerOddThanEvenNumbers(IEnumerable<int> numbers)
        {
            return numbers.Count(x => x % 2 == 0) > numbers.Count(x => x % 2 != 0);
        }
    }



    //TODO implement this method
    public static bool IsAnySequenceTooLong_Refactored(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
    {
        return numberSequences.Any(x => x.Count() > maxLength);
    }

    //do not modify this method
    public static bool IsAnySequenceTooLong(IEnumerable<IEnumerable<int>> numberSequences, int maxLength)
    {
        foreach (var numberSequence in numberSequences)
        {
            var count = 0;
            foreach (var number in numberSequence)
            {
                ++count;
            }
            if (count > maxLength)
            {
                return true;
            }
        }
        return false;
    }
    public class Exercise
    {
        public static bool IsAppointmentDateAvailable(DateTime date, IEnumerable<DateTime> existingAppointmentDates)
        {
            return !existingAppointmentDates.Contains(date);
        }
    }

}
