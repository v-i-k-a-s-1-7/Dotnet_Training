namespace OopsSession.Constructor
{

    public class Associate
    {
        // class variables
        private int id;
        public string Name { get; set; }
        public int Rank { get; set; }

        public int Id
        {
            set
            {
                if (value > 0)   
                    this.id = value;
                else
                {
                    this.id = 0;
                    throw new ArgumentException("ID must be positive.");
                }
            }
        }

        public Associate(int id, string name, int rank)
        {
            this.id = id;
            this.Name = name;
            this.Rank = rank;
        }

    }

}