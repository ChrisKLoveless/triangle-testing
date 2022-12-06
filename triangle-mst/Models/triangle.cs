namespace Triangle
{
    public class Tri
    {
        public int sideA { get; private set; }
        public int sideB { get; private set; }
        public int sideC { get; private set; }

        public Tri(int a, int b, int c)
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        public bool AllSidesEqual()
        {
            return sideA == sideB && sideB == sideC;
        }

        public bool TwoEqual()
        {
            return AllSidesEqual() == false && (sideA == sideB || sideA == sideC || sideB == sideC);
        }

        public bool NoSidesEqual()
        {
            return sideA != sideB && sideB != sideC && sideC != sideA;
        }

        public bool IsTriangle()
        {
            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}