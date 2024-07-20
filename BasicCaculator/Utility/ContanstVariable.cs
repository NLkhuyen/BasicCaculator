namespace BasicCaculator.Utility
{
    /// <summary>
    /// 固定変数クラス
    /// </summary>
    public static class ContanstVariable
    {
        /// <summary>
        /// 演算子
        /// </summary>
        public static class OPERATIONS
        {
            public const string PLUS = "+";
            public const string MINUS = "-";
            public const string TIMES = "*";
            public const string DIVIDE = "÷";
        }

        // ・の文字列
        public const string DECIMAL_SYMBOL = ".";

        // イコール
        public const string EQUAL_SYMBOL = "=";

        // ダブルゼロの文字列
        public const string DOUBLE_ZERO = "00";

        // ゼロの文字列
        public const string ZERO = "0";

        // ゼロの文字列
        public const string DIVDED_BY_ZERO_ERROR = "ERROR DIV BY ZERO";

        // 最大桁数
        public const int NUMBER_MAX_LENGTH = 20;
    }
}
