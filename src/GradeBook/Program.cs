﻿// See https://aka.ms/new-console-template for more class Book
using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        var book = new Book("Scott's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.1);
        book.AddGrade(77.5);

        var stats = book.GetStatistics();
        Console.WriteLine($"The lowest grade is {stats.look}");
        Console.WriteLine($"The highest grade is {stats.High}");
        Console.WriteLine($"The average grade is {stats.Average:N1}");
        Console.ReadLine();
    }
}



