namespace GitPractice
{
    public class MyClass2
    {
        private string _name;
        private int _age;
        public string Name 
        { 
            get { return _name; }
            set { _name = value; } 
        }
        public int Age 
        { 
            get { return _age; }
            set { _age = value; }
        }

        public MyClass2(string Name, int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }
    }
}