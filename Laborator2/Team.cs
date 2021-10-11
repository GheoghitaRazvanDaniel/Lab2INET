namespace Laborator2
{
    class Team
    {
        public int Number;
        public string Name;
        public int P;
        public int W;
        public int L;
        public int D;
        public int F;
        public int A;
        public int Points;

        public Team(int number, string name, int p, int w, int l, int d, int f, int a, int points)
        {
            Number = number;
            Name = name;
            P = p;
            W = w;
            L = l;
            D = d;
            F = f;
            A = a;
            Points = points;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
