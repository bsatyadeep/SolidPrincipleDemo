using System;

namespace Calculator
{
    public interface ICalculation<T> where T : class
    {
        int Result(int Input1, int Input2);
    }

    public class Test
    {
        public Test()
        {
            Calculator calculator = new Calculator();
            calculator.Addition(1, 2);

        }
    }
    public class Calculator
    {
        readonly ICalculation<Add> addCalculation = new Add();
        readonly ICalculation<Subtract> subtractCalculation = new Subtract();
        readonly ICalculation<Multiply> multiplyCalculation = new Multiply();
        readonly ICalculation<Devide> devideCalculation = new Devide();

        public int Addition(int input1, int input2)
        {
            return addCalculation.Result(input1, input2);
        }
        public int Subtraction(int input1, int input2)
        {
            return subtractCalculation.Result(input1, input2);
        }
        public int Multiplication(int input1, int input2)
        {
            return multiplyCalculation.Result(input1, input2);
        }
        public int Division(int input1, int input2)
        {
            return devideCalculation.Result(input1, input2);
        }
    }
    public class Add : ICalculation<Add>
    {
        public int Result(int Input1, int Input2)
        {
            return Input1 + Input2;
        }
    }
    public class Subtract : ICalculation<Subtract>
    {
        public int Result(int Input1, int Input2)
        {
            return Input1 - Input2;
        }
    }
    public class Multiply : ICalculation<Multiply>
    {
        public int Result(int Input1, int Input2)
        {
            return Input1 * Input2;
        }
    }
    public class Devide : ICalculation<Devide>
    {
        public int Result(int Input1, int Input2)
        {
            return Input1 / Input2;
        }
    }
}

