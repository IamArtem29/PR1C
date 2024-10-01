namespace PR5_DLL
{
    public class Transfer
    {
        public static String num2Str(int num)
        {
            String[] strings = {
                 "Ноль",
                 "Один",
                 "Два",
                 "Три",
                 "Четыре",
                 "Пять",
                 "Шесть",
                 "Семь",
                 "Восемь",
                 "Девять"
             };
            return strings[num % 10];
        }
    }
}
