using System.Data;

namespace WinFormsApp1
{
    public partial class Calculator : System.Windows.Forms.Form
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int result = 0;
        char operation = '\0';
        bool calculationCompleted = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private int FindOperatorIndex(string text, out char foundOp)
        {
            foundOp = '\0';
            if (string.IsNullOrEmpty(text)) return -1;
            char[] ops = new char[] { '+', '-', '*', '/', 'X', '÷' };
            int idx = text.IndexOfAny(ops);
            if (idx >= 0) foundOp = text[idx];
            return idx;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            if (calculationCompleted)
            {
                txtUserInput.Text = string.Empty;
                txtResult.Text = "0";
                calculationCompleted = false;
            }

            // 1. 전체 수식에 숫자 추가
            txtUserInput.Text += btn.Text;

            // 2. txtResult에 현재 입력 중인 "마지막 숫자 뭉치"만 표시
            // 예: "48 + 12" 입력 중이면 "12"만 추출
            string currentInput = txtUserInput.Text;
            char[] operators = new char[] { '+', '-', '*', '/', 'X', '÷', '(', ')' };

            string[] parts = currentInput.Split(operators, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length > 0)
            {
                // 가장 마지막에 있는 숫자 뭉치를 가져와서 결과창에 표시
                txtResult.Text = parts[parts.Length - 1].Trim();
            }
        }
        private void AppendOperator(string opChar)
        {
            if (calculationCompleted)
            {
                // 계산 완료 후 연산자를 누르면 결과값에서 이어서 시작
                txtUserInput.Text = txtResult.Text;
                calculationCompleted = false;
            }

            if (!string.IsNullOrEmpty(txtUserInput.Text))
            {
                txtUserInput.Text += " " + opChar + " ";
            }
        }



        private void btnCalculatorMultiplied_Click(object sender, EventArgs e)
        {

            AppendOperator("X");
        }



        private void btnCalculatorMinus_Click(object sender, EventArgs e)
        {
            AppendOperator("-");
        }

        private void btnCalculatorPlus_Click(object sender, EventArgs e)
        {
            AppendOperator("+");
        }

        private void btnCalculatorEqual_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtUserInput.Text?.Trim();
                if (string.IsNullOrEmpty(input)) return;

                // 1. 생략된 곱셈 기호 자동 삽입 (전처리)
                // 숫자(0-9) 또는 ')' 뒤에 '('가 오면 그 사이에 '*' 삽입
                string processedInput = System.Text.RegularExpressions.Regex.Replace(input, @"(\d|\))(?=\()", "$1 * ");
                // ')' 뒤에 숫자(0-9)가 오면 그 사이에 '*' 삽입
                processedInput = System.Text.RegularExpressions.Regex.Replace(processedInput, @"(\))(?=\d)", "$1 * ");

                // 2. 계산을 위해 화면용 기호 치환 (X -> *, ÷ -> /)
                string expression = processedInput.Replace("X", "*").Replace("÷", "/");

                // 3. DataTable을 이용한 수식 계산
                DataTable table = new DataTable();
                var evalResult = table.Compute(expression, "");

                // 4. 결과값 처리 (소수점 등 대응을 위해 double로 변환 후 출력 권장)
                txtResult.Text = evalResult.ToString();
                txtUserInput.Text = $"{input} = {evalResult}";
                calculationCompleted = true;
                operation = '\0';
            }
            catch (Exception)
            {
                MessageBox.Show("수식이 잘못되었습니다. 괄호와 연산자 배치를 확인하세요.");
            }
        }

        private void btnCalculatorDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatorSignChange_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatorDivision_Click(object sender, EventArgs e) // 나누기 버튼 클릭 이벤트 핸들러
        {
            AppendOperator("÷");
        }



        private void btnCalculatorCE_Click(object sender, EventArgs e)
        {

            string text = txtUserInput.Text ?? string.Empty;


            if (calculationCompleted && text.Contains("="))
            {
                string leftOfEq = text.Split('=')[0].Trim();
                int opIndex = leftOfEq.IndexOfAny(new char[] { '+', '-', '*', '/', 'X', '÷' });
                if (opIndex >= 0)
                {

                    string left = leftOfEq.Substring(0, opIndex).Trim(); // 왼쪽 피연산자 부분
                    char op = leftOfEq[opIndex];
                    operation = op;
                    txtUserInput.Text = left + " " + operation + " ";
                    txtResult.Text = left; // 결과도 왼쪽 피연산자 값으로 초기화
                    calculationCompleted = false;
                    return;
                }
                else
                {

                    txtUserInput.Text = string.Empty;
                    txtResult.Text = string.Empty;
                    calculationCompleted = false;
                    operation = '\0';
                    return;
                }
            }


            int existingOp = text.IndexOfAny(new char[] { '+', '-', '*', '/', 'X', '÷' });
            if (existingOp >= 0)
            {

                string left = text.Substring(0, existingOp).Trim();
                char op = text[existingOp];
                if (op == 'X') op = '*';
                if (op == '÷') op = '/';
                operation = op;
                char displayOp = (operation == '*') ? 'X' : (operation == '/') ? '÷' : operation;
                txtUserInput.Text = left + " " + displayOp + " ";
                txtResult.Text = left;
            }
            else
            {

                txtUserInput.Text = string.Empty;
                txtResult.Text = string.Empty;
                operation = '\0';
            }
        }

        private void btnCalculatorDel_Click(object sender, EventArgs e)
        {

            if (calculationCompleted) { btnCalculatorC_Click(null, null); return; }
            string text = txtUserInput.Text;
            if (text.Length > 0)
            {
                txtUserInput.Text = text.Substring(0, text.Length - 1);
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatorPercentage_Click(object sender, EventArgs e)
        {

        }

        private void btnLParentheses_Click(object sender, EventArgs e)
        {
            if (calculationCompleted) { txtUserInput.Text = "("; calculationCompleted = false; }
            else txtUserInput.Text += "(";
        }


        // 기존 초기화/삭제 기능 유지
        private void btnCalculatorC_Click(object sender, EventArgs e)
        {
            txtUserInput.Text = string.Empty;
            txtResult.Text = "0";
            calculationCompleted = false;
            operation = '\0';
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {

        }

        private void btnRParentheses_Click(object sender, EventArgs e)
        {
            txtUserInput.Text += ")";
        }
    }
}
