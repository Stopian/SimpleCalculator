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
                    txtResult.Text = txtUserInput.Text.Trim(); // 결과는 입력한 숫자 그대로 보여줌
                }
                else
                {
                    int opIndex = txtUserInput.Text.IndexOf(operation);
                    if (opIndex >= 0)
                    {
                        string right = txtUserInput.Text.Substring(opIndex + 1).Trim();
                        txtResult.Text = string.IsNullOrEmpty(right) ? "0" : right; // 연산자 뒤에 숫자가 없으면 0으로 표시
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
            
        }



        private void btnCalculatorMinus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculatorPlus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserInput.Text, out firstNumber))
            {
                operation = '+';// 연산자 설정
                txtUserInput.Text = firstNumber.ToString() + " " + operation + " ";
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
            int opIndex = txtUserInput.Text.IndexOf(operation);

            // 연산자 기준으로 좌/우 피연산자 문자열을 얻음
            string left = "";
            string right = "";
            if (opIndex >= 0)
            {
                left = txtUserInput.Text.Substring(0, opIndex).Trim();       // 연산자 왼쪽 부분
                right = txtUserInput.Text.Substring(opIndex + 1).Trim();     // 연산자 오른쪽 부분
            }

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

            // 요청대로 더하기(+) 처리.
            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }
            else
            {
                result = 0;
            }

            // 결과를 보여줌
            txtResult.Text = result.ToString();

            // 입력란에 완전한 식과 결과를 표시 (예: "5 + 3 = 8")
            txtUserInput.Text = $"{firstNumber} {operation} {secondNumber} = {result}";

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

        private void btnCalculatorDivision_Click(object sender, EventArgs e)
        {
           
        }
    }
}
