using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagementSystem
{
    class SmartCounter
    {
        public static string NextInt(string currentValue)
        {
            /* Initialization */
            currentValue = currentValue.Trim();

            /* Array Elements */
            string strNewID = string.Empty;
            List<int> integerList = new List<int>();
            List<string> stringIntList = new List<string>();
            List<string> codeList = new List<string>();
            char[] currentArray = new char[currentValue.Length];

            /* Temporary elements */
            char[] temp = new char[currentValue.Length];
            int tempCounter = 0;
            bool stringFirst = false;
            bool movement = false;

            int silCount = 0;
            int codeCount = 0;

            /* Convert currentValue to character array */
            currentArray = currentValue.ToCharArray();

            /* Initialize temporary character array to spaces */
            for (int count = 0; count < currentValue.Length; count++)
            {
                temp[count] = ' ';
            }

            /* Add to list the list of numbers and words */
            for (int count = 0; count < currentValue.Length; count++)
            {
                /* if the current character in the passed string is a number */
                if (char.IsDigit(currentArray[count]))
                {
                    // assign the value of the current array to the temporary then increment
                    temp[tempCounter] = currentArray[count];
                    tempCounter++;

                    if (count < currentValue.Length - 1)
                    {
                        if (!char.IsDigit(currentArray[count + 1]))
                        {
                            integerList.Add(Convert.ToInt32(new string(temp).Trim()));
                            stringIntList.Add(new string(temp).Trim());

                            for (int count2 = 0; count2 < temp.Length; count2++)
                            {
                                temp[count2] = ' ';
                            }

                            tempCounter = 0;
                        }
                    }
                    else if (count == currentValue.Length - 1)
                    {
                        integerList.Add(Convert.ToInt32(new string(temp).Trim()));
                        stringIntList.Add(new string(temp).Trim());

                        for (int count2 = 0; count2 < temp.Length; count2++)
                        {
                            temp[count2] = ' ';
                        }

                        tempCounter = 0;

                    }
                }

                /* if the current character in the passed string is NOT a number */
                else
                {
                    temp[tempCounter] = currentArray[count];
                    tempCounter++;

                    if (count < currentValue.Length - 1)
                    {
                        /* If the next character is a number */
                        if (char.IsDigit(currentArray[count + 1]))
                        {
                            codeList.Add(new string(temp).Trim());

                            for (int count2 = 0; count2 < temp.Length; count2++)
                            {
                                temp[count2] = ' ';
                            }
                            tempCounter = 0;
                        }
                    }
                    else if (count == currentValue.Length - 1)
                    {
                        codeList.Add(new string(temp).Trim());

                        for (int count2 = 0; count2 < temp.Length; count2++)
                        {
                            temp[count2] = ' ';
                        }

                        tempCounter = 0;
                    }
                }
            }

            /* Incrementor Loop */
            for (int count = stringIntList.Count - 1; count >= 0; count--)
            {
                int numberOfDigits = 0;
                string digitToNumber = "";

                numberOfDigits = stringIntList[count].Length;
                if (integerList[count].ToString().Length == numberOfDigits)
                {
                    for (int count2 = 0; count2 < numberOfDigits; count2++)
                    {
                        digitToNumber += "9";
                    }

                    if (integerList[count].ToString().Equals(digitToNumber))
                    {
                        digitToNumber = "0";
                        for (int count2 = 0; count2 < numberOfDigits; count2++)
                        {
                            digitToNumber += "0";
                        }

                        integerList[count] = Convert.ToInt32(digitToNumber);
                        stringIntList[count] = integerList[count].ToString("D" + stringIntList[count].Length);

                        continue;
                    }
                    else
                    {
                        integerList[count] = integerList[count] + 1;
                        stringIntList[count] = integerList[count].ToString("D" + stringIntList[count].Length);
                        movement = true;
                        break;
                    }
                }
                else
                {
                    integerList[count] = integerList[count] + 1;
                    stringIntList[count] = integerList[count].ToString("D" + stringIntList[count].Length);
                    movement = true;
                    break;
                }
            }

            for (int count = 0; count < (stringIntList.Count + codeList.Count); )
            {
                if (count == 0 && !char.IsDigit(currentArray[0]))
                {
                    stringFirst = true;
                }

                if (stringFirst)
                {
                    try
                    {
                        strNewID += codeList[codeCount].ToString().Trim();
                        codeCount++;
                        strNewID += stringIntList[silCount].ToString().Trim();
                        silCount++;
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }
                else
                {
                    try
                    {
                        strNewID += stringIntList[silCount].ToString().Trim();
                        silCount++;
                        strNewID += codeList[codeCount].ToString().Trim();
                        codeCount++;
                    }
                    catch (ArgumentOutOfRangeException)
                    {

                    }
                }

                count = codeCount + silCount;
            }

            if (!movement)
            {
                strNewID = string.Empty;
            }

            return (strNewID);
        }
    }
}
