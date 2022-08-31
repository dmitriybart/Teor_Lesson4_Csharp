﻿void PrintImage (int[,] image)
{
    var random = new Random();
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) Console.Write($"");
            else Console.Write($"+");
        }
    }
    Console.WriteLine();
}

PrintImage()