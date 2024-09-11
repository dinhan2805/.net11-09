using System;
using System.Linq;

namespace ExerciseCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gọi các phương thức
       //     bai1();
       //     bai2();
       //     bai3();
          bai4();
       //     bai5();
       //     bai6();
        }

        // Bài 1: Tạo mảng số nguyên và tính tổng
        public static void bai1()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = array.Sum();
            Console.WriteLine("Tong cac phan tu trong mang la: " + sum);
        }

        // Bài 2: Đếm số lượng ký tự trong chuỗi
        public static void bai2()
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            int count = str.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));
            Console.WriteLine("So luong ky tu trong chuoi la: " + count);
        }

        // Bài 3: Tìm phần tử lớn nhất trong mảng
        public static void bai3()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int max = array.Max();
            Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
        }

        // Bài 4: Đảo ngược chuỗi
        public static void bai4()
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            Console.WriteLine("Chuoi dao nguoc la: " + reversedStr);
        }

        // Bài 5: Kiểm tra mảng đối xứng
        public static void bai5()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            bool isPalindrome = true;
            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine("Mang co phai la mang doi xung: " + isPalindrome);
        }

        // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
        public static void bai6()
        {
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            Console.Write("Nhap ky tu can dem: ");
            char specificChar = Console.ReadLine()[0];
            int count = str.Count(c => c == specificChar);
            Console.WriteLine("So lan xuat hien cua ky tu '" + specificChar + "' la: " + count);
        }
    }
}
