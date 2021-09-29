

namespace Exercicio_Fixacao_Arrays_Orien_Obj
{
    class Rooms
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public Rooms(string name, string email)
        {
            Name = name;
            Email = email;            
        }

        public override string ToString()
        {
            return ($"{Name}; {Email}");
        }

    }
}
