using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TN, TA>
    {
        TN[] names;
        TA[] ages;

        public MyDictionary()
        {
            names = new TN[0];
            ages = new TA[0];
        }

        public void Add(TN name, TA age)
        {
            TN[] tempArrayName = names;
            TA[] tempArrayAge = ages;

            names = new TN[tempArrayName.Length + 1];

            for (int i = 0; i < tempArrayName.Length; i++)
            {
                names[i] = tempArrayName[i];
            }

            names[names.Length - 1] = name;

            ages = new TA[tempArrayAge.Length + 1];

            for (int i = 0; i < tempArrayAge.Length; i++)
            {
                ages[i] = tempArrayAge[i];
            }

            ages[ages.Length - 1] = age;

            Console.WriteLine("Name : " + name + " \n " + "Age : " + age);

        }
    }
}
