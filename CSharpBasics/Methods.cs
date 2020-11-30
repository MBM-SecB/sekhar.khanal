using System;
public class MethodTeacher
{
        public int Multiply(int  firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            return result;
        }


            // Generic Method
        public void Multiply<T>(T firstNum, T secondNum)
        {
            
        }

        // Variable numbers of arguments
        public int Multiply(params int[] numbers)
        {
            int product=1;
            foreach(int num in  numbers)
            {
                product = product * num;
            }
            return product;
        }
        // Named arguments
        void PrintCustomerDetails(string name, byte age,string adress, DateTime dob)
        {
            Console.Write("");
        }

    
}
public class MethodTester
    {
        void TestMethods()
        {
            MethodTeacher methodTeacher  = new MethodTeacher();
            int product  = methodTeacher.Multiply(2345,5678);

            methodTeacher.Multiply<decimal>(234.343m,34.73546m);

            product = methodTeacher.Multiply(45,876,234,652);

        }
    }