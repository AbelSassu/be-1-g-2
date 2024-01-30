namespace be_1_g_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert data");
            Console.WriteLine("Name: ");
            string readName = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string readCognome = Console.ReadLine();
            Console.WriteLine("Age: ");
            byte readEta = byte.Parse(Console.ReadLine());
            Persona p1 = new Persona(readName, readCognome, readEta);
            p1.GetDetails();
            
        }
    } class Persona
    {
        private string _name;
        private string _cognome;
        private byte _eta;

        public string Name
        { 
        get { return _name; }
        set {
                if (value.Length > 0)
                { 
                _name = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public string Cognome
        {
            get { return _cognome; }
            set
            {
                if (value.Length > 0)
                {
                    _cognome = char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public byte Eta
        {
            get { return _eta; }
            set
            {
                if (value > 0 && value < 140)
                {
                    _eta = value;
                }
            }
        }
        public Persona(string nome, string cognome, byte eta)
        {
            Name = nome;
            Cognome = cognome;
            Eta = eta;
        }
        public void GetDetails()
        {
            Console.WriteLine("Ciao mi chiamo " + Name + " " + Cognome + " e ho " + Eta + " anni");
        }
    }
}
