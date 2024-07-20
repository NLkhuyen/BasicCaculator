using BasicCaculator.Utility;

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
            decimal calculatedResult = Decimal.Zero;

            // 計算する。
            switch (operation)
            {
                case ContanstVariable.OPERATIONS.PLUS:
                    calculatedResult = num1 + num2;
                    break;
                case ContanstVariable.OPERATIONS.MINUS:
                    calculatedResult = num1 - num2;
                    break;
                case ContanstVariable.OPERATIONS.TIMES:
                    calculatedResult = num1 * num2;
                    break;
                case ContanstVariable.OPERATIONS.DIVIDE:

                    // ゼロを分割するチェック。
                    if (num2 != 0)
                    {
                        calculatedResult = num1 / num2;
                    }
                    else
                    {
                        return string.Empty;
                    }
                    calculatedResult = num1 / num2;
                    break;
                default:
                    break;
            }

            return calculatedResult.ToString();
        }
    }
}
