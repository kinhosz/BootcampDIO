using System.Collections.Generic;

namespace Series{

    public interface IList<T>{

        void add(T element);
        void delete(int id);
        T get(int id);
        void update(int id, T element);
        List<T> list();
    }
}