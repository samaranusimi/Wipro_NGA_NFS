using System;

namespace GenricsDemo{
    class GenericsClass<T>{
        public T Data; 
        public void Display(T value){
            Console.WriteLine( "Value is "+value); 
        }
    }
}