using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Ticket
    {
        const string gotoCity = "Berlin";
        int numberFlight;
        int numberTicket;
        int passpControl;

        public int NumberFlight
        {
            get => numberFlight; set => numberFlight = value;
        }

        public int NumberTicket
        {
            get => numberTicket; set => numberTicket = value;
        }

        public int PasspControl
        {
            get => passpControl; set => passpControl = value;
        }

        public void TicketGate()
        {
            Console.WriteLine($"\nВаш номер рейса {numberFlight} до {gotoCity}, проходите на досмотр и далее на паспортный контроль окно № {passpControl}");
        }
    }
}