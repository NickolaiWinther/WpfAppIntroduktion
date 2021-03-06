﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAppIntroduktion.BIZ
{
    class ClassBIZ
    {
        #region constructor
        public ClassBIZ()
        {

        }
        #endregion

        Random random = new Random();

        public void Number4711(ListBox listBox)
        {
            for (int i = 4711; i <= 4736; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        public void RandomNumbers(ListBox listBox)
        {
            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add(random.Next(100_000, 1_000_001).ToString());
            }
        }

        public void OrderedNumbers(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }
            numbers.Sort();
            foreach (int number in numbers)
            {
                listBox.Items.Add(number);
            }
        }

        public void UnorderedAndOrdered(ListBox listBox)
        {
            List<int> randomNumbers = new List<int>();
            List<int> orderedNumbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int number = random.Next(100_000, 1_000_001);
                randomNumbers.Add(number);
                orderedNumbers.Add(number);
            }

            orderedNumbers.Sort();

            for (int i = 0; i < 25; i++)
            {
                listBox.Items.Add($"Før: {randomNumbers[i]} efter: {orderedNumbers[i]}");
            }
        }

        public void AverageNumber(ListBox listBox)
        {
            int averagenumber = 0;
            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                listBox.Items.Add(randomNumber.ToString());

                averagenumber += randomNumber;
            }
            averagenumber /= listBox.Items.Count;

            listBox.Items.Add(string.Empty);
            listBox.Items.Add($"Gennemsnittet: {averagenumber}");
        }

        public void Delopgave17(ListBox listBox)
        {
            int averageNumber = 0;
            List<int> numbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                numbers.Add(randomNumber);

                averageNumber += randomNumber;
            }
            averageNumber = (int)numbers.Average();

            numbers.Sort();

            foreach (int number in numbers)
            {
                listBox.Items.Add($"{number} - {averageNumber} = {number - averageNumber}");
            }
        }


        public List<string> Delopgave18()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomNumber = random.Next(100_000, 1_000_001);
                numbers.Add(randomNumber);
            }
            int averageNumber = (int)numbers.Average();

            numbers.Sort();

            List<string> returnString = new List<string>();

            foreach (int number in numbers)
            {
                returnString.Add($"{number} - {averageNumber} = {number - averageNumber}");
            }
            return returnString;
        }

        public void Delopgave19(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }
            int averageNumber = (int)numbers.Average();

            numbers.Sort();

            foreach (int number in numbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = $"{number} - {averageNumber} = {number-averageNumber}";

                if (number % 2 == 1)
                    listBoxItem.Background = Brushes.AliceBlue;
                else
                    listBoxItem.Background = Brushes.HotPink;

                listBox.Items.Add(listBoxItem);
            }
        }

        public void Delopgave110(ListBox listBox)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(random.Next(100_000, 1_000_001));
            }
            int averageNumber = (int)numbers.Average();

            numbers.Sort();

            List<ListBoxItem> listItems = new List<ListBoxItem>();

            foreach (int number in numbers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = $"{number} - {averageNumber} = {number - averageNumber}";

                if (number % 2 == 1)
                    listBoxItem.Background = Brushes.AliceBlue;
                else
                    listBoxItem.Background = Brushes.HotPink;

                listItems.Add(listBoxItem);
            }
            listBox.ItemsSource = listItems;
        }
    }
}
