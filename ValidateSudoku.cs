using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuPuzzle
{
    public class ValidateSudoku
    {
        Random r = new Random();
        
        public ValidateSudoku()
        {
             
        }
        public int[,] SolvePuzzle(string[,] finalPuzzle)
        {
            PopulateSudoku p = new PopulateSudoku();
            int[,] finalRegion = p.ZeroFinalRegion(finalPuzzle);
            List<int[,]> regionsList = p.ReturnRegionsList(finalPuzzle);
            List<string> untouchables = p.AddUntouchableValues(finalPuzzle);
            Dictionary<string, List<string>> regionsCoordinates = p.GetRegionCoordinates(finalPuzzle);
            bool isValid = false;
            for (int i = 0; i < finalRegion.GetLength(0); i++)
            {
                for (int j = 0; j < finalRegion.GetLength(1); j++)
                {
                    string coordVal = i.ToString() + "," + j.ToString();
                    if (!untouchables.Contains(coordVal))
                    {
                        int iterations = 0;
                        HashSet<int> validSquareNum = new HashSet<int>();
                        while (!isValid)
                        {
                            int rand = r.Next(1, 10);
                            string value = i.ToString() + "," + j.ToString();
                            int regionNum = 0;
                            for (int k = 0; k < regionsCoordinates.Keys.Count(); k++)
                            {
                                if (regionsCoordinates[k.ToString()].Contains(value))
                                {
                                    regionNum = k;
                                    break;
                                }
                            }

                            if (!CheckSquare(regionsList[regionNum], rand))
                            {
                                finalRegion[i, j] = 0;
                                isValid = false;
                            }
                            else
                            {
                                validSquareNum.Add(rand);
                                finalRegion[i, j] = rand;
                                if (!CheckFinalColumn(j, i, j, finalRegion))
                                {
                                    finalRegion[i, j] = 0;
                                    isValid = false;
                                }
                                else
                                {
                                    if (!CheckFinalRow(j, i, j, finalRegion))
                                    {
                                        finalRegion[i, j] = 0;
                                        isValid = false;
                                    }
                                    else
                                    {
                                        finalRegion[i, j] = rand;
                                        isValid = true;
                                    }
                                }
                            }
                            iterations++;
                            if (iterations > 1000)
                            {
                                int row = i;
                                int col = j;
                                for (int k = row; i >= 0; k--)
                                {
                                    if (k < 0)
                                    {
                                        k = 0;
                                    }
                                    for (int l = col; l >= 0; l--)
                                    {
                                        string value2 = k.ToString() + "," + l.ToString();
                                        if (!untouchables.Contains(value2))
                                        {
                                            if (TrySwapValuesFinal(finalRegion, k, l, validSquareNum, i, j, finalRegion))
                                            {
                                                isValid = true;
                                                iterations = 0;
                                                break;
                                            }
                                        }
                                        else
                                        {

                                        }


                                    }
                                    if (k != 0 || isValid)
                                    {
                                        col = 8;
                                    }
                                    else
                                    {
                                        string test222 = "wefucked";
                                        finalRegion = null;
                                        return finalRegion;
                                    }
                                    if (isValid)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        isValid = false;
                    }
                    else
                    {
                        string heyitworked;
                    }
                }
            }
            //for (int i = 0; i < finalRegion.GetLength(0); i++)
            //{
            //    for (int j = 0; j < finalRegion.GetLength(1); j++)
            //    {
            //        Console.Write(finalRegion[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            bool test = CheckFinalTable(finalRegion, regionsCoordinates, regionsList);
            if (!test)
            {
                finalRegion = null; return finalRegion;
            }
            return finalRegion;
        }

        public bool TrySwapValues(int originalNum, int[,] currentRegion, int swappedI, int swappedJ, HashSet<int> validSquareNum, int i, int j, int[,] colRegion1, int[,] colRegion2, int[,] rowRegion1, int[,] rowRegion2)
        {
            originalNum = currentRegion[swappedI, swappedJ];
            foreach (int num in validSquareNum)
            {
                currentRegion[swappedI, swappedJ] = num;
                if (!CheckOneValue(colRegion1, colRegion2, rowRegion1, rowRegion2, num, swappedI, swappedJ))
                {
                    currentRegion[swappedI, swappedJ] = originalNum;
                    return false;
                }
                else
                {
                    currentRegion[i, j] = originalNum;
                    if (!CheckOneValue(colRegion1, colRegion2, rowRegion1, rowRegion2, originalNum, i, j))
                    {
                        currentRegion[swappedI, swappedJ] = originalNum;
                        currentRegion[i, j] = 0;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }
        public bool CheckSquare(int[,] region, int addNum)
        {
            for (int i = 0; i < region.GetLength(0); i++)
            {
                for (int j = 0; j < region.GetLength(1); j++)
                {
                    if (region[i, j] == addNum)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CheckColumn(int[,] columnRegion1, int[,] columnRegion2, int addNum, int colNum)
        {
            for (int i = 0; i < columnRegion1.GetLength(0); i++)
            {
                if (columnRegion1[i, colNum] == addNum)
                {
                    return false;
                }
            }
            for (int i = 0; i < columnRegion2.GetLength(0); i++)
            {
                if (columnRegion2[i, colNum] == addNum)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRow(int[,] rowRegion1, int[,] rowRegion2, int addNum, int rowNum)
        {
            for (int i = 0; i < rowRegion1.GetLength(1); i++)
            {
                if (rowRegion1[rowNum, i] == addNum)
                {
                    return false;
                }
            }
            for (int i = 0; i < rowRegion2.GetLength(1); i++)
            {
                if (rowRegion2[rowNum, i] == addNum)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckOneValue(int[,] colRegion1, int[,] colRegion2, int[,] rowRegion1, int[,] rowRegion2, int num, int i, int j)
        {
            if (!CheckColumn(colRegion1, colRegion2, num, j))
            {
                return false;
            }
            else
            {
                if (!CheckRow(rowRegion1, rowRegion2, num, i))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool TrySwapValuesFinal(int[,] currentRegion, int swappedI, int swappedJ, HashSet<int> validSquareNum, int i, int j, int[,] finalTable)
        {
            foreach (int num in validSquareNum)
            {
                currentRegion[i, j] = currentRegion[swappedI, swappedJ];
                currentRegion[swappedI, swappedJ] = num;
                if (!CheckOneValueFinal(finalTable, i, j))
                {
                    currentRegion[swappedI, swappedJ] = currentRegion[i, j];
                    currentRegion[i, j] = 0;
                    return false;
                }
                else
                {
                    if (!CheckOneValueFinal(finalTable, i, j))
                    {
                        currentRegion[swappedI, swappedJ] = currentRegion[i, j];
                        currentRegion[i, j] = 0;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public bool CheckOneValueFinal(int[,] finalTable, int i, int j)
        {
            if (!CheckFinalColumn(j, i, j, finalTable))
            {
                return false;
            }
            else
            {
                if (!CheckFinalRow(j, i, j, finalTable))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool CheckFinalTable(int[,] finalTable, Dictionary<string, List<string>> regionsCoordinates, List<int[,]> regionsList)
        {
            PopulateSudoku p = new PopulateSudoku();
            string[,] finalRegionString = new string[9, 9];
            for (int i = 0; i < finalTable.GetLength(0); i++)
            {
                for (int j = 0; j < finalTable.GetLength(1); j++)
                {
                    finalRegionString[i, j] = finalTable[i, j].ToString();
                }
                //Console.WriteLine();
            }
            regionsList = p.ReturnRegionsList(finalRegionString);
            for (int i = 0; i < finalTable.GetLength(0); i++)
            {
                for (int j = 0; j < finalTable.GetLength(1); j++)
                {
                    string value = i.ToString() + "," + j.ToString();
                    int regionNum = 0;
                    for (int k = 0; k < regionsCoordinates.Keys.Count(); k++)
                    {
                        if (regionsCoordinates[k.ToString()].Contains(value))
                        {
                            regionNum = k;
                            break;
                        }
                    }
                    int tempI = i;
                    if (i > 2)
                    {
                        tempI = i - 3;
                    }
                    if (i > 5)
                    {
                        tempI = i - 6;
                    }
                    int tempJ = j;
                    if (j > 2)
                    {
                        tempJ = j - 3;
                    }
                    if (j > 5)
                    {
                        tempJ = j - 6;
                    }
                    if (!CheckFinalSquare(regionsList[regionNum], finalTable[i, j], tempI, tempJ))
                    {
                        return false;
                    }
                    if (!CheckFinalColumn(j, i, j, finalTable))
                    {
                        return false;
                    }
                    if (!CheckFinalRow(j, i, j, finalTable))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CheckFinalColumn(int colNum, int i, int j, int[,] finalTable)
        {
            for (int k = 0; k < finalTable.GetLength(1); k++)
            {
                if (finalTable[i, j] == finalTable[i, k] && k != j)
                {
                    return false;
                }
            }
            return true;
        }
        public bool CheckFinalRow(int colNum, int i, int j, int[,] finalTable)
        {
            for (int k = 0; k < finalTable.GetLength(0); k++)
            {
                if (finalTable[i, j] == finalTable[k, j] && k != i)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckFinalSquare(int[,] region, int addNum, int k, int l)
        {
            for (int i = 0; i < region.GetLength(0); i++)
            {
                for (int j = 0; j < region.GetLength(1); j++)
                {
                    if (region[i, j] == addNum && (k != i && l != j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CheckSameSolution(int[,] addedRegion, int[,] newRegion)
        {
            bool sameSolution = false;
            for (int i = 0; i < addedRegion.GetLength(0); i++)
            {
                for (int j = 0; j < addedRegion.GetLength(1); j++)
                {
                    if (addedRegion[i, j] == newRegion[i, j])
                    {
                        sameSolution = true;
                    }
                    else
                    {
                        Console.WriteLine("DIFFERENT AT{0},{1}", i, j);
                        return false;
                    }
                }
            }
            return sameSolution;
        }
    }
}
