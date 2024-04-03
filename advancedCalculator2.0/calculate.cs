using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedCalculator2._0
{
    public class calculate
    {
        double a, b;
        Operations op;
        bool f_first = false;
        bool f_second = false;
        string str = "";

        public string History
        {
            get => str;
            set
            {
                str = value;
            }
        }

        public double A
        {
            get => a;
            set
            {
                a = value;
                f_first = true;
            }
        }
        public double B
        {
            get => b;
            set
            {
                b = value;
                f_second = true;
            }
        }
        public Operations Op { get => op; private set => op = value; }

        public enum Operations // перечисление операций
        {
            none,
            sum,
            sub,
            mul,
            div,
            sqr,
            fr,
            sqrt
        }

        private double Cal() // Метод вычисления
        {
            str = "";
            str += A;
            AddOpToHistory();
            switch (op)
            {
                case Operations.sum:
                    A += B;
                    break;
                case Operations.sub:
                    A -= B;
                    break;
                case Operations.mul:
                    A *= B;
                    break;
                case Operations.div:
                    if (B != 0)
                    {
                        A /= B;
                    }
                    else throw new DivideByZeroException();
                    break;
                default:
                    break;
            }
            str += B;
            str += "=";
            return A;
        }

        public string Inp_op(double v, Operations op, bool change)
        {
            // было в самом конце (предпоследняя строчка метода
            Op = op;
            if (!change)
            {
                f_second = false;
                if (str != "")
                {
                    //str = str.Substring(0, str.Length - 1);
                    str = v.ToString();
                }
                AddOpToHistory();
            }
            else
            {
                if (!f_second && f_first)
                {
                    B = v;
                    Cal();
                    f_second = false;
                }

                if (!f_first)
                {
                    A = v;
                    str = "";
                    str += A;
                    AddOpToHistory();
                }
            }

            return A.ToString();
        }

        public string UnaryOperation(Operations un, double operand)
        {
            switch (un)
            {
                case Operations.sqr:
                    operand = Math.Pow(operand, 2);
                    break;

                case Operations.sqrt:
                    if (operand < 0)
                    {
                        throw new ArgumentException();
                    }
                    operand = Math.Sqrt(operand);
                    break;

                // 1/x
                case Operations.fr:
                    if (operand == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    operand = 1 / operand;
                    break;

                default:
                    break;
            }
            return operand.ToString();
        }

        public string Out(double v)
        {
            if (Op == Operations.none)
            {
                A = v;
                return A.ToString();
            }

            if (f_second && !f_first)
            {
                A = v;
            }

            if (!f_second)
            {
                B = v;
            }

            return Cal().ToString();
        }
        public void ChangeSign()
        {
            A = -A;
        }

        public void FromHistory(string text, bool f_ravno)
        {
            if (f_ravno)
            {
                A = 0;
                f_first = false;
            }
        }

        public void Sbros()
        {
            A = B = 0;
            f_first = false;
            f_second = false;
            str = "";
            Op = Operations.none;
        }

        private void AddOpToHistory()
        {
            switch (op)
            {
                case Operations.sum:
                    str += "+";
                    break;
                case Operations.sub:
                    str += "-";
                    break;
                case Operations.mul:
                    str += "*";
                    break;
                case Operations.div:
                    str += "/";
                    break;
                default:
                    break;
            }
        }
    }
}
