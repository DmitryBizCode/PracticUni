using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUni
{
    internal class ArrayOne
    {
        public bool error = false; // вказує на наявність помилки в класі

        string[] a; 
        int length = 5; 

        public int Length // отримання та встановлення довжини масиву
        {
            get => this.length;
            set => this.length = value;
        }

        public string this[int i] // Індексатор для доступу до елементів масиву за індексом
        {
            get
            {
                if (0 <= i && i < this.length)
                    return a[i];
                else
                {
                    error = true; 
                    return ""; 
                }
            }
            set
            {
                if (0 <= i && i < length)
                    a[i] = value;
                else
                    error = true; // Встановлює помилку
            }
        }

        public ArrayOne() => a = new string[length]; // Конструктор за замовчуванням

        public ArrayOne(string[] mas) => a = mas; // Конструктор зразу з переданого масиву

        public ArrayOne(int size) // Конструктор рандомний по розміру масиву
        {
            this.length = size;
            a = new string[length]; 

            Random random = new Random(); 

            for (int i = 0; i < length; i++)
                a[i] = GenerateRandomString(random); 
        }

        private string GenerateRandomString(Random random)
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[8];
            for (int i = 0; i < 8; i++)            
                result[i] = characters[random.Next(characters.Length)]; // Генерує рядок за допомогою переданого генератора Random
            return new string(result); 
        }
        public void Reverse()
        {
            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }

            string[] b = new string[length];
            for (int i = length - 1, j = 0; i >= 0 && j < length; i--, j++)
            {
                b[i] = a[j];
            }
            this.a = b;
        }
    }
}
