using System;

namespace backend.Database
{
    public static class ManipulandoDatas
    {
         public static int[] contarData(DateTime data)
        {
            int[] resp = new int[7];
            int comecoSemana = data.Day - (((int)data.DayOfWeek) - 1);
            if(comecoSemana <= 0)
            {
                Console.WriteLine("if");
                comecoSemana = DateTime.DaysInMonth(data.Year,data.Month - 1) + comecoSemana;
        
            }
            Console.WriteLine(comecoSemana);
            resp[0] = comecoSemana;
            Console.WriteLine(resp);
            for (int i = 1; i < 7; i++)
            {
                comecoSemana++;
                if (comecoSemana > DateTime.DaysInMonth(data.Year, data.Month - 1)) comecoSemana = 1;
                Console.WriteLine($"{i}/{comecoSemana}");
                resp[i] = comecoSemana;
            }
            return resp;
        }
    }
}