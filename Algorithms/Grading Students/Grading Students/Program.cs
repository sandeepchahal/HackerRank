

int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

List<int> grades = new List<int>();

for (int i = 0; i < gradesCount; i++)
{
    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
    grades.Add(gradesItem);
}

List<int> result = gradingStudents(grades);

foreach (int grade in result)
{
    Console.WriteLine(grade);
}
static List<int> gradingStudents(List<int> grades)
{
    List<int> final = new List<int>();
    foreach (var item in grades)
    {
        if (item < 38)
        {
            final.Add(item);
        }
        else if (item == 100)
        {
            final.Add(item);
        }
        else
        {
            int nextMultipleOfFive = 0;
            if (char.GetNumericValue(item.ToString()[item.ToString().Length - 1]) < 5)
            {
                nextMultipleOfFive = Convert.ToInt32(item.ToString().Substring(0, item.ToString().Length - 1) + "5");
            }
            else
            {
                nextMultipleOfFive = Convert.ToInt32((char.GetNumericValue(item.ToString()[0]) + 1).ToString() + "0");
            }

            if (Math.Abs(nextMultipleOfFive - item) < 3)
            {
                final.Add(nextMultipleOfFive);
            }
            else
            {
                final.Add(item);
            }
        }
    }
    return final;
}




