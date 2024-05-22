using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibrary1;

namespace Kursovaya
{
    internal class SQLconnection
    {
        ClassLibrary1.DLLClass1 ikio = new DLLClass1();
        
        //SqlConnection SqlCon = new SqlConnection(@"Data Source=WIN-0HI9614CUFK;Initial Catalog=Barbershop;Integrated Security=True");
        public void Open()
        {
            if (ikio.Con())//проверка на активность базы данных
            {
                ikio.name = @"Data Source=WIN-0HI9614CUFK;Initial Catalog=Barbershop;Integrated Security=True"; // изменяет имя базы данных
                ikio.Start(); // создает переменную SQLConnection
                ikio.ConectionSQL(); // подключается к базе данных
            }
        }
        public void Close()
        {
            if (ikio.Con())
            {
                ikio.DisConectionSQL();
            }

            ikio.Start_Command("");//ввести запрос
            List<List<string>> list = new List<List<string>>();
            list = ikio.Read_Table();//возвращение данных запроса

            ikio.Start_Command("");//ввести запрос
            ikio.Read_Table(true);//запрос не возвращает значения
        }

        
    }
}
