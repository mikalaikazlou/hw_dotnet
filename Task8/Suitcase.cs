using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Suitcase
    {
        Thing _things1;
        Thing _things2;
        Thing _things3;
        Thing _things4;
        Thing _things5;

        public Suitcase(Thing thing1)
        {
            _things1 = thing1;
        }

        public Suitcase(Thing thing1, Thing thing2)
        {
            _things1 = thing1;
            _things2 = thing2;
        }

        public Suitcase(Thing thing1, Thing thing2, Thing thing3)
        {
            _things1 = thing1;
            _things2 = thing2;
            _things3 = thing3;
        }

        public Suitcase(Thing thing1, Thing thing2, Thing thing3, Thing thing4)
        {
            _things1 = thing1;
            _things2 = thing2;
            _things3 = thing3;
            _things4 = thing4;
        }

        public Suitcase(Thing thing1, Thing thing2, Thing thing3, Thing thing4, Thing thing5)
        {
            _things1 = thing1;
            _things2 = thing2;
            _things3 = thing3;
            _things4 = thing4;
            _things5 = thing5;
        }

        public void SuitcaseThings()
        {
            Console.WriteLine($"\n{_things1}, {_things2}, {_things3}, {_things4}, {_things5}");
        }

        public Thing Thing1
        {
            get { return _things1; }
        }

        public Thing Thing2
        {
            get { return _things2; }
        }

        public Thing Thing3
        {
            get { return _things3; }
        }

        public Thing Thing4
        {
            get { return _things4; }
        }

        public Thing Thing5
        {
            get { return _things5; }
        }
    }
}