using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    /*
     Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.
     Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках. 
         */
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] eng = new string[5];
        private string[] ua = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; eng[0] = "book"; ua[0] = "книга";
            key[1] = "ручка"; eng[1] = "pen"; ua[1] = "ручка";
            key[2] = "солнце"; eng[2] = "sun"; ua[2] = "сонце";
            key[3] = "яблоко"; eng[3] = "apple"; ua[3] = "яблуко";
            key[4] = "стол"; eng[4] = "table"; ua[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return key[i] + " - " + eng[i] + " - " + ua[i];
                    if (eng[i] == index)
                        return eng[i] + " - " + key[i] + " - " + ua[i];
                    if (ua[i] == index)
                        return ua[i] + " - " + eng[i] + " - " + key[i];
                }
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + eng[index] + " - " + ua[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
