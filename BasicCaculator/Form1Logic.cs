using BasicCaculator.Utility;
using System.Numerics;

namespace BasicCaculator
{
    public class Form1Logic
    {
        /// <summary>
        /// 計算するイベント
        /// </summary>
        /// <param name="operation">演算子</param>
        /// <param name="num1">1番目のオペランド</param>
        /// <param name="num2">2番目のオペランド</param>
        /// <returns>計算した結果</returns>
        public string CalculateMethod(string operation, decimal num1, decimal num2)
        {
            double calculatedResult = 0.0;

            // 計算する。
            switch (operation)
            {
                case ContanstVariable.OPERATIONS.PLUS:
                    calculatedResult = (double)num1 + (double)num2;
                    break;
                case ContanstVariable.OPERATIONS.MINUS:
                    calculatedResult = (double)num1 - (double)num2;
                    break;
                case ContanstVariable.OPERATIONS.TIMES:
                    calculatedResult = (double)num1 * (double)num2;
                    break;
                case ContanstVariable.OPERATIONS.DIVIDE:

                    // ゼロを分割するチェック。
                    if (num2 != 0)
                    {
                        calculatedResult = (double) (num1 / num2);
                    }
                    else
                    {
                        return string.Empty;
                    }
                    calculatedResult = (double) (num1 / num2);
                    break;
                default:
                    break;
            }

            return calculatedResult.ToString();
        }
    }
}
