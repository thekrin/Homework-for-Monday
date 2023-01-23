using System;

namespace Homework_for_Monday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Verilmiş string dəyərindəki ilk sözü tap
            //Console.WriteLine("Bir yazi daxil etmeyeniz xais olunur :");
            //string sentence = Console.ReadLine();
            //var result = FindLetter(sentence);
            //Console.WriteLine(result);
            #endregion

            #region Task2
            //Verilmiş string dəyərindəki sözlərin sayını tapan metod
            //Console.WriteLine("Bir cumle daxil edin");
            //string sentence = Console.ReadLine();
            //var result = CountofWords(sentence);
            //Console.WriteLine(result);
            #endregion

            #region Task3 
            //Verilmiş ədədlər siyahısından içində yalnız müsbət ədədlər qalan yeni bir array düzəldən metod.
            //int[] mixNumbers = { 12,-3,-5,56,77,-2,-11,13 };
            //var result3 = PositiveNumbers(mixNumbers);
            //Console.WriteLine("Positive Digits : ");
            //foreach (var number in result3)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Task5 
            //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
            //Console.WriteLine("Yazi daxil edin : ");
            //string sentence6 = Console.ReadLine();
            //var result = NoSpaceFirstLetterIndex(sentence6);
            //Console.WriteLine(result);
            #endregion

            #region Task6 
            //Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
            //Console.WriteLine("Yazi daxil edin : ");
            //string sentence = Console.ReadLine();
            //Console.WriteLine(WithoutSpaceInLeftWord(sentence));
            #endregion

        }

        #region Task1
        //static string FindLetter(string word)
        //{
        //    string NewStr = "";
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] != ' ')
        //        {
        //            NewStr += word[i];
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    return NewStr;
        //}
        #endregion

        #region Task2
        //static int CountofWords(string str)
        //{
        //    int count = 1;
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
        #endregion

        #region Task3
        //static int[] PositiveNumbers(int[] arr)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            count++;
        //        }
        //    }
        //    int[] positiveArr = new int[count];
        //    int counter = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > 0)
        //        {
        //            positiveArr[counter] = arr[i];
        //            counter++;
        //        }
        //    }
        //    return positiveArr;

        //}
        #endregion

        #region Task5
        static int NoSpaceFirstLetterIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    return i;
                    break;
                }
            }
            return -1;

        }

        #endregion

        #region Task6
        //static string WithoutSpaceInLeftWord(string str)
        //{
        //    int count = 0;
        //    string newStr = "";
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        if (str[i] == ' ')
        //        {
        //            count++;
        //        }
        //        if (i >= count)
        //        {
        //            newStr += str[i];
        //        }
        //    }
        //    return newStr;

        //}
        #endregion





    }






}