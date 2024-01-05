namespace CalcLib
{
    public class Calculator
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Add()
        {
            int result;
            result = Fnum + Snum;
            return result;
        }
        public int Sub()
        { 
            int result;
            result = Fnum - Snum;
            return result;
        }
        public int Mul()
        {
            int result;
            result = Fnum * Snum;
            return result;
        }
        public int Div()
        {
            int result;
            result = Fnum / Snum;
            return result;
        }
    }
}
