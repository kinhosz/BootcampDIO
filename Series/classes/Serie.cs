namespace Series{

    public class Serie: Element{

        public Serie(int id, string title, string description, string author){
            this.id = id;
            this.title = title;
            this.description = description;
            this.author = author;
            this.active = true;
        }

        public override void update(string title, string description, string author){
            this.title = title;
            this.description = description;
            this.author = author;
        }
    }
}