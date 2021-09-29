using System.Collections.Generic;

namespace Series{

    class Catalog: IList<Serie>{

        private List<Serie> serie;
        public int nextId { get; private set; }


        public Catalog(){
            this.nextId = 0;
            serie = new List<Serie>();
        }

        public void add(Serie serie){

            this.serie.Add(serie);
            this.nextId++;
        }
        
        public void delete(int id){

            if(id >= this.nextId) return ;

            if(!this.serie[id].active) return ;

            this.serie[id].active = false;
        }
        
        public Serie get(int id){
            
            if(id >= this.nextId) return null;

            if(!this.serie[id].active) return null;

            return this.serie[id];
        }
        
        public void update(int id, Serie serie){

            if(id >= this.nextId) return ;
            if(!this.serie[id].active) return ;

            this.serie[id].update(serie.title, serie.description, serie.author);
        }
        
        public List<Serie> list(){
            
            List<Serie> series = new List<Serie>();

            for(int i=0;i<this.nextId;i++){
                if(!this.serie[i].active) continue;

                series.Add(this.serie[i]);
            }

            return series;
        }
    }
}