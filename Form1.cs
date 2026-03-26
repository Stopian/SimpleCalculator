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
            var btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                if (calculationCompleted)
                {
                    txtUserInput.Text = string.Empty;
                    calculationCompleted = false;
                }
                txtUserInput.Text += btn.Text;

                if (operation == '\0')
                {
                    txtResult.Text = txtUserInput.Text.Trim();
                }
                else
                {
                    char foundOp;
                    int opIndex = FindOperatorIndex(txtUserInput.Text, out foundOp);
                    if (opIndex >= 0)
                    {
                        string right = txtUserInput.Text.Substring(opIndex + 1).Trim();
                        txtResult.Text = string.IsNullOrEmpty(right) ? "0" : right;
                    }
                    else
                    {
                        txtResult.Text = "0";
                    }
                }
            }
        }
        private void btnCalculatorMultiplied_Click(object sender, EventArgs e)
        {

            if (calculationCompleted)
            {
                if (int.TryParse(txtResult.Text, out firstNumber))
                {
                    calculationCompleted = false;
                    operation = '*';
                    char displayOp = operation == '*' ? 'X' : operation;
                    txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
                }
                return;
            }

            string text = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            int existingOp = text.IndexOfAny(new char[] {'+', '-', '*', '/', 'X', '÷'}); // 이미 연산자가 있는지 확인
            if (existingOp >= 0)
            {
                string left = text.Substring(0, existingOp).Trim();
                if (int.TryParse(left, out firstNumber))
                {
                    operation = '*';
                    char displayOp = operation == '*' ? 'X' : operation;
                    txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
                }
                return;
            }

            if (int.TryParse(text, out firstNumber))
            {
                operation = '*';
                char displayOp = operation == '*' ? 'X' : operation;
                txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
            }
        }



        private void btnCalculatorMinus_Click(object sender, EventArgs e)
        {
            if (calculationCompleted)
            {
                if (int.TryParse(txtResult.Text, out firstNumber))
                {
                    calculationCompleted = false;
                    operation = '-';
                    txtUserInput.Text = firstNumber.ToString() + " " + operation + " ";
                }
                return;
            }

            string text = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            int existingOp = text.IndexOfAny(new char[] {'+', '-', '*', '/', 'X', '÷'});
            if (existingOp >= 0)
            {
                string left = text.Substring(0, existingOp).Trim();
                if (int.TryParse(left, out firstNumber))
                {
                    operation = '-';
                    char displayOp = operation;
                    txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
                }
                return;
            }

            if (int.TryParse(text, out firstNumber))
            {
                operation = '-';
                char displayOp = operation;
                txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
            }
        }

        private void btnCalculatorPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserInput.Text, out firstNumber))
            {
                operation = '+';// 연산자 설정
                char displayOp = operation;
                txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
            }
        }

        private void btnCalculatorEqual_Click(object sender, EventArgs e)
        {
            string input = txtUserInput.Text?.Trim();// txtUserInput이 null일 수 있으므로 null 체크 후 Trim() 호출

            if (string.IsNullOrEmpty(input) && operation == '\0') // 입력이 없고 연산자도 없는 경우
            {
                result = 0;
                txtResult.Text = "0";
                return;
            }

            if (!string.IsNullOrEmpty(input) && operation == '\0') // 입력이 있고 연산자 없는 경우 (단일 숫자 입력)
            {
                if (int.TryParse(input, out int singleValue))
                {
                    result = singleValue;
                    txtResult.Text = result.ToString();// 입력한 숫자 그대로 결과 표시
                }
                else
                {
                    txtResult.Text = "0";
                }
                return;
            }

            
            // 문자열에서 연산자 위치를 찾음 (예: "5 + 3"에서 '+' 위치)
            char foundOp;
            int opIndex = FindOperatorIndex(txtUserInput.Text, out foundOp);

            // 연산자 기준으로 좌/우 피연산자 문자열을 얻음
            string left = "";
            string right = "";
            if (opIndex >= 0)
            {
                left = txtUserInput.Text.Substring(0, opIndex).Trim();       // 연산자 왼쪽 부분
                right = txtUserInput.Text.Substring(opIndex + 1).Trim();     // 연산자 오른쪽 부분
            }

            // foundOp는 화면에 보이는 연산자일 수 있으므로 내부 연산자 기호로 설정
            char opForCalc = foundOp;
            if (foundOp == 'X') opForCalc = '*';
            if (foundOp == '÷') opForCalc = '/';

            // 왼쪽 문자열을 정수로 바꿈(실패하면 0으로 설정)
            if (!int.TryParse(left, out firstNumber))
            {
                firstNumber = 0;
            }

            // 오른쪽 문자열을 정수로 바꿈(실패하면 0으로 설정)
            if (!int.TryParse(right, out secondNumber))
            {
                secondNumber = 0;
            }

            if (opForCalc == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (opForCalc == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (opForCalc == '*')
            {
                result = firstNumber * secondNumber;
            }
            else if (opForCalc == '/')
            {
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    MessageBox.Show("0 으로 나눌 수 없습니다.");

                    calculationCompleted = true; // 계산이 완료된 상태로 설정하여 다음 입력 시 새로 시작하도록 함
                    operation = '\0';
                    return;
                }
            }
            else
            {
                result = 0;
            }

            // 결과를 보여줌
            txtResult.Text = result.ToString();

            // 입력란에 완전한 식과 결과를 표시 (예: "5 + 3 = 8")
            txtUserInput.Text = $"{firstNumber} {foundOp} {secondNumber} = {result}";

            // 표시가 끝났음을 표시 다음 숫자 입력 시 새로 시작
            calculationCompleted = true;

            // 다음 계산을 위해 연산자 상태 초기화
            operation = '\0';
        }

        private void btnCalculatorDecimal_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatorSignChange_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatorDivision_Click(object sender, EventArgs e) // 나누기 버튼 클릭 이벤트 핸들러
        {
            if (calculationCompleted)
            {
                if (int.TryParse(txtResult.Text, out firstNumber))
                {
                    calculationCompleted = false;
                    operation = '/';
                    char displayOp = operation == '/' ? '÷' : operation;
                    txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
                }
                return;
            }

            string text = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            int existingOp = text.IndexOfAny(new char[] {'+', '-', '*', '/', 'X', '÷'});
            if (existingOp >= 0)
            {
                string left = text.Substring(0, existingOp).Trim();
                if (int.TryParse(left, out firstNumber))
                {
                    operation = '/';
                    char displayOp = operation == '/' ? '÷' : operation;
                    txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
                }
                return;
            }

            if (int.TryParse(text, out firstNumber))
            {
                operation = '/';
                char displayOp = operation == '/' ? '÷' : operation;
                txtUserInput.Text = firstNumber.ToString() + " " + displayOp + " ";
            }
        }

        private void btnCalculatorC_Click(object sender, EventArgs e) // 초기화 버튼 클릭 이벤트 핸들러
        {

            firstNumber = 0;
            secondNumber = 0;
            result = 0;
            operation = '\0';
            calculationCompleted = false;
            txtUserInput.Text = string.Empty;
            txtResult.Text = string.Empty;
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

            if (calculationCompleted)
            {
                txtUserInput.Text = string.Empty; 
                txtResult.Text = string.Empty;
                calculationCompleted = false;
                operation = '\0';
                return;
            }

            string text = txtUserInput.Text ?? string.Empty;
            if (string.IsNullOrEmpty(text)) return;

            int existingOp = text.IndexOfAny(new char[] { '+', '-', '*', '/', 'X', '÷' });
            if (existingOp >= 0)
            {

                string left = text.Substring(0, existingOp).Trim();
                char op = text[existingOp];
                string right = text.Substring(existingOp + 1).Trim();

                if (string.IsNullOrEmpty(right))
                {

                    txtUserInput.Text = left;
                    txtResult.Text = left;
                    operation = '\0';
                    return;
                }


                string newRight = right.Substring(0, Math.Max(0, right.Length - 1));
                if (string.IsNullOrEmpty(newRight))
                {
                    txtUserInput.Text = left + " " + op + " ";
                    txtResult.Text = left;
                }
                else
                {
                    txtUserInput.Text = left + " " + op + " " + newRight;
                    txtResult.Text = newRight;
                }
            }
            else
            {

                string newText = text.Substring(0, Math.Max(0, text.Length - 1));
                txtUserInput.Text = newText;
                txtResult.Text = newText;
            }
        }
    }
}
