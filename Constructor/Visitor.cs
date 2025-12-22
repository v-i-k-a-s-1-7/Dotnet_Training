namespace OopsSession.Constructor {

    public class Visitor {

        public int Id { get; set; }              // 8 byte
        public string? Name { get; set; }        // 16 byte
        public string? Requirement { get; set; } // 16 byte

        public string LogHistory;
    

        // private constructor to save memory from empty definition
        // Visitor visitor = new Visitor();
        private Visitor() {
               
            LogHistory += $"Visitor object created at {System.DateTime.Now} \n";
        }

        // Constructor Overloading 
        // giving only one arguement as we require
        public Visitor(int Id) {
            this.Id = Id;
            LogHistory += $"Visitor object with Id {Id} created at {System.DateTime.Now} \n";
        }


        public Visitor(int id, string name) {
            this.Id = id;
            this.Name = name;
            if (name.ToLower().Contains("Vikas"))
            {
                throw new ArgumentException("Hey, Vikas is not allowed");
            }

            LogHistory += $"Visitor object with Id {id} and Name {name} created at {System.DateTime.Now} \n";
        }

        public Visitor(int id, string name, string requirement) {

            this.Id = id;
            this.Name = name;
            this.Requirement = requirement;

            LogHistory += $"Visitor object with Id {id}, Name {name} and Requirement {requirement} created at {System.DateTime.Now} \n";
        }
    }
}