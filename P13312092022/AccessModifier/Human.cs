using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Human
    {
        string _name;
        public  string SurName;

        
        private byte _age;

        //Property - Class Member - For New Encapsulate
        public byte Age 
        {
            //Accessor
            set
            {
                if (value < 15 || value > 50)
                {
                    Console.WriteLine("Yas 15 ve 50 arasi Olmalidi");
                    return;
                }

                _age = value;
            }
            protected get
            {
                return _age;
            }
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();

                if (value.Length >= 2)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (!char.IsLetter(value[i]))
                        {
                            Console.WriteLine("Duzgun Name Deyeri Daxil Et");
                            return;
                        }
                    }

                    _name = value;
                }

            }
        }

        public Human(string name)
        {
            SurName = "Mammadov";
            #region Old Encapsulate
            //SetName(name);
            #endregion
        }

        #region Old encapsulate
        //public void SetAge(byte age)
        //{
        //    if (age < 15 || age > 50)
        //    {
        //        Console.WriteLine("Yas 15 ve 50 arasi Olmalidi");
        //        return;
        //    }

        //    _age = age;
        //}

        //public byte GetAge()
        //{
        //    return _age;
        //}

        //public void SetName(string name)
        //{
        //    name = name.Trim();

        //    if (name.Length >= 2)
        //    {
        //        for (int i = 0; i < name.Length; i++)
        //        {
        //            if (!char.IsLetter(name[i]))
        //            {
        //                Console.WriteLine("Duzgun Name Deyeri Daxil Et");
        //                return;
        //            }
        //        }
        //    }

        //    _name = name;
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        #endregion

        public void ShowInfo()
        {
            Console.WriteLine($"{_name} {SurName}");
        }
    }
}
