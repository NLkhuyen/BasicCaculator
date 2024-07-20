using System.Globalization;
using System.Numerics;
using BasicCaculator.Utility;

namespace BasicCaculator
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        // 1番目のオペランドを格納する文字列
        string operand1 = BigInteger.Zero.ToString();

        // 2番目のオペランドを格納する文字列
        string operand2 = BigInteger.Zero.ToString();

        // M+を格納する変数
        string memoryInput = BigInteger.Zero.ToString();

        // 変数を格納する演算子
        string operation = string.Empty;

        // 結果の変数
        decimal result = Decimal.Zero;

        // 操作ボタンがクリックされたフラグ
        bool operationClicked = false;

        // 押したボンタン名
        string buttonClicked = string.Empty;

        // ロジッククラスを作成
        Form1Logic f1Logic = new Form1Logic();

        /// <summary>
        /// フォーム初期コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数字ボタンをクックするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberButton_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;
            
            // 先の計算した後、自動的に結果とかを削除するため。
            if (result != Decimal.Zero && operation == ContanstVariable.EQUAL_SYMBOL)
            {
                ButtonAC_Click(sender, e);
            }
            // 連計算するとき、テキストボックスの値を削除するため。
            else if (result != Decimal.Zero && operationClicked)
            {
                numberDisplay.Text = BigInteger.Zero.ToString();
            }

            if (btn != null)
            {
                // ・のボタンをクリックするイベント
                if (btn.Text.Equals(ContanstVariable.DECIMAL_SYMBOL))
                {
                    if (!numberDisplay.Text.Contains(ContanstVariable.DECIMAL_SYMBOL))
                    {
                        numberDisplay.Text += btn.Text;
                    }
                }
                // 「00」以外をクリックするかつテキストボックスが「0」場合、そのままセットする。
                else if (numberDisplay.Text.Equals(ContanstVariable.ZERO) && !btn.Text.Equals(ContanstVariable.DOUBLE_ZERO))
                {
                    numberDisplay.Text = btn.Text;
                }
                // 「00」をクリックするかつテキストボックスが「0」場合、「0」をセットする。
                else if (numberDisplay.Text.Equals(ContanstVariable.ZERO) && btn.Text.Equals(ContanstVariable.DOUBLE_ZERO))
                {
                    numberDisplay.Text = ContanstVariable.ZERO.ToString();
                }
                else
                {
                    numberDisplay.Text += btn.Text;
                }
            }

            this.buttonClicked = btn == null?string.Empty:Text;
            operationClicked = false;
        }

        /// <summary>
        /// 操作ボタンをクックするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperationButton_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 連計算する場合、先の計算をやる事
            if (!String.IsNullOrWhiteSpace(operation) && operation != ContanstVariable.EQUAL_SYMBOL)
            {
                ButtonEqual_Click(sender, e);
            }

            // 1番目のオペランドを設定する。
            operand1 = numberDisplay.Text;

            // 格納する演算子を設定する。
            switch (btn?.Text)
            {
                case ContanstVariable.OPERATIONS.PLUS:
                    operation = ContanstVariable.OPERATIONS.PLUS;
                    break;
                case ContanstVariable.OPERATIONS.MINUS:
                    operation = ContanstVariable.OPERATIONS.MINUS;
                    break;
                case ContanstVariable.OPERATIONS.TIMES:
                    operation = ContanstVariable.OPERATIONS.TIMES;
                    break;
                case ContanstVariable.OPERATIONS.DIVIDE:
                    operation = ContanstVariable.OPERATIONS.DIVIDE;
                    break;
                default:
                    break;
            }

            // テキストボックスに出す。
            numberDisplay.Text = result.ToString();
            this.buttonClicked = btn == null ? string.Empty : Text;
            operationClicked = true;
        }

        /// <summary>
        /// 結果を計算するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 2番目のオペランドを設定する。
            operand2 = numberDisplay.Text;

            // 文字列から数字に変換する。
            decimal num1, num2;
            decimal.TryParse(operand1, CultureInfo.InvariantCulture, out num1);
            decimal.TryParse(operand2, CultureInfo.InvariantCulture, out num2);

            // 2番目を設定しなくて、イコールをクリックする時、何もやりません。
            if (operationClicked)
            {
                return;
            }

            var calculateResult = f1Logic.CalculateMethod(operation, num1, num2);

            // ゼロを分割するチェック。
            if (!String.IsNullOrWhiteSpace(calculateResult)) 
            {
                decimal.TryParse(calculateResult, out result);
            }
            else
            {
                calculateResult = ContanstVariable.DIVDED_BY_ZERO_ERROR;
            }

            numberDisplay.Text = calculateResult;

            // イコールのオペレーションをマークする。
            operation = ContanstVariable.EQUAL_SYMBOL;
            this.buttonClicked = btn == null ? string.Empty : Text;
        }

        /// <summary>
        /// 計算したことを削除するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAC_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 初期値を再セットする。
            this.numberDisplay.Text = Decimal.Zero.ToString();
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.operation = string.Empty;
            this.result = Decimal.Zero;

            this.buttonClicked = btn == null ? string.Empty : Text;
        }

        /// <summary>
        /// 2番目のオペランドを削除するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonC_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 2番目が初期値を設定する。
            this.numberDisplay.Text = BigInteger.Zero.ToString();
            this.operand2 = string.Empty;

            this.buttonClicked = btn == null ? string.Empty : Text;
        }

        /// <summary>
        /// M+ボタンをクリックするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMPlus_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 最初から設定する。
            if (String.IsNullOrWhiteSpace(this.memoryInput))
            {
                this.memoryInput = this.numberDisplay.Text;
            }
            else
            {
                // 文字列から数字に変換する。
                decimal num1, num2;
                decimal.TryParse(memoryInput, CultureInfo.InvariantCulture, out num1);
                decimal.TryParse(numberDisplay.Text, CultureInfo.InvariantCulture, out num2);

                // メモリーに値を入れる。
                this.memoryInput = (num1 + num2).ToString();
            }

            this.buttonClicked = btn == null ? string.Empty : Text;
        }

        /// <summary>
        /// M-ボタンをクリックするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMMinus_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            // 最初から設定する。
            if (String.IsNullOrWhiteSpace(this.memoryInput))
            {
                this.memoryInput = this.numberDisplay.Text;
            }
            else
            {
                // 文字列から数字に変換する。
                decimal num1, num2;
                decimal.TryParse(memoryInput, out num1);
                decimal.TryParse(numberDisplay.Text, out num2);

                // メモリーに値を入れる。
                this.memoryInput = (num1 - num2).ToString();
            }

            this.buttonClicked = btn == null ? string.Empty : Text;
        }

        /// <summary>
        /// MRCボタンをクリックするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMRC_Click(object sender, EventArgs e)
        {
            // クリックしたボタンを取得するため。
            var btn = sender as Button;

            if (this.buttonClicked.Equals(btn?.Text))
            {
                // メモリーのあたいを削除する
                this.memoryInput = string.Empty;
                this.numberDisplay.Text = Decimal.Zero.ToString();
            }
            else
            {
                this.numberDisplay.Text = this.memoryInput;
            }

            this.buttonClicked = btn == null ? string.Empty : Text;
        }
    }
}
