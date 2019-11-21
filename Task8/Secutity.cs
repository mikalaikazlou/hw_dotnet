using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Security
    {
        private Suitcase _suitcase;
        public Security(Suitcase suitcase)
        {
            _suitcase = suitcase;
        }

        public void SecuritySuitcase()
        {
            if (_suitcase.Thing1 is Gun || _suitcase.Thing2 is Gun || _suitcase.Thing3 is Gun || _suitcase.Thing4 is Gun || _suitcase.Thing5 is Gun)
            {
                Console.WriteLine("\nУ Вас обнаружены запрещенные для провоза вещи, Вы арестованы!");
            }
            else
            {
                Console.WriteLine("\nПроходите на паспортный контроль!");
            }
        }
    }
}