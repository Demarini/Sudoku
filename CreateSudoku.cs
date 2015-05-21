using SudokuPuzzle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuPuzzle
{
    public class CreateSudoku
    {

        public string[,] CreateSudokuPuzzle()
        {
            PopulateSudoku pS = new PopulateSudoku();
            ValidateSudoku vS = new ValidateSudoku();
            Random r = new Random();
            bool swapped;
            string[,] finalPuzzle = null ;
            Dictionary<string, List<string>> regionsCoordinates = new Dictionary<string,List<string>>();
            List<int[,]> regionsList = new List<int[,]>();
            int sameSolutionFound = 0;
            int numToFirst = 0;
            int totalAttempts = 0;

            int[,] region1 = new int[3, 3];
            int[,] region2 = new int[3, 3];
            int[,] region3 = new int[3, 3];
            int[,] region4 = new int[3, 3];
            int[,] region5 = new int[3, 3];
            int[,] region6 = new int[3, 3];
            int[,] region7 = new int[3, 3];
            int[,] region8 = new int[3, 3];
            int[,] region9 = new int[3, 3];
            int[,] finalRegion = new int[9, 9];
            string[,] finalRegionString = new string[9, 9];
            List<int[,]> regionList = new List<int[,]>();
            bool completed = false;
            int rounds = 0;
            HashSet<int[,]> uniqueSolutions = new HashSet<int[,]>();
            bool isUnique = false;
            while (!isUnique)
            {
                totalAttempts++;
                while (!completed)
                {
                    rounds++;
                    region1 = new int[3, 3];
                    region2 = new int[3, 3];
                    region3 = new int[3, 3];
                    region4 = new int[3, 3];
                    region5 = new int[3, 3];
                    region6 = new int[3, 3];
                    region7 = new int[3, 3];
                    region8 = new int[3, 3];
                    region9 = new int[3, 3];

                    completed = pS.PopulateRegion(region1, region2, region3, region4, region7);
                    Console.WriteLine("\n");
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region2, region1, region3, region5, region8);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region3, region1, region2, region6, region9);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region4, region5, region6, region1, region7);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region5, region4, region6, region2, region8);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region6, region5, region4, region3, region9);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region7, region8, region9, region1, region4);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region8, region7, region9, region2, region5);
                        Console.WriteLine("\n");
                    }
                    if (completed)
                    {
                        completed = pS.PopulateRegion(region9, region7, region8, region3, region6);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine();
                    regionList.Clear();
                    regionList.Add(region1);
                    regionList.Add(region2);
                    regionList.Add(region3);
                    regionList.Add(region4);
                    regionList.Add(region5);
                    regionList.Add(region6);
                    regionList.Add(region7);
                    regionList.Add(region8);
                    regionList.Add(region9);
                    for (int i = 0; i < finalRegion.GetLength(0); i++)
                    {
                        for (int j = 0; j < finalRegion.GetLength(1); j++)
                        {
                            if (finalRegion[i, j] == 0)
                            {
                                finalRegionString[i, j] = "-";
                            }

                            Console.Write(finalRegion[i, j]);
                        }
                        Console.WriteLine();
                    }
                    //for (int i = 0; i < 1000; i++)
                    //{
                    //    int[,] temp = SolvePuzzle(finalRegionString);
                    //    if (temp != null)
                    //    {
                    //        break;
                    //    }
                    //}

                    if (completed)
                    {
                        finalRegion = pS.CombineRegions(regionList);
                        for (int i = 0; i < finalRegion.GetLength(0); i++)
                        {
                            for (int j = 0; j < finalRegion.GetLength(1); j++)
                            {
                                finalRegionString[i, j] = finalRegion[i, j].ToString();
                                Console.Write(finalRegion[i, j]);
                            }
                            Console.WriteLine();
                        }
                        regionsCoordinates = pS.GetRegionCoordinates(finalRegionString);
                        regionsList = pS.ReturnRegionsList(finalRegionString);
                        if (!vS.CheckFinalTable(finalRegion, regionsCoordinates, regionsList))
                        {
                            completed = false;
                        }
                    }
                }


                for (int i = 0; i < finalRegion.GetLength(0); i++)
                {
                    for (int j = 0; j < finalRegion.GetLength(1); j++)
                    {
                        finalRegionString[i, j] = finalRegion[i, j].ToString();
                        Console.Write(finalRegion[i, j]);
                    }
                    Console.WriteLine();
                }
                finalPuzzle = pS.CreatePuzzle(finalRegionString);
                for (int i = 0; i < finalPuzzle.GetLength(0); i++)
                {
                    for (int j = 0; j < finalPuzzle.GetLength(1); j++)
                    {
                        Console.Write(finalPuzzle[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n" + rounds);
                //Console.WriteLine(CheckFinalTable(finalRegion));

                uniqueSolutions.Add(finalRegion);
                for (int i = 0; i < 100; i++)
                {
                    int test = totalAttempts;
                    int[,] temp = vS.SolvePuzzle(finalPuzzle);
                    if (temp != null)
                    {
                        if (uniqueSolutions.Count > 0)
                        {
                            if (!vS.CheckSameSolution(uniqueSolutions.ElementAt(0), temp))
                            {
                                for (int l = 0; l < temp.GetLength(0); l++)
                                {

                                    for (int k = 0; k < temp.GetLength(1); k++)
                                    {
                                        Console.Write(temp[l, k]);
                                    }
                                    Console.WriteLine();
                                }
                                uniqueSolutions.Clear();
                                numToFirst = 0;
                                sameSolutionFound = 0;
                                break;
                            }
                            else
                            {
                                sameSolutionFound++;
                            }
                        }
                        else
                        {
                            uniqueSolutions.Add(temp);
                            numToFirst = i;
                            for (int l = 0; l < temp.GetLength(0); l++)
                            {

                                for (int k = 0; k < temp.GetLength(1); k++)
                                {
                                    Console.Write(temp[l, k]);
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            if (uniqueSolutions.Count > 1)
                            {
                                break;
                            }
                        }
                    }
                }
                if (uniqueSolutions.Count == 1)
                {
                    isUnique = true;
                }
                else
                {
                    uniqueSolutions.Clear();
                    completed = false;
                }
            }
            bool checkFinalTable = vS.CheckFinalTable(finalRegion, regionsCoordinates, regionsList);
           return finalPuzzle;
        }
    }
}
