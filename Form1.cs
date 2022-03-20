namespace trigonometric
{
    public partial class Form1 : Form
    {
        private const int repeat_times = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_start_Click(object sender, EventArgs e)
        {
            if (!(deg.Checked || rad.Checked) && (sin.Checked || cos.Checked || tan.Checked))
            {
                MessageBox.Show("角度単位設定、計算モードを両方指定してください。");
                return;
            }

            string get_angle = angle.Text;
            double Angle = 0;
            double result = 0;

            try
            {
                Angle = double.Parse(get_angle);
            }
            catch
            {
                MessageBox.Show("半角数字を入力してください。");
            }

            if (deg.Checked)
            {
                Angle = Angle / 180 * Math.PI;
            }

            while (true)
            {
                if(Angle < 0)
                {
                    Angle += 2 * Math.PI;
                    break;
                }
                else
                {
                    Angle -= 2 * Math.PI;
                }
            }

            if (sin.Checked)
            {
                result = Sin(Angle);
            }
            else if (cos.Checked)
            {
                result = Cos(Angle);
            }
            else if (tan.Checked)
            {
                result= Tan(Angle);
            }

            cal_result.Text = result.ToString();
        }

        private long Factorial(int n)
        {
            if(n == 0)
            {
                return 1L;
            }
            return n * Factorial(n - 1);
        }

        private double Sin(double angle)
        {
            double result = 0;
            for(int i = 0; i < repeat_times; i++)
            {
                result += Math.Pow(-1, i) / Factorial(2 * i + 1) * Math.Pow(angle, 2 * i + 1);
            }
            return result;
        }

        private double Cos(double angle)
        {
            double result = 0;
            for (int i = 0; i < repeat_times; i++)
            {
                result += Math.Pow(-1, i) / Factorial(2 * i) * Math.Pow(angle, 2 * i);
            }
            return result;
        }

        private double Tan(double angle)
        {
            return (Cos(angle) / Sin(angle));
        }
    }
}