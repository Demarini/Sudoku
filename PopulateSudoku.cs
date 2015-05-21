using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuPuzzle
{

    public class PopulateSudoku
    {
        Random r = new Random();
        bool swapped;
        string[,] finalPuzzle;
        Dictionary<string, List<string>> regionsCoordinates;
        List<int[,]> regionsList;
        int sameSolutionFound = 0;
        int numToFirst = 0;
        int totalAttempts = 0;
        
        public PopulateSudoku()
        {
            
        }
        public bool PopulateRegion(int[,] currentRegion, int[,] rowRegion1, int[,] rowRegion2, int[,] colRegion1, int[,] colRegion2)
        {
            ValidateSudoku vS = new ValidateSudoku();
            int attempts = 0;
            bool isValid = false;
            for (int i = 0; i < currentRegion.GetLength(0); i++)
            {
                for (int j = 0; j < currentRegion.GetLength(1); j++)
                {
                    int iterations = 0;
                    HashSet<int> validSquareNum = new HashSet<int>();
                    while (!isValid)
                    {

                        int rand = r.Next(1, 10);
                        if (!vS.CheckSquare(currentRegion, rand))
                        {
                            currentRegion[i, j] = 0;
                            isValid = false;
                        }
                        else
                        {
                            validSquareNum.Add(rand);
                            if (!vS.CheckColumn(colRegion1, colRegion2, rand, j))
                            {
                                currentRegion[i, j] = 0;
                                isValid = false;
                            }
                            else
                            {
                                if (!vS.CheckRow(rowRegion1, rowRegion2, rand, i))
                                {
                                    currentRegion[i, j] = 0;
                                    isValid = false;
                                }
                                else
                                {
                                    currentRegion[i, j] = rand;
                                    Console.Write(rand);
                                    isValid = true;
                                }
                            }
                        }
                        iterations++;
                        if (iterations > 1000 && i == 2 && j == 2)
                        {
                            int totalSum = 0;
                            int finalNum = 0;
                            switch (attempts)
                            {
                                case 0:
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 1:
                                    originalNum = currentRegion[i - 2, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 2:
                                    originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 3:
                                    originalNum = currentRegion[i, j - 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 4:
                                    originalNum = currentRegion[i - 1, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 5:
                                    originalNum = currentRegion[i - 2, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 6:
                                    originalNum = currentRegion[i - 2, j - 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j - 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 7:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 2 && j == 1)
                        {
                            int totalSum = 0;
                            switch (attempts)
                            {
                                case 0:
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 1:
                                    originalNum = currentRegion[i - 2, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 2:
                                    originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 3:
                                    originalNum = currentRegion[i - 1, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 4:
                                    originalNum = currentRegion[i - 2, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 5:
                                    originalNum = currentRegion[i - 1, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 6:
                                    originalNum = currentRegion[i - 2, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 7:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 2 && j == 0)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 1://i - 2, j
                                    originalNum = currentRegion[i - 2, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    iterations = 0;
                                    break;
                                case 2://i - 1, j + 1
                                    originalNum = currentRegion[i - 1, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 3://i - 2, j + 1
                                    originalNum = currentRegion[i - 2, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 4://i - 1, j + 2
                                    originalNum = currentRegion[i - 1, j + 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 5://i - 2, j + 2
                                    originalNum = currentRegion[i - 2, j + 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 2, j + 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 6:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 1 && j == 2)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 1://i - 1, j - 1
                                    originalNum = currentRegion[i - 1, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 2://i - 1, j - 2
                                    originalNum = currentRegion[i - 1, j - 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j - 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 3://i, j - 1
                                    originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 4://i, j - 2
                                    originalNum = currentRegion[i, j - 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 5:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 1 && j == 1)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 1://i - 1, j - 1
                                    originalNum = currentRegion[i - 1, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 2://i - 1, j + 1
                                    originalNum = currentRegion[i - 1, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 3://i, j - 1
                                    originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 4:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 1 && j == 0)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i - 1, j];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 1://i - 1, j - 1
                                    originalNum = currentRegion[i - 1, j + 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 2://i - 1, j + 1
                                    originalNum = currentRegion[i - 1, j + 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i - 1, j + 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 3:
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 0 && j == 2)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 1://i - 1, j - 1
                                    originalNum = currentRegion[i, j - 2];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 2, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 2://i - 1, j + 1
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 0 && j == 1)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    int originalNum = currentRegion[i, j - 1];
                                    swapped = vS.TrySwapValues(originalNum, currentRegion, i, j - 1, validSquareNum, i, j, colRegion1, colRegion2, rowRegion1, rowRegion2);
                                    break;
                                case 1://i - 1, j - 1
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }
                        else if (iterations > 1000 && i == 0 && j == 0)
                        {
                            switch (attempts)
                            {
                                case 0://i - 1, j
                                    string fuck; return false;
                                    break;
                            }
                            attempts++;
                            if (swapped)
                            {
                                isValid = true; Console.Write(currentRegion[i, j]);
                            }
                        }

                    }
                    isValid = false;
                }
                Console.WriteLine();
            }
            return true;
        }
        public List<int[,]> ReturnRegionsList(string[,] finalPuzzle)
        {
            List<int[,]> regionsList = new List<int[,]>();
            int addRow = 0;
            int addCol = 0;
            for (int i = 0; i < 9; i++)
            {
                regionsList.Add(new int[3, 3]);
                for (int j = addRow; j < 3 + addRow; j++)
                {

                    for (int k = addCol; k < 3 + addCol; k++)
                    {
                        int temp;
                        if (finalPuzzle[j, k] == "-")
                        {
                            temp = 0;
                        }
                        else
                        {
                            temp = int.Parse(finalPuzzle[j, k]);
                        }
                        if (temp != 0)
                        {
                            regionsList[i][j - addRow, k - addCol] = temp;
                        }
                        else
                        {
                            //fuckoff
                        }

                    }
                }

                addCol += 3;
                if (addCol == 9)
                {
                    addRow += 3;
                    addCol = 0;
                }
            }
            int[,] finalTest = CombineRegions(regionsList);

            return regionsList;
        }

        public int[,] CombineRegions(List<int[,]> regionsList)
        {
            int[,] finalRegion = new int[9, 9];
            for (int i = 0; i < regionsList.Count(); i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j, k] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 1:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j, k + 3] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 2:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j, k + 6] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 3:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 3, k] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 4:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 3, k + 3] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 5:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 3, k + 6] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 6:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 6, k] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 7:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 6, k + 3] = regionsList[i][j, k];
                            }
                        }
                        break;
                    case 8:
                        for (int j = 0; j < regionsList[i].GetLength(0); j++)
                        {
                            for (int k = 0; k < regionsList[i].GetLength(1); k++)
                            {
                                finalRegion[j + 6, k + 6] = regionsList[i][j, k];
                            }
                        }
                        break;
                }
            }
            return finalRegion;
        }

        public Dictionary<string, List<string>> GetRegionCoordinates(string[,] finalPuzzle)
        {
            List<string> regionsList = new List<string>();
            Dictionary<string, List<string>> returnDictionary = new Dictionary<string, List<string>>();
            int addRow = 0;
            int addCol = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = addRow; j < 3 + addRow; j++)
                {
                    for (int k = addCol; k < 3 + addCol; k++)
                    {
                        regionsList.Add((j).ToString() + "," + (k).ToString());
                    }
                }
                addCol += 3;
                if (addCol == 9)
                {
                    addRow += 3;
                    addCol = 0;
                }
                returnDictionary.Add(i.ToString(), regionsList);
                regionsList = new List<string>();
            }

            return returnDictionary;
        }
        public List<string> AddUntouchableValues(string[,] finalPuzzle)
        {
            List<string> untouchables = new List<string>();
            for (int i = 0; i < finalPuzzle.GetLength(0); i++)
            {
                for (int j = 0; j < finalPuzzle.GetLength(1); j++)
                {
                    if (finalPuzzle[i, j] != "-")
                    {
                        untouchables.Add(i.ToString() + "," + j.ToString());
                    }
                }
            }
            return untouchables;
        }
        public int[,] ZeroFinalRegion(string[,] finalPuzzle)
        {
            int[,] finalRegion = new int[9, 9];
            for (int i = 0; i < finalPuzzle.GetLength(0); i++)
            {
                for (int j = 0; j < finalPuzzle.GetLength(1); j++)
                {
                    if (finalPuzzle[i, j] != "-")
                    {
                        finalRegion[i, j] = int.Parse(finalPuzzle[i, j]);
                    }
                }
            }
            return finalRegion;
        }
        public string[,] CreatePuzzle(string[,] finalRegion)
        {
            int numberRemoved = 0;
            Random r = new Random();
            int r1 = 0;
            int r2 = 0;

            while (numberRemoved < 29)
            {
                r1 = r.Next(finalRegion.GetLength(0));
                r2 = r.Next(finalRegion.GetLength(1));
                if (finalRegion[r1, r2] != "-")
                {
                    finalRegion[r1, r2] = "-";
                    finalRegion[8 - r1, 8 - r2] = "-";
                    numberRemoved++;
                }
                else
                {

                }
            }
            //for (int i = 0; i < finalRegion.GetLength(0); i++)
            //{
            //    for (int j = 0; j < finalRegion.GetLength(1); j++)
            //    {
            //        if (r.Next(14) < 7)
            //        {
            //            finalRegion[i, j] = "-";
            //            finalRegion[8 - i, 8 - j] = "-";
            //        }
            //    }
            //}
            return finalRegion;
        }
    }
}
