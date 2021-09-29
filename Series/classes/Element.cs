namespace Series{

    public abstract class Element{

        public int id { get; protected set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public bool active { get; set; }

        public abstract void update(string title, string description, string author);
    }
}