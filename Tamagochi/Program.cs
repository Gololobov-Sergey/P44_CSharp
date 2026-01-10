using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


// Задание.
// Разработать приложение «Тамагочи». Жизненный цикл персонажа — 1-2 минуты. Персонаж случайным образом выдаёт просьбы
// (но подряд одна и та же просьба не выдаётся). Просьбы могут быть следующие: Покормить, Погулять, Уложить спать, Полечить, Поиграть.
// Если просьбы не удовлетворяются трижды, персонаж «заболевает» и просит его полечить. В случае отказа — «умирает».
// Персонаж отображается в консольном окне при помощи псевдографики. Диалог с персонажем осуществляется посредством вызова
// метода Show() класса MessageBox из пространства имен System.Windows.Forms. За получением подробной информации по работе с
// этим методом обратитесь к Вашему преподавателю или в MSDN.

// Для решения этой задачи Вам понадобится класс Timer из пространства имен System.Timers, событие которого Elapsed, типа
// делегата ElapsedEventHandler, происходит через определенный интервал времени, который задан в свойстве Interval. Методы Start() и Stop()
// запускают и останавливают таймер, соответственно. Вы также можете захотеть делать паузы в работе приложения, в этом случае можно
// вызвать метод Sleep() класса Thread из пространства имен System.Threading, передав в него необходимое количество миллисекунд.

namespace Tamagochi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            Console.Read();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Hello", "Tamagochi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}
